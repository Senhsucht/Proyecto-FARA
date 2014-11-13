using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_FARA
{
    public partial class Autenticacion : Form
    {
        

        public Autenticacion()
        {
            InitializeComponent();
        }


        private void Conexion_Click(object sender, EventArgs e)
        {
            //Establecer y confirmar conexión
            System.Threading.Thread.Sleep(1000);
            gpbLogin.Enabled = true;
            lblConexion.Text = "Conexion establecida correctamente";
            lblConexion.ForeColor = System.Drawing.Color.Lime;
        }

        private bool LoginSesion(string usr, string pwd)
        {
            bool login = false;
            User UsuarioOp = new User();
            UsuarioOp.user = usr;
            UsuarioOp.contraseña = pwd;
            if (UsuarioOp.Buscar() == true)
            {
                MessageBox.Show(UsuarioOp.Mensaje, "Login");
                login = true;
            }
            else
            {
                MessageBox.Show(UsuarioOp.Mensaje, "Cerrar");
            }

            return login;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Autenticacion au = new Autenticacion();
            //Inicio de sesion
            if (LoginSesion(txtUser.Text.ToUpper(), txtPwd.Text) == true)
            {
                // carga de Form1 = home              
                Program.Home();
            }

        }

        private void spbLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }

        }


    }
}
