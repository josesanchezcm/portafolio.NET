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

namespace Zapateria.Formularios_Venta
{
    public partial class FormResumenVentaMensual : Form
    {

        private Conexion con;

        public FormResumenVentaMensual()
        {
            InitializeComponent();
            con = new Conexion();
            this.llenar_combo_año();
            this.comboBox1.SelectedIndex = 0;
        }

        public void llenar_combo_año()
        {
            con.cerrar_conexion();
            comboBox2.Items.Add("Seleccione");
            comboBox2.SelectedIndex = 0;
            string sql = "select año from datos_venta group by año";
            MySqlDataReader dr = con.busquedaRegistro(sql).ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    comboBox2.Items.Add(dr.GetValue(0));
                }
            }
        }

        private void buttonBuscarVenta_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex==0)
            {
                MessageBox.Show("Debe seleccionar el mes");
                dataGridViewListadoVentas.Rows.Clear();
            }
            else if (comboBox2.SelectedIndex==0)
            {
                MessageBox.Show("Debe seleccionar el año");
                dataGridViewListadoVentas.Rows.Clear();
            }
            else
            {
                con.cerrar_conexion();
                string sql = "select * from datos_venta where mes='" + comboBox1.SelectedIndex.ToString() + "' and año='" + comboBox2.SelectedItem.ToString() + "';";
                MySqlDataReader dr = con.busquedaRegistro(sql).ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Object[] row = { dr.GetValue(3), dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8), dr.GetValue(9) + "/" + dr.GetValue(10) + "/" + dr.GetValue(11) };
                        dataGridViewListadoVentas.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("El Mes no registra Ventas.");
                    dataGridViewListadoVentas.Rows.Clear();
                    comboBox1.SelectedIndex = 0;
                    comboBox2.SelectedIndex = 0;
                }
            }
        }
    }
}
