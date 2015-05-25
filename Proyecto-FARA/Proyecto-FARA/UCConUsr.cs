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
    public partial class UCConUsr : UserControl , iModulo
    {
        public UCConUsr()
        {
            InitializeComponent();
        }

        private void btnBuscarA_Click(object sender, EventArgs e)
        {

            conUsuario cd = new conUsuario();
            cd.ShowDialog();

            lblIDAR.Text = Metodos.ID;
            lblUsrR.Text = Metodos.Usr;
            lblpwdr.Text = Metodos.Pwd;
            lbltusrR.Text = Metodos.tUsr;
            lblNombreAR.Text = Metodos.Nom + " " + Metodos.ApeP + " " + Metodos.ApeM;
            lblEdadAR.Text = Metodos.Edad;
            lblTelAR.Text = Metodos.Tel;
            lblDirecAR.Text = Metodos.Dir;
            lblEmailAR.Text = Metodos.Email;
            lblTAfilR.Text = Metodos.tAfil;
            if(Metodos.activo=="True")
            {
                lblactivoR.Text = "Usuario Activo";
            }
            else { lblactivoR.Text = "Usuario No Activo"; }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
