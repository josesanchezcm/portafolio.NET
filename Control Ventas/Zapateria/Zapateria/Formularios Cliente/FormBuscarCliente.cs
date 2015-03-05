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
    public partial class FormBuscarCliente : Form
    {

        Conexion con;

        public FormBuscarCliente()
        {
            InitializeComponent();
            con = new Conexion();
            this.listar_clientes();
        }

        public void listar_clientes()
        {
            string sql = "select * from datos_cliente";
            con.cerrar_conexion();
            MySqlDataReader dr = con.busquedaRegistro(sql).ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Object[] row = { dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6) };
                    dataGridViewListadoClientes.Rows.Add(row);
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//busca los clientes por rut
        {
            dataGridViewListadoClientes.Rows.Clear();
            string sql = "select * from datos_cliente where run LIKE '"+textBox1.Text+"%';";
            con.cerrar_conexion();
            MySqlDataReader dr = con.busquedaRegistro(sql).ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Object[] row = { dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6) };
                    dataGridViewListadoClientes.Rows.Add(row);
                }

            }
        }
    }
}
