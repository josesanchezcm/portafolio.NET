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
    public partial class FormRegistroTipoCliente : Form
    {

        Conexion con;
        private string codigo;

        public FormRegistroTipoCliente()
        {
            InitializeComponent();
            con = new Conexion();
            this.listar_tipos();
            this.buttonCancelar.Visible = false;
            this.buttonEditarTipo.Visible = false;
            this.buttonEliminarTipo.Visible = false;
        }
        
        private void buttonRegistrarTipo_Click(object sender, EventArgs e)
        {
            if (textBoxNombreTipo.Text == "")
            {
                MessageBox.Show("Ingrese un Tipo de Cliente.");
            }
            else if(textBoxDescuento.Text == "")
            {
                MessageBox.Show("Ingrese el descuento asociado al tipo de cliente.");
            }
            else
            {
                con.cerrar_conexion();
                string sql = "insert into tipo_cliente (nombre_tipo,descuento)values('" + textBoxNombreTipo.Text.Trim() + "','" + textBoxDescuento.Text.Trim() + "');";
                if (con.ejecutar_sql(sql) == 1)
                {
                    MessageBox.Show("Registro Completado");
                    this.limpiar();
                    con.cerrar_conexion();
                    this.listar_tipos();
                }
                else
                {
                    MessageBox.Show("No se ha realizado el registrado");
                    this.limpiar();
                }
            }
        }

        private void limpiar()
        {
            textBoxNombreTipo.Text = "";
            textBoxDescuento.Text = "";
        }

        public void listar_tipos()
        {
            dataGridViewListarTipos.Rows.Clear();
            string sql = "select * from tipo_cliente";
            MySqlDataReader dr = con.busquedaRegistro(sql).ExecuteReader();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    Object[] row = { dr.GetValue(0), dr.GetValue(1), dr.GetValue(2) };
                    dataGridViewListarTipos.Rows.Add(row);
                }
            }
            else
            {
            }
        }

        private void agregarAEdiciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int row=dataGridViewListarTipos.CurrentCell.RowIndex;
            string codigo = dataGridViewListarTipos.Rows[row].Cells[0].Value.ToString();

            string sql = "select * from tipo_cliente where id_tipo='"+codigo+"';";
            con.cerrar_conexion();
            MySqlDataReader dr = con.busquedaRegistro(sql).ExecuteReader();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    this.codigo = dr.GetValue(0).ToString();
                    textBoxNombreTipo.Text = dr.GetValue(1).ToString();
                    textBoxDescuento.Text = dr.GetValue(2).ToString();
                }
                this.buttonRegistrarTipo.Visible = false;
                this.buttonCancelar.Visible = true;
                this.buttonEditarTipo.Visible = true;
                this.buttonEliminarTipo.Visible = true;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.limpiar();
            this.buttonRegistrarTipo.Visible = true;
            this.buttonCancelar.Visible = false;
            this.buttonEditarTipo.Visible = false;
            this.buttonEliminarTipo.Visible = false;
        }

        private void buttonEditarTipo_Click(object sender, EventArgs e)
        {
            if (textBoxNombreTipo.Text == "")
            {
                MessageBox.Show("Ingrese un Tipo de Cliente.");
            }
            else if (textBoxDescuento.Text == "")
            {
                MessageBox.Show("Ingrese el descuento asociado al tipo de cliente.");
            }
            else
            {
                con.cerrar_conexion();
                string sql = "update tipo_cliente set nombre_tipo = '" + textBoxNombreTipo.Text.Trim() + "',descuento = '" + textBoxDescuento.Text.Trim() + "' where id_tipo='"+codigo+"';";
                if (con.ejecutar_sql(sql) == 1)
                {
                    MessageBox.Show("Edición Completada");
                    this.limpiar();
                    con.cerrar_conexion();
                    this.listar_tipos();
                    this.buttonRegistrarTipo.Visible = true;
                    this.buttonCancelar.Visible = false;
                    this.buttonEditarTipo.Visible = false;
                    this.buttonEliminarTipo.Visible = false;
        
                }
                else
                {
                    MessageBox.Show("No se ha realizado la Edición");
                    this.limpiar();
                    this.buttonRegistrarTipo.Visible = true;
                    this.buttonCancelar.Visible = false;
                    this.buttonEditarTipo.Visible = false;
                    this.buttonEliminarTipo.Visible = false;
        
                }
            }
        }

        private void buttonEliminarTipo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desas eliminar", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.cerrar_conexion();
                string sql = "delete from tipo_cliente where id_tipo='" + codigo + "';";
                if (con.ejecutar_sql(sql) == 1)
                {
                    MessageBox.Show("registro eliminado");
                    this.limpiar();
                    con.cerrar_conexion();
                    this.listar_tipos();
                    this.buttonRegistrarTipo.Visible = true;
                    this.buttonCancelar.Visible = false;
                    this.buttonEditarTipo.Visible = false;
                    this.buttonEliminarTipo.Visible = false;
                }
            }
        }
    }
}
