using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Proyecto_FARA;

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

        //public static void BuscaDonante()
        //{
        //    conDonanate bdon = new conDonanate();

        //    Application.EnableVisualStyles();
        //    bdon.ShowDialog();

        //}

    }
}
