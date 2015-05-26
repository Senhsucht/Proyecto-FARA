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
    public partial class ConfirmacionAdmin : Form
    {
    
        public ConfirmacionAdmin()
        {
            InitializeComponent();
        }

        private void ConfirmacionAdmin_Load(object sender, EventArgs e)
        {
            lblConf.Text = "Favor de confirmar la modificación \ncon su contraseña " + Metodos.UsuarioON.usr;

        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            string pwd = txtConf.Text;
            if(pwd == Metodos.UsuarioON.pwd)
            {
                Metodos.ConfirmaBien();

                Close();
            }
            else 
            {
                Metodos.ConfirmaMal();
                MessageBox.Show("Confirmación incorrecta");
            }

        }
    }
}
