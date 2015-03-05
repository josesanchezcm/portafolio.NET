using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class Cliente
    {
        private string run;
        private string nombres;
        private string apellidos;
        private string fono;
        private string direccion;
        private string email;
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        
        public string Fono
        {
            get { return fono; }
            set { fono = value; }
        }


        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        
        public string Nombre
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Run
        {
            get { return run; }
            set { run = value; }
        }
        
    }
}
