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
    public partial class Atenticacion : Form
    {
        public Atenticacion()
        {
            InitializeComponent();
        }

        private void Atenticacion_Load(object sender, EventArgs e)
        {

        }


        private void Conexion_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            gpbLogin.Enabled = true;
            lblConexion.Text = "Conexion establecida correctamente";
            lblConexion.ForeColor = System.Drawing.Color.Lime;
        }

        private void LoginSesion(string usr, string pwd)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            LoginSesion(txtUser.Text, txtPwd.Text);

        }


    }
}
