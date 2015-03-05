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
    public partial class FormListarClientes : Form
    {

        Conexion con;

        public FormListarClientes()
        {
            InitializeComponent();
            con = new Conexion();
            this.listar_clientes();
        }

        public void listar_clientes()//lista todos los clientes registrados
        {
            string sql = "select * from datos_cliente";
            con.cerrar_conexion();
            MySqlDataReader dr = con.busquedaRegistro(sql).ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Object[] row = {dr.GetValue(0),dr.GetValue(1),dr.GetValue(2),dr.GetValue(3),dr.GetValue(4),dr.GetValue(5),dr.GetValue(6)};
                    dataGridViewListadoClientes.Rows.Add(row);
                }
                
            }
        }
    }
}
