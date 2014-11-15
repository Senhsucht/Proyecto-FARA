using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_FARA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Autenticacion());
            
        }

        public static void Home()
        {
            Home home = new Home();

            Application.EnableVisualStyles();
            home.ShowDialog();
            
        }

        //public void iniciarDelegados()
        //{
        //    Metodos mt = new Metodos();
        //    Delegados.miUsuario = mt.Iniciado;
        //}

    }
}
