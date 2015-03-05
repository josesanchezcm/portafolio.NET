using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
//origenes de datos
//Data Source=johani-PC\sqlexpress;Initial Catalog=zapateria;Integrated Security=True
namespace Zapateria
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }
    }
}
