using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Proyecto_FARA;

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
            try
            {
                SqlConnection cnn = conexion.conect();
                cnn.Open();

                gpbLogin.Enabled = true;
                lblConexion.Text = "Conexion establecida correctamente";
                lblConexion.ForeColor = System.Drawing.Color.Lime;

                cnn.Close();
            }
            catch
            {
                lblConexion.Text = "Ha ocurrido un error conectandose a la base de datos";
                lblConexion.ForeColor = System.Drawing.Color.DarkRed;
            }
            
        }

        private bool LoginSesion(string usr, string pwd)
        {
            bool login = false;

            Metodos UsuarioOp = new Metodos();

            //Comprobar que el usuario existe y se encuentra activo
            if (UsuarioOp.Buscar(usr, pwd) == true)
            {
                MessageBox.Show(UsuarioOp.Mensaje, "Iniciando sesión");
                login = true;
            }
            else
            {
                MessageBox.Show(UsuarioOp.Mensaje, "Error");
            }

            return login;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Autenticacion au = new Autenticacion();
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
            //Activar la comprobacion al dar ENTER sobre el txtPwd
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }


        }
    }

}
