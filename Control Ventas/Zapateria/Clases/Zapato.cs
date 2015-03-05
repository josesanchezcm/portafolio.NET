using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class Zapato
    {
        
        private int numero;
        private string marca;
        private int precio;
        private int stock;
        private int tipo;
                
        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
    }
}
