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
    public partial class FormListadoVentas : Form
    {

        Conexion con;

        public FormListadoVentas()
        {
            InitializeComponent();
            con = new Conexion();
            con.cerrar_conexion();
            this.listar_ventas();
            
        }

        public void listar_ventas()
        {
            con.cerrar_conexion();
            dataGridViewListadoVentas.Rows.Clear();
            string sql = "select * from datos_venta";
            MySqlDataReader dr = con.busquedaRegistro(sql).ExecuteReader();
            if(dr.HasRows)
            {
                while (dr.Read())
                {
                    Object[] row = { dr.GetValue(3), dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8), dr.GetValue(9)+"/"+dr.GetValue(10)+"/"+dr.GetValue(11) };
                    dataGridViewListadoVentas.Rows.Add(row);
                }

            }
            else
            {
                MessageBox.Show("Sin registro de ventas");
            }
        }

        private void textBoxBuscarVentaCliente_TextChanged(object sender, EventArgs e)
        {
            con.cerrar_conexion();
            dataGridViewListadoVentas.Rows.Clear();
            string sql = "select * from datos_venta where run LIKE '" + textBoxBuscarVentaCliente.Text + "%' ";
            MySqlDataReader dr = con.busquedaRegistro(sql).ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Object[] row = { dr.GetValue(3), dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8), dr.GetValue(9) + "/" + dr.GetValue(10) + "/" + dr.GetValue(11) };
                    dataGridViewListadoVentas.Rows.Add(row);
                }

            }
        }

       /* private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.cerrar_conexion();
            dataGridViewListadoVentas.Rows.Clear();

            if (comboBoxAños.SelectedItem.ToString() == "Seleccione")
            {
                con.cerrar_conexion();
                this.listar_ventas();
            }
            else
            {
                string sql = "select * from datos_venta where año LIKE '" + comboBoxAños.SelectedItem.ToString().Trim() + "%' ";
                MySqlDataReader dr = con.busquedaRegistro(sql).ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Object[] row = { dr.GetValue(3), dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8), dr.GetValue(9) + "/" + dr.GetValue(10) + "/" + dr.GetValue(11) };
                        dataGridViewListadoVentas.Rows.Add(row);
                    }

                }
            }
        }*/

       /* public void llennar_combo_año()
        {
            comboBoxAños.Items.Add("Seleccione");
            comboBoxAños.SelectedIndex = 0;
            con.cerrar_conexion();
            string sql = "select año from datos_venta group by año";
            MySqlDataReader dr = con.busquedaRegistro(sql).ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    comboBoxAños.Items.Add(dr.GetValue(0));
                }

            }
            else
            {
                MessageBox.Show("Sin registro de ventas");
            }
        }*/

       /* private void comboBoxMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.cerrar_conexion();
            dataGridViewListadoVentas.Rows.Clear();

            if (comboBoxMes.SelectedIndex == 0 || comboBoxAños.SelectedIndex == 0)
            {
                MessageBox.Show("Primero debe seleccionar el año");
                con.cerrar_conexion();
                this.listar_ventas();
            }
            else
            {
                string sql = "select * from datos_venta where mes ='" + comboBoxMes.SelectedIndex + "' and año='" + comboBoxMes.SelectedItem.ToString() + "' ";
                MessageBox.Show(sql);
                MySqlDataReader dr = con.busquedaRegistro(sql).ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Object[] row = { dr.GetValue(3), dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8), dr.GetValue(9) + "/" + dr.GetValue(10) + "/" + dr.GetValue(11) };
                        dataGridViewListadoVentas.Rows.Add(row);
                    }

                }
            }
        }*/
    }
}
