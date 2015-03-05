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
    public partial class FormBuscarZapato : Form
    {

        Conexion con;

        public FormBuscarZapato()
        {
            InitializeComponent();
            this.llenar_comboBox();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//busca por codigo del zapato
        {
            con=new Conexion();
            dataGridView1.Rows.Clear();
            if (textBox1.Text == "")
            {
                dataGridView1.Rows.Clear();
            }
            else
            {
                MySqlDataReader dr = con.busquedaRegistro("select * from zapato where codigo LIKE '" + textBox1.Text + "%'").ExecuteReader();
                if (dr.HasRows)
                {
                    while(dr.Read())
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

        private void textBox2_TextChanged(object sender, EventArgs e)//busca por marca de zapato
        {
            con = new Conexion();
            dataGridView1.Rows.Clear();
            if (textBox2.Text == "")
            {
                dataGridView1.Rows.Clear();
            }
            else
            {
                MySqlDataReader dr = con.busquedaRegistro("select * from zapato where marca LIKE '" + textBox2.Text + "%'").ExecuteReader();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//para seleccionar el tipo
        {
            con = new Conexion();

            if (comboBoxSeleccionTipo.SelectedIndex == 0)
            {
                dataGridView1.Rows.Clear();
            }
            else
            {
                MySqlDataReader dr = con.busquedaRegistro("select * from datos_zapato where tipo LIKE '" + comboBoxSeleccionTipo.SelectedIndex + "%'").ExecuteReader();
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

        public void llenar_comboBox()//llena el combobox y hace seleccionar una opcion
        {
            comboBoxSeleccionTipo.Items.Add("Seleccione");
            con = new Conexion();
            MySqlDataReader dr = con.busquedaRegistro("select * from tipo_zapato").ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                  comboBoxSeleccionTipo.Items.Add(dr.GetValue(1).ToString());
                }
            }
            else
            {
                MessageBox.Show("debe registrar tipos de calzado.");
                comboBoxSeleccionTipo.Enabled = false;
            }

            comboBoxSeleccionTipo.SelectedIndex = 0;
        }
    }
}
