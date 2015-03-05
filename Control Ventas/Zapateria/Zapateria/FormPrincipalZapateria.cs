using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Zapateria.FormulariosCliente;
using MySql.Data.MySqlClient;
using Clases;
using Zapateria.Formularios_Venta;

namespace Zapateria
{
    public partial class FormPrincipal : Form
    {

        private Conexion con;
        private int stock;
        private List<int> codigo=new List<int>();
        private List<Venta> v = new List<Venta>();
        private int cont = 0;
        private int total_articulos=0;
        private int subtotal_compra;
        private int neto_compra;
               
        public FormPrincipal()
        {
            InitializeComponent();
            con = new Conexion();
            buttonAgregarAlcarro.Visible = false;
            groupBoxFinalizarCompra.Visible = false;
            buttonVender.Visible = false;
            buttonCancelarCompra.Visible = false;
            buttonNuevaVenta.Visible = false;
        }

        private void registrarTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarTipo rt = new FormRegistrarTipo();
            rt.ShowDialog();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistroZapato nz = new FormRegistroZapato();
            nz.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListarZapato lz = new FormListarZapato();
            lz.ShowDialog();
        }

        private void edicionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuscarZapato bz = new FormBuscarZapato();
            bz.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditarZapato fe = new FormEditarZapato();
            fe.ShowDialog();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormRegistroCliente fc = new FormRegistroCliente();
            fc.ShowDialog();
        }

        private void tipoYDescuentosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistroTipoCliente frtc = new FormRegistroTipoCliente();
            frtc.ShowDialog();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormListarClientes fl = new FormListarClientes();
            fl.ShowDialog();
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormBuscarCliente fb = new FormBuscarCliente();
            fb.ShowDialog();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormEdicionCliente fedt = new FormEdicionCliente();
            fedt.ShowDialog();
        }

        private void textBoxBusquedaCliente_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBusquedaCliente.Text == "")
            {
                this.limpiar();
            }
            else
            {
                string sql = "select * from datos_todos where run LIKE '" + textBoxBusquedaCliente.Text + "%';";
                con.cerrar_conexion();
                MySqlDataReader dr = con.busquedaRegistro(sql).ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        this.textBoxRun.Text = dr.GetValue(0).ToString();
                        this.textBoxNombres.Text = dr.GetValue(1).ToString();
                        this.textBoxApellidos.Text = dr.GetValue(2).ToString();
                        this.textBoxFono.Text = dr.GetValue(3).ToString();
                        this.textBoxEmail.Text = dr.GetValue(4).ToString();
                        this.textBoxDireccion.Text = dr.GetValue(5).ToString();
                        this.textBoxTipoCliente.Text = dr.GetValue(6).ToString();
                        this.textBoxTipoClienteCompra.Text = dr.GetValue(6).ToString();
                        this.textBoxDescuento.Text = dr.GetValue(7).ToString();
                        this.textBoxDecuentoCompra.Text = dr.GetValue(7).ToString(); 
                    }
                }
                else
                {
                    this.limpiar(); 
                }
            }
        }

        public void limpiar()
        {
            this.textBoxRun.Text ="";
            this.textBoxNombres.Text = "";
            this.textBoxApellidos.Text = "";
            this.textBoxFono.Text = "";
            this.textBoxEmail.Text = "";
            this.textBoxDireccion.Text = "";
            this.textBoxTipoCliente.Text ="";
            this.textBoxDescuento.Text = "";
            this.textBoxTipoClienteCompra.Text = "-";
            this.textBoxDecuentoCompra.Text = ""; 
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
           
            dataGridViewVistaPreviaProducto.Rows.Clear();
            if (textBoxBusquedaProducto.Text == "")
            {
                dataGridViewVistaPreviaProducto.Rows.Clear();
                buttonAgregarAlcarro.Visible = false;
            }
            else
            {
                con.cerrar_conexion();
                MySqlDataReader dr = con.busquedaRegistro("select * from zapato where codigo LIKE '" + textBoxBusquedaProducto.Text + "%'").ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Object[] row = { dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5) };
                        dataGridViewVistaPreviaProducto.Rows.Add(row);
                    }
                    buttonAgregarAlcarro.Visible = true;
                }
                else
                {
                    dataGridViewVistaPreviaProducto.Rows.Clear();
                    buttonAgregarAlcarro.Visible = false;
                }
            }
        }

        private void buttonAgregarAlcarro_Click(object sender, EventArgs e)
        {
            if (textBoxRun.Text == "")
            {
                MessageBox.Show("Seleccione un cliente");
            }
            else
            {
                con.cerrar_conexion();
                string sql = "select stock from datos_zapato where codigo='" + textBoxBusquedaProducto.Text.Trim() + "';";
                MySqlDataReader dr = con.busquedaRegistro(sql).ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        stock = Convert.ToInt32(dr.GetValue(0));
                    }
                }

                if (stock > 0)
                {
                    con.cerrar_conexion();
                    string sql2 = "select * from datos_zapato where codigo='" + textBoxBusquedaProducto.Text.Trim() + "';";
                    MySqlDataReader dr2 = con.busquedaRegistro(sql2).ExecuteReader();
                    codigo.Add(Convert.ToInt32(textBoxBusquedaProducto.Text.Trim()));
                    
                    foreach (var item in codigo)
                    {
                        if (item.Equals(Convert.ToInt32(textBoxBusquedaProducto.Text.Trim())))
                        {
                            cont++;//cantidad de productos agregados al carro de compra.
                        }
                    }

                    if (cont > stock)
                    {
                        MessageBox.Show("Se ha alcanzado el stock máximo  del producto");
                    }
                    else
                    {                                              
                        if (dr2.HasRows)
                        {
                            this.Buscar(dataGridViewCarroCompra, textBoxBusquedaProducto.Text.Trim());

                            while (dr2.Read())
                            {
                                Object[] row = { dr2.GetValue(0), dr2.GetValue(1), dr2.GetValue(2), cont, dr2.GetValue(3), cont * Convert.ToInt32(dr2.GetValue(3)), "19%", this.neto(cont * Convert.ToInt32(dr2.GetValue(3))) };
                                dataGridViewCarroCompra.Rows.Add(row);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Producto Sin Stock");
                }
                cont = 0;
            }
        }

        private int neto(int bruto)
        {
            int neto = ((bruto * 19) / 100) + bruto;
            return neto;
        }

        private int descuento(int descuento,int neto)
        {
            int total=neto-((neto*descuento) / 100);
            return total;
        }

        private void Buscar(DataGridView dg,string codigo)
        {
            for (int i = 0; i < dg.RowCount; i++)
            {
                if (codigo.Equals(dg.Rows[i].Cells[0].Value.ToString()))
                {
                    dg.Rows.RemoveAt(i);
                }
            }
        }

        private bool Buscar_conirma_stock(DataGridView dg, string codigo)
        {
            bool stock_completo=false;

            for (int i = 0; i < dg.RowCount; i++)
            {
                if (codigo.Equals(dg.Rows[i].Cells[0].Value.ToString()))
                {
                    dg.Rows.RemoveAt(i);
                    stock_completo = true;
                }
            }

            return stock_completo;
        }

        private void buttonFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (dataGridViewCarroCompra.Rows.Count==0) 
            {
                MessageBox.Show("Debe ingresar productos al carro de compra");
            }
            else
            {
                if (MessageBox.Show("Proceder con el Pago", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < dataGridViewCarroCompra.Rows.Count; i++)
                    {
                        total_articulos += Convert.ToInt32(dataGridViewCarroCompra.Rows[i].Cells[3].Value.ToString());
                    }

                    for (int i = 0; i < dataGridViewCarroCompra.Rows.Count; i++)
                    {
                        subtotal_compra += Convert.ToInt32(dataGridViewCarroCompra.Rows[i].Cells[5].Value.ToString());
                    }

                    for (int i = 0; i < dataGridViewCarroCompra.Rows.Count; i++)
                    {
                        neto_compra += Convert.ToInt32(dataGridViewCarroCompra.Rows[i].Cells[7].Value.ToString());
                    }

                    textBoxTotalArticulos.Text = total_articulos.ToString();
                    textBoxSubtotalCompra.Text = subtotal_compra.ToString();
                    textBoxNetoCompra.Text = neto_compra.ToString();

                    total_articulos = 0;
                    subtotal_compra = 0;
                    neto_compra = 0;
                    dateTimePickerfechaVenta.Enabled = false;
                    textBoxTotalPago.Text = total_a_pagar(Convert.ToInt32(textBoxNetoCompra.Text), Convert.ToInt32(textBoxDecuentoCompra.Text)).ToString();
                    buttonCancelarCompra.Enabled = true;
                    buttonVender.Enabled = true;
                    buttonNuevaVenta.Visible = false;
                    buttonVender.Visible = true;
                    buttonCancelarCompra.Visible = true;
                    textBoxBusquedaCliente.Text = textBoxRun.Text;
                    buttonFinalizarCompra.Enabled = false;
                    textBoxBusquedaProducto.Enabled = false;
                    textBoxBusquedaCliente.Enabled = false;
                    textBoxBusquedaProducto.Text = "";
                    buttonAgregarAlcarro.Visible = false;
                    dataGridViewVistaPreviaProducto.Rows.Clear();
                    groupBoxFinalizarCompra.Visible = true;
                }
            }
        }

        private void textBoxBusquedaProducto_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxBusquedaProducto.Text = "";
        }

        public int total_a_pagar(int net,int des)
        {
            int total = net - ((net * des) / 100);
            return total;
        }

        public Venta crea_venta()
        {
            Venta v = new Venta();
            v.Run_Cliente = textBoxRun.Text;
            v.Subtotal = Convert.ToInt32(textBoxSubtotalCompra.Text);
            v.IVA = Convert.ToInt32(textBoxIVA.Text);
            v.Neto = Convert.ToInt32(textBoxNetoCompra.Text);
            v.Articulos_Venta = Convert.ToInt32(textBoxTotalArticulos.Text);
            v.Descuento = Convert.ToInt32(textBoxDecuentoCompra.Text);
            v.Total = Convert.ToInt32(textBoxTotalPago.Text);
            v.Dia=dateTimePickerfechaVenta.Value.Day.ToString();
            v.Mes=dateTimePickerfechaVenta.Value.Month.ToString();
            v.Año = dateTimePickerfechaVenta.Value.Year.ToString();
            return v;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Completar la compra", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (textBoxPagaCon.Text == "")
                {
                    MessageBox.Show("Ingrese monto para cancelar");
                }
                else
                {
                    if (Convert.ToInt32(textBoxPagaCon.Text) < Convert.ToInt32(textBoxTotalPago.Text))
                    {
                        MessageBox.Show("Monto invalido para cancelar");
                    }
                    else
                    {
                        string sql_actualiza_stock="";
 
                        for (int i = 0; i < dataGridViewCarroCompra.Rows.Count; i++)
                        {
                            con.cerrar_conexion();
                            sql_actualiza_stock = "update zapato set stock='" + this.actualiza_stock(dataGridViewCarroCompra.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(dataGridViewCarroCompra.Rows[i].Cells[3].Value.ToString())) + "'where codigo='" + dataGridViewCarroCompra.Rows[i].Cells[0].Value.ToString() + "'; ";
                            con.cerrar_conexion();
                            con.ejecutar_sql(sql_actualiza_stock);
                        }

                        con.cerrar_conexion();
                        Venta v = crea_venta();
                        string sql_inerta_venta = "insert into venta(id_cliente,subtotal_compra,iva,neto_compra,articulos_vendidos,descuento,total_recaudado,dia,mes,año)values('" + v.Run_Cliente + "','" + v.Subtotal + "','" + v.IVA + "','" + v.Neto + "','" + v.Articulos_Venta + "','" + v.Descuento + "','" + v.Total + "','" + v.Dia + "','" + v.Mes + "','" + v.Año + "');";
                        if (con.ejecutar_sql(sql_inerta_venta) == 1)
                        {
                            textBoxVuelto.Text = (Convert.ToInt32(textBoxPagaCon.Text) - Convert.ToInt32(textBoxTotalPago.Text)).ToString();
                            buttonNuevaVenta.Visible = true;
                            buttonCancelarCompra.Enabled = false;
                            buttonVender.Enabled = false;
                            cont = 0;
                            dateTimePickerfechaVenta.Value = DateTime.Today;
                            MessageBox.Show("Productos vendidos");
                        }
                        else
                        {
                            MessageBox.Show("Problemas al realizar la venta");
                        }
                    }
                }
            }
        }

        public int actualiza_stock(string codigo_producto,int articulos_vendidos)
        {
            int stock_actual = 0;
            
            string sql = "select stock from zapato where codigo='"+codigo_producto+"';";
            MySqlDataReader dr = con.busquedaRegistro(sql).ExecuteReader();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    stock_actual = Convert.ToInt32(dr.GetValue(0).ToString());
                }
            }

            return (stock_actual-articulos_vendidos);
        }

        private void buttonCancelarCompra_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea cancelar la compra", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.limpiar_cancelar();
            }
        }

        public void limpiar_cancelar()
        {
            this.textBoxBusquedaCliente.Text = "";
            dataGridViewCarroCompra.Rows.Clear();
            dataGridViewVistaPreviaProducto.Rows.Clear();
            textBoxSubtotalCompra.Text = "";
            textBoxNetoCompra.Text = "";
            textBoxTotalArticulos.Text = "";
            textBoxTipoClienteCompra.Text = "";
            textBoxDecuentoCompra.Text = "";
            textBoxTotalPago.Text = "";
            textBoxPagaCon.Text = "";
            textBoxVuelto.Text = "";
            textBoxBusquedaCliente.Enabled = true;
            textBoxBusquedaProducto.Enabled=true;
            buttonFinalizarCompra.Enabled = true;
            buttonVender.Visible = false;
            buttonCancelarCompra.Visible = false;
            groupBoxFinalizarCompra.Visible = false;
            dateTimePickerfechaVenta.Enabled = true;
        }

        private void buttonNuevaVenta_Click(object sender, EventArgs e)
        {
            this.limpiar_cancelar();
        }

        private void listadoVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListadoVentas flv = new FormListadoVentas();
            flv.ShowDialog();
        }

        private void resumenVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormResumenVentaMensual frmm = new FormResumenVentaMensual();
            frmm.ShowDialog();
        }

     }
}
