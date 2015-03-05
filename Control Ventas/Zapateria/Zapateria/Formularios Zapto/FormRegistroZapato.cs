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
    public partial class FormRegistroZapato : Form
    {
        Conexion con = new Conexion();

        public FormRegistroZapato()
        {
            InitializeComponent();
            this.llenar_comboBox();  
        }

        public Zapato crea_zapato() 
        {
            Zapato z = new Zapato();
            z.Marca = textBoxMarca.Text;
            z.Precio = Convert.ToInt32(textBoxPrecio.Text);
            z.Numero = Convert.ToInt32(textBoxNumero.Text);
            z.Tipo = comboBoxTipoCalzado.SelectedIndex;
            z.Stock = Convert.ToInt32(textBoxStock.Text);
            return z;
        }

        private void buttonRegistroZapato_Click(object sender, EventArgs e)//metodo  boton registra zapato con todos los registros correspondientes
        {
            Zapato z = crea_zapato();
            con.cerrar_conexion();
            if (con.ejecutar_sql("insert into zapato(marca,numero,precio,tipo,stock)values('"+z.Marca+"','"+z.Numero+"','"+z.Precio+"','"+z.Tipo+"','"+z.Stock+"');") == 1)
            {
                MessageBox.Show("Registro Correcto","Registro");
               
            }
            else
            {
                MessageBox.Show("Registro Incorrecto", "Error");
            }

            this.limpiar();

        }

        public void limpiar()
        {
            textBoxStock.Text = "";
            textBoxPrecio.Text = "";
            textBoxNumero.Text = "";
            textBoxMarca.Text = "";
            comboBoxTipoCalzado.SelectedIndex = 0;
        }

        public void llenar_comboBox() 
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
                buttonRegistroZapato.Enabled = false;
            }

            comboBoxTipoCalzado.SelectedIndex = 0;
        }
    }
}
