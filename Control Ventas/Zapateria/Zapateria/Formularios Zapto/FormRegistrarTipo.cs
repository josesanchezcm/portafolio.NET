using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;
using MySql.Data.MySqlClient;

namespace Zapateria
{
    public partial class FormRegistrarTipo : Form
    {

        Conexion con = new Conexion();
       
        public FormRegistrarTipo()
        {
            InitializeComponent();
            this.listar_tipo_calzado();            
        }

        private void buttonRegistrarTipo_Click(object sender, EventArgs e)//metodo que registra el tipo de zapato
        {
            if (textBoxRegistrarTipo.Text == "")
            {
                MessageBox.Show("Ingrese un tipo de Calzado");
            }
            else
            {
                con.cerrar_conexion();
                if (con.ejecutar_sql("insert into tipo_zapato(nombre_tipo)values('" + textBoxRegistrarTipo.Text + "');") == 1)
                {
                    con.cerrar_conexion();
                    this.listar_tipo_calzado();

                    MessageBox.Show("Registro Completado");
                }
                else
                {
                    MessageBox.Show("Problema al Registrar");
                }
            }

        }

        public void listar_tipo_calzado() //metodo que lista los tipo de zapato en el datagridview
        {
            MySqlDataReader dr = con.busquedaRegistro("select * from tipo_zapato").ExecuteReader();
            dataGridViewListarTipo.Rows.Clear();
            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    Object[] row = { dr.GetValue(1) };
                    dataGridViewListarTipo.Rows.Add(row);
                }
            }
            else
            {
                MessageBox.Show("Sin Registros");
            }
        }
    }
}
