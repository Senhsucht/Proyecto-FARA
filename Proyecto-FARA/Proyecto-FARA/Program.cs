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
            Application.Run(new Atenticacion());
        }

        public static void Home()
        {
            Form1 home = new Form1();

            Application.EnableVisualStyles();
            home.ShowDialog();
            
        }


    }
}
