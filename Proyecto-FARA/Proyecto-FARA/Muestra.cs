using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_FARA
{
    public partial class Muestra : Form
    {

        private iModulo actualMod { get; set; }

        public Muestra()
        {
            InitializeComponent();
        }

        private void Muestra_Load(object sender, EventArgs e)
        {
            cambiarMod(new UCDonaciones());
        }


                private void cambiarMod(UserControl nMod)
        {
            if (actualMod != null)
            {
                ((IDisposable)actualMod).Dispose();
            }

            actualMod = (iModulo)nMod;
            nMod.Dock = DockStyle.Fill;
            nMod.Parent = panel1;

        }
    }
}
