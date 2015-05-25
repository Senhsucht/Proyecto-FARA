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
    public partial class UCAltaUsr : UserControl, iModulo
    {
        int usrd = 0;

        public UCAltaUsr()
        {
            InitializeComponent();
        }

        private void gpbAfil_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarA_Click(object sender, EventArgs e)
        {

            conAfiliado cd = new conAfiliado();
            cd.ShowDialog();

            lblIDAR.Text = Metodos.ID;
            lblNombreAR.Text = Metodos.Nom + " " + Metodos.ApeP + " " + Metodos.ApeM;
            lblEdadAR.Text =  Metodos.Edad;
            lblTelAR.Text =  Metodos.Tel;
            lblDirecAR.Text =  Metodos.Dir;
            lblEmailAR.Text = Metodos.Email;
            lblTAfilR.Text = Metodos.tAfil;

            
        
        }

        private void UCAltaUsr_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usrd == 1)
            {
                if (txtPwd.Text == textBox1.Text)
                {
                    if (txtUsr.Text == "" && txtPwd.Text == "" && lblIDAR.Text == "ID")
                    {
                        MessageBox.Show("Datos incompletos");
                    }
                    else
                    {
                        Metodos.AltaUsr(txtUsr.Text, txtPwd.Text, lblIDAR.Text, comboBox1.SelectedItem.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña no coincide");
                }
            }
            else
            {
                MessageBox.Show("Favor de confirmar el usuario");
            }
        }

        private void btnConfirmarUsr_Click(object sender, EventArgs e)
        {
            if(Metodos.ConfirmaUSR(txtUsr.Text)==0)
            {
                MessageBox.Show("Usuario disponible");
                usrd = 1;
            }
            else
            {
                MessageBox.Show("Usuario no disponible");
            }
        }
    }
}
