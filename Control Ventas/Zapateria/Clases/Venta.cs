using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class Venta
    {
        private string run_cliente;
        private int subtotal;
        private int iva;
        private int neto;
        private int articulos_venta;
        private int descuento;
        private int total;
        private int codigo_producto;
        private string dia;
        private string mes;
        private string año;

        public string Año
        {
            get { return año; }
            set { año = value; }
        }

        public string Mes
        {
            get { return mes; }
            set { mes = value; }
        }

        public string Dia
        {
            get { return dia; }
            set { dia = value; }
        }


        public Venta()
        {
        }

        public Venta(int codigo, int articulos_venta)
        {
            this.codigo_producto = codigo;
            this.articulos_venta = articulos_venta;
        }

        public int Codigo_Producto
        {
            get { return codigo_producto; }
            set { codigo_producto = value; }
        }
        
        
        public int Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
        public int IVA
        {
            get { return iva; }
            set { iva = value; }
        }
        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        
        public int Articulos_Venta
        {
            get { return articulos_venta; }
            set { articulos_venta = value; }
        }
        
        public int Neto
        {
            get { return neto; }
            set { neto = value; }
        }

        public int Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        public string Run_Cliente
        {
            get { return run_cliente; }
            set { run_cliente = value; }
        }
        
    }
}
