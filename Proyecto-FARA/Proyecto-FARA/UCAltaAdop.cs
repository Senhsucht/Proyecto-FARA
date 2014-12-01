using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_FARA
{
    public partial class UCAltaAdop : UserControl,iModulo
    {
        public UCAltaAdop()
        {
            InitializeComponent();
        }

        private void lblDirecA_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarA_Click(object sender, EventArgs e)
        {
            conAdoptante ca = new conAdoptante();
            ca.ShowDialog();

            lblIDA.Text = Metodos.ID;
            lblNombreAR.Text = "Nombre completo: " + Metodos.Nom + " " + Metodos.ApeP + " " + Metodos.ApeM;
            lblEdadA.Text = "Edad: " + Metodos.Edad;
            lblTelAR.Text = "Telefono: " + Metodos.Tel;
            lblDirecA.Text = "Dirección: " + Metodos.Dir;
        }

        private void btnBuscarAn_Click(object sender, EventArgs e)
        {
            conAnimal can = new conAnimal();
            can.ShowDialog();

            lblIDA.Text = Metodos.ID;
            lblNomAn.Text = "Nombre: " + Metodos.Nom;
            lblTipA.Text = "Tipo de animal: " + Metodos.tAni;
            lblRazA.Text = "Raza: " + Metodos.rAni;
            lblEdadAn.Text = "Edad: " + Metodos.Edad;
        }

        private void btnAltAdop_Click(object sender, EventArgs e)
        {

        }
    }
}
