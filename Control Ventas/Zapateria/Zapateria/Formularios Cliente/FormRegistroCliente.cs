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
    public partial class FormRegistroCliente : Form
    {

        Conexion con;

        public FormRegistroCliente()
        {
            InitializeComponent();
            con = new Conexion();
            this.llenar_comboboxTipoCliente();
            con.cerrar_conexion();
        }

        public Cliente crea_cliente()
        {
            Cliente c = new Cliente();
            c.Run = textBoxRunNumero.Text + "-" + textBoxRunVerificador.Text;
            c.Nombre = textBoxNombres.Text;
            c.Apellidos = textBoxApellidos.Text;
            c.Fono = textBoxFono.Text;
            c.Email = textBoxEmail.Text;
            c.Direccion = textBoxDireccion.Text;
            c.Tipo = comboBoxTipoCliente.SelectedIndex.ToString();        
            return c;
        }

        private void buttonRegistrarCliente_Click(object sender, EventArgs e)
        {
            string run = textBoxRunNumero.Text;
            if (this.digitoVerificador(Convert.ToInt32(run)).ToString() != textBoxRunVerificador.Text)
            {
                MessageBox.Show("Run no valido");
            }
            else
            {
                Cliente c = crea_cliente();
                string sql = "insert into cliente values('" + c.Run + "','" + c.Nombre + "','" + c.Apellidos + "','" + c.Fono + "','" + c.Direccion + "','" + c.Email + "','" + c.Tipo + "')";
                if(con.ejecutar_sql(sql)==1)
                {
                    MessageBox.Show("Cliente Registrado");
                    this.limpiar();
                }
                else
                {
                    MessageBox.Show("No se ha podido registrar el cliente");
                }
            }
        }

        private void limpiar()
        {
            textBoxRunNumero.Text = "";
            textBoxRunVerificador.Text = "";
            textBoxNombres.Text = "";
            textBoxApellidos.Text = "";
            textBoxFono.Text = "";
            textBoxEmail.Text = "";
            textBoxDireccion.Text = "";
            comboBoxTipoCliente.SelectedIndex = 0;                
        }

        //funcion para validar run
        private string digitoVerificador(int rut)
        {
              int Digito;
              int Contador;
              int Multiplo;
              int Acumulador;
              string RutDigito;

              Contador = 2;
              Acumulador = 0;

              while (rut != 0)
              {
                  Multiplo = (rut % 10) * Contador;
                  Acumulador = Acumulador + Multiplo;
                  rut = rut/10;
                  Contador = Contador + 1;
                  if (Contador == 8)
                  {
                    Contador = 2;
                  }
              }

              Digito = 11 - (Acumulador % 11);
              RutDigito = Digito.ToString().Trim();

              if (Digito == 10 )
              {
                    RutDigito = "k";
              }

              if (Digito == 11)
              {
                    RutDigito = "0";
              }

              return (RutDigito);

          }

        public void llenar_comboboxTipoCliente()
        {

            string sql = "select nombre_tipo from tipo_cliente";
            MySqlDataReader dr = con.busquedaRegistro(sql).ExecuteReader();
            if (dr.HasRows)
            {
                comboBoxTipoCliente.Items.Add("Seleccione");
                comboBoxTipoCliente.SelectedIndex = 0;
                while(dr.Read())
                {
                    comboBoxTipoCliente.Items.Add(dr.GetValue(0).ToString());
                }
            }
        }
      }
}
