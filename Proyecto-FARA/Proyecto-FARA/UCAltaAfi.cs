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
    public partial class UCAltaAfi : UserControl,iModulo
    {
        public UCAltaAfi()
        {
            InitializeComponent();
        }

        private void UCAltaAfi_Load(object sender, EventArgs e)
        {
            cbbTAfil.DataSource = Metodos.LlenarCombo("TAFIL");
            cbbTAfil.DisplayMember = "Nombre";
            cbbTAfil.ValueMember = "ID";
        }

        private void btnAfil_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == "" || txtApeP.Text == "" || txtApeM.Text == "" || txtEdad.Text == "" || txtTel.Text == "" || txtEmail.Text == "" || txtDirec.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                if (Metodos.ConfirmaAfil(txtNom.Text, txtApeP.Text, txtApeM.Text) == 0)
                {
                    Metodos.AltaAfil(txtNom.Text.ToUpper(), txtApeP.Text.ToUpper(), txtApeM.Text.ToUpper(), txtEdad.Text.ToUpper(), txtTel.Text.ToUpper(), txtEmail.Text, cbbTAfil.SelectedValue.ToString() , txtDirec.Text.ToUpper());
                    MessageBox.Show("Afiliado dado de alta exitosamente");
                }
                else
                {
                    MessageBox.Show("Error: Afiliado existente");
                }
            }
        }
    }
}
