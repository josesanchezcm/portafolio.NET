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

namespace Zapateria
{
    public partial class FormEditarZapato : Form
    {

        Conexion con;
        private string codigo_zapato;
        private int stock;

        public FormEditarZapato()
        {
            InitializeComponent();
            con = new Conexion();
            this.listar_zapatos();
            con.cerrar_conexion();
            this.llenar_comboBox_editar();
            con.cerrar_conexion();
            this.llenar_comboBox_filtrar();
            this.buttonEditarZapato.Visible = false;
            this.buttonEliminarZapato.Visible = false;
            this.buttonCancelarEdicion.Visible = false;
        }

        public Zapato crear_zapato()
        {
            Zapato z= new Zapato();
            z.Marca = textBoxMarca.Text;
            z.Numero = Convert.ToInt32(textBoxNumero.Text);
            z.Precio = Convert.ToInt32(textBoxPrecio.Text);
            z.Tipo = comboBoxTipoCalzado.SelectedIndex;
            z.Stock = Convert.ToInt32(textBoxStock.Text);
            return z;
        }

        public void listar_zapatos()//lista los zapatos dependiendo de los datos ingresados
        {
            con = new Conexion();
            MySqlDataReader dr = con.busquedaRegistro("select * from datos_zapato").ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Object[] row = { dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5) };
                    dataGridView1.Rows.Add(row);
                }
            }
            else
            {
                MessageBox.Show("No existen Registros");
            }
        }

        public void llenar_comboBox_editar()//llena el combobox editar con el tipo de calzado
        {
            comboBoxTipoCalzado.Items.Add("Seleccione");

            MySqlDataReader dr = con.busquedaRegistro("select * from tipo_zapato").ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    comboBoxTipoCalzado.Items.Add(dr.GetValue(1).ToString());
                }
            }
            else
            {
                MessageBox.Show("debe registrar tipos de clazado.");
                
            }

            comboBoxTipoCalzado.SelectedIndex = 0;
        }

        public void llenar_comboBox_filtrar()
        {
            comboBoxFiltrar.Items.Add("Seleccione");

            MySqlDataReader dr = con.busquedaRegistro("select * from tipo_zapato").ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    comboBoxFiltrar.Items.Add(dr.GetValue(1).ToString());
                }
            }
            else
            {
                MessageBox.Show("debe registrar tipos de clazado.");

            }

            comboBoxFiltrar.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//muestra el zapato dependiendo del codigo ingresado
        {
            con = new Conexion();
            dataGridView1.Rows.Clear();
            if (textBox1.Text == "")
            {
                this.listar_zapatos();
            }
            else
            {
                MySqlDataReader dr = con.busquedaRegistro("select * from datos_zapato where codigo LIKE '" + textBox1.Text + "%'").ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Object[] row = { dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5) };
                        dataGridView1.Rows.Add(row);
                    }
                }
                else
                {
                    dataGridView1.Rows.Clear();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//selecciona marca del zapato y los muestra
        {
            con = new Conexion();
            dataGridView1.Rows.Clear();
            if (textBox2.Text == "")
            {
                this.listar_zapatos();  
            }
            else
            {
                MySqlDataReader dr = con.busquedaRegistro("select * from datos_zapato where marca LIKE '" + textBox2.Text + "%'").ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Object[] row = { dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5) };
                        dataGridView1.Rows.Add(row);
                    }
                }
                else
                {
                    dataGridView1.Rows.Clear();
                }
            }
        }

        private void comboBoxFiltrar_SelectedIndexChanged(object sender, EventArgs e)//en filtrar hace seleccionar el zapato por tipo y lo muestra 
        {

            con = new Conexion();

            if (comboBoxFiltrar.SelectedIndex == 0)
            {
                dataGridView1.Rows.Clear();
                this.listar_zapatos();
            }
            else
            {
                dataGridView1.Rows.Clear();
                MySqlDataReader dr = con.busquedaRegistro("select * from datos_zapato where tipo LIKE '" + comboBoxFiltrar.SelectedIndex + "%'").ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Object[] row = { dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5) };
                        dataGridView1.Rows.Add(row);
                    }
                }
                else
                {
                    dataGridView1.Rows.Clear();
                }
            }
        }

        private void agregarAEdiciónToolStripMenuItem_Click(object sender, EventArgs e)//metodo para agregar una edicion al zapato
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            this.codigo_zapato = dataGridView1.Rows[row].Cells[0].Value.ToString();
            textBoxMarca.Text=dataGridView1.Rows[row].Cells[1].Value.ToString();
            textBoxNumero.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            textBoxPrecio.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
            con.cerrar_conexion();
            string sql = "select tipo from datos_zapato where codigo='" + dataGridView1.Rows[row].Cells[0].Value.ToString() + "';";
            MySqlDataReader dr = con.busquedaRegistro(sql).ExecuteReader();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    comboBoxTipoCalzado.SelectedIndex = Convert.ToInt32(dr.GetValue(0));
                }
            }
            textBoxStock.Text = dataGridView1.Rows[row].Cells[5].Value.ToString();
            
            this.buttonEditarZapato.Visible = true;
            this.buttonEliminarZapato.Visible = true;
            this.buttonCancelarEdicion.Visible = true;
        }

        private void buttonEditarZapato_Click(object sender, EventArgs e)//metodo para editar zapato
        {
            con.cerrar_conexion();
            Zapato z=crear_zapato();
            string sql = "update zapato set marca='"+z.Marca+"',numero='"+z.Numero+"',precio='"+z.Precio+"',tipo='"+z.Tipo+"',stock='"+z.Stock+"' where codigo='"+codigo_zapato+"'; ";
            if(con.ejecutar_sql(sql)==1)
            {
                MessageBox.Show("Registro Editado");
                dataGridView1.Rows.Clear();
                this.listar_zapatos();
                this.limpiar();
                this.buttonEditarZapato.Visible = false;
                this.buttonEliminarZapato.Visible = false;
                this.buttonCancelarEdicion.Visible = false;
            }
            else
            {
                MessageBox.Show("Problemas al intentar editar el registro");
                dataGridView1.Rows.Clear();
                this.listar_zapatos();
                this.limpiar();
                this.buttonEditarZapato.Visible = false;
                this.buttonEliminarZapato.Visible = false;
                this.buttonCancelarEdicion.Visible = false;
            }
        }

        private void buttonCancelarEdicion_Click(object sender, EventArgs e)//metodo para cancelar la edicion 
        {
            this.limpiar();
            this.buttonEditarZapato.Visible = false;
            this.buttonEliminarZapato.Visible = false;
            this.buttonCancelarEdicion.Visible = false;
        }

        public void limpiar()
        {
            textBoxMarca.Text = "";
            textBoxNumero.Text = "";
            textBoxPrecio.Text = "";
            comboBoxTipoCalzado.SelectedIndex = 0;
            textBoxStock.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            comboBoxFiltrar.SelectedIndex = 0;
        }

        private void buttonEliminarZapato_Click(object sender, EventArgs e)//metodo para eliminar zapato
        {
            con.cerrar_conexion();
            string sql = "select stock from zapato where codigo='"+codigo_zapato+"';";
            MySqlDataReader dr = con.busquedaRegistro(sql).ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    stock=Convert.ToInt32(dr.GetValue(0));
                }
            }

            if (stock>0)
            {
                MessageBox.Show("El producto aún se encuentra con stock disponible y no se puede eliminar");
            }
            else
            {
                if (MessageBox.Show("Estas seguro que desas eliminar", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                    con.cerrar_conexion();
                    string sql1 = "delete from zapato where codigo='" + codigo_zapato + "';";
                    if (con.ejecutar_sql(sql1) == 1)
                    {
                        MessageBox.Show("El producto ha sido eliminado");
                        dataGridView1.Rows.Clear();
                        this.listar_zapatos();
                        this.limpiar();
                        this.buttonEditarZapato.Visible = false;
                        this.buttonEliminarZapato.Visible = false;
                        this.buttonCancelarEdicion.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("El producto no se puede eliminar");
                    }
                }
            }
        }
    }
}
