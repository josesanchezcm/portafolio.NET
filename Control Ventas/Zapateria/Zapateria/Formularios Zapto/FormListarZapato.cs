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
    public partial class FormListarZapato : Form
    {

        Conexion con;

        public FormListarZapato()
        {
            InitializeComponent();
            this.listar_zapatos();
        }

        public void listar_zapatos()//lista todos los zapatos ingresados
        {
            con = new Conexion();
            MySqlDataReader dr = con.busquedaRegistro("select * from zapato").ExecuteReader();
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
                MessageBox.Show("No existen Registros");
            }
        }
    }
}
