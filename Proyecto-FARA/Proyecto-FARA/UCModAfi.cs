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
    public partial class UCModAfi : UserControl,iModulo
    {
        public UCModAfi()
        {
            InitializeComponent();
        }

        private void btnConAfil_Click(object sender, EventArgs e)
        {
            conAfiliado cd = new conAfiliado();
            cd.ShowDialog();

            lblIDAR.Text = Metodos.ID;
            txtNom.Text = Metodos.Nom;
            txtApeP.Text=   Metodos.ApeP;
            txtApeM.Text=   Metodos.ApeM;
            txtEdad.Text = Metodos.Edad;
            txtTel.Text = Metodos.Tel;
            txtDirec.Text = Metodos.Dir;
            txtEmail.Text = Metodos.Email;
            cbbTAfil.SelectedValue = Metodos.IdTAfil;
            
        }

        private void UCModAfi_Load(object sender, EventArgs e)
        {
            cbbTAfil.DataSource = Metodos.LlenarCombo("TAFIL");
            cbbTAfil.DisplayMember = "Nombre";
            cbbTAfil.ValueMember = "ID";
        }

        private void btnCamAfil_Click(object sender, EventArgs e)
        {
            ConfirmacionAdmin ca = new ConfirmacionAdmin();
            ca.ShowDialog();

            if (Metodos.conAdm == true)
            {                
                if (txtNom.Text == "" || txtApeP.Text == "" || txtApeM.Text == "" || txtEdad.Text == "" || txtTel.Text == "" || txtEmail.Text == "" || txtDirec.Text == "")
                {
                    MessageBox.Show("Favor de llenar todos los campos");
                }
                else
                {                    
                    Metodos.AfilUpdate(lblIDAR.Text,txtNom.Text.ToUpper(), txtApeP.Text.ToUpper(), txtApeM.Text.ToUpper(), txtEdad.Text.ToUpper(), txtTel.Text.ToUpper(), txtEmail.Text, cbbTAfil.SelectedValue.ToString(), txtDirec.Text.ToUpper());
                    
                    MessageBox.Show("Afiliado modificado exitosamente");
                    
                    
                }
            }
        }
    }
}
