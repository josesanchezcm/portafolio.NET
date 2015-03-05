using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Clases;

namespace Zapateria.FormulariosCliente
{
    public partial class FormEdicionCliente : Form
    {

        Conexion con;

        public FormEdicionCliente()
        {
            InitializeComponent();
            con = new Conexion();
            this.labelMensaje.Text = "Ingrese run del cliente";
            this.llenar_comboBox();
            this.buttonEliminarCliente.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//metodo para por el rut encontrar al cliente
        {

            if (textBoxBusqueda.Text == "")
            {
                this.labelMensaje.Text = "Ingrese run del cliente";
                this.buttonEliminarCliente.Enabled = false;
                this.limpiar();
            }
            else{

                string sql = "select * from cliente where run LIKE '" + textBoxBusqueda.Text + "%';";
                con.cerrar_conexion();
                MySqlDataReader dr = con.busquedaRegistro(sql).ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        this.textBoxNombres.Text = dr.GetValue(1).ToString();
                        this.textBoxApellidos.Text = dr.GetValue(2).ToString();
                        this.textBoxFono.Text = dr.GetValue(3).ToString();
                        this.textBoxEmail.Text = dr.GetValue(4).ToString();
                        this.textBoxDireccion.Text = dr.GetValue(5).ToString();
                        this.comboBoxTipoCliente.SelectedIndex = Convert.ToInt32(dr.GetValue(6));
                    }
                    this.labelMensaje.Text = "Coincidencia encontrada";
                    this.buttonEliminarCliente.Enabled = true;
                }
                else
                {
                    this.labelMensaje.Text = "Sin Coincidencias";
                    this.buttonEliminarCliente.Enabled = false;
                    this.limpiar();
                }

            }
        }

        public void llenar_comboBox()
        {
            con.cerrar_conexion();
            string sql = "select nombre_tipo from tipo_cliente";
            MySqlDataReader dr = con.busquedaRegistro(sql).ExecuteReader();
            if (dr.HasRows)
            {
                comboBoxTipoCliente.Items.Add("Seleccione");
                comboBoxTipoCliente.SelectedIndex = 0;
                while (dr.Read())
                {
                    comboBoxTipoCliente.Items.Add(dr.GetValue(0).ToString());
                }
            }
        }

        public void limpiar()
        {
            this.textBoxNombres.Text = "";
            this.textBoxApellidos.Text = "";
            this.textBoxFono.Text = "";
            this.textBoxEmail.Text = "";
            this.textBoxDireccion.Text = "";
            this.comboBoxTipoCliente.SelectedIndex = 0;
        }

        public Cliente crea_cliente()
        {
            Cliente c = new Cliente();
            c.Nombre = textBoxNombres.Text;
            c.Apellidos = textBoxApellidos.Text;
            c.Fono = textBoxFono.Text;
            c.Email = textBoxEmail.Text;
            c.Direccion = textBoxDireccion.Text;
            c.Tipo = comboBoxTipoCliente.SelectedIndex.ToString();
            return c;
        }

        private void buttonRegistrarCliente_Click(object sender, EventArgs e)
        {
            Cliente c = crea_cliente();
            con.cerrar_conexion();
            string sql = "update cliente set nombres='" + c.Nombre + "',apellidos='" + c.Apellidos + "',fono='" + c.Fono + "',direccion='" + c.Direccion + "',email='" + c.Email + "',tipo='" + c.Tipo + "' where run='" + textBoxBusqueda.Text.Trim() + "';";
            if (con.ejecutar_sql(sql) == 1)
            {
                MessageBox.Show("Edicion Correcta");
                this.textBoxBusqueda.Text = "";
                this.limpiar();
            }
            else
            {
                MessageBox.Show("Por favor debe escribir el run completo");
            }
        }

        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {
           
                if (MessageBox.Show("Estas seguro que desas eliminar este Cliente", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.cerrar_conexion();
                    string sql = "delete from cliente where run='" + textBoxBusqueda.Text.Trim() + "'; ";
                    if (con.ejecutar_sql(sql) == 1)
                    {
                        MessageBox.Show("Cliente Eliminado");
                        this.textBoxBusqueda.Text = "";
                        this.limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Por favor debe escribir el run completo");

                    }
                }
        }
    }
}
