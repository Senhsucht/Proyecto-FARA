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
    public partial class UCModUsr : UserControl , iModulo
    {
        public UCModUsr()
        {
            InitializeComponent();
        }

        private void gpbAfil_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscarA_Click(object sender, EventArgs e)
        {
            conUsuario cd = new conUsuario();
            cd.ShowDialog();

            lblIDAR.Text = Metodos.ID;
            txtUsr.Text = Metodos.Usr;
            txtPwd.Text = Metodos.Pwd;
            cbbTusr.SelectedValue = Metodos.IdTUsr;
            txtNom.Text = Metodos.Nom + " " + Metodos.ApeP + " " + Metodos.ApeM;
            txtEdad.Text = Metodos.Edad;
            txtTel.Text = Metodos.Tel;
            txtDirec.Text = Metodos.Dir;
            txtEmail.Text = Metodos.Email;
            txtTAfil.Text = Metodos.tAfil;
            if (Metodos.activo == "True")
            {
                ckbActivo.CheckState = CheckState.Checked;
            }
            else { ckbActivo.CheckState = CheckState.Unchecked; }
        }

        private void btnCamAfil_Click(object sender, EventArgs e)
        {
            conAfiliado cd = new conAfiliado();
            cd.ShowDialog();

            lblIDAR.Text = Metodos.ID;
            txtNom.Text = Metodos.Nom + " " + Metodos.ApeP + " " + Metodos.ApeM;
            txtEdad.Text = Metodos.Edad;
            txtTel.Text = Metodos.Tel;
            txtDirec.Text = Metodos.Dir;
            txtEmail.Text = Metodos.Email;
        }

        private void UCModUsr_Load(object sender, EventArgs e)
        {
            cbbTusr.DataSource = Metodos.LlenarCombo("TUSR");
            cbbTusr.DisplayMember = "Nombre";
            cbbTusr.ValueMember = "ID";
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            ConfirmacionAdmin ca = new ConfirmacionAdmin();
            ca.ShowDialog();

            if(Metodos.conAdm==true)
            {
                Metodos.UsrUpdate(txtUsr.Text,txtPwd.Text,cbbTusr.SelectedValue,lblIDAR.Text);
                MessageBox.Show("Modificacion exitosa");
            }
        }
    }
}
