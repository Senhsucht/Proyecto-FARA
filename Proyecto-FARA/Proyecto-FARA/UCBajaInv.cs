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
    public partial class UCBajaInv : UserControl,iModulo
    {
        public UCBajaInv()
        {
            InitializeComponent();
        }
        
        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            conProducto cp = new conProducto();
            cp.ShowDialog();

            lblIDPR.Text = Metodos.ID;
            lblNombrePR.Text = Metodos.Nom;
            lblMarcaPR.Text = Metodos.MarPro;
            lblCNetoPR.Text = Metodos.CNetPro;

            Metodos.consultarDatos(int.Parse(Metodos.ID), "conInv");

            lblCantAcR.Text = Metodos.Cantidad;

        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que desea realizar la baja?", "Baja de Inventario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (lblIDPR.Text != "ID" && textBox1.Text != "" && textBox2.Text != "")
                {
                    Metodos.bajaInv(lblIDPR.Text, textBox1.Text, textBox2.Text);
                    MessageBox.Show("Baja realizada correctamente");
                }
                else
                {
                    MessageBox.Show("Llene los campos corresponientes");
                }
}
            
        }

    }
}
