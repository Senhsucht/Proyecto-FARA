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
    public partial class Home: Form
    {
        public Home()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            //Metodos mt = new Metodos();
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;

            lblUsr.Text = "USUARIO: "+ Metodos.UsuarioON.usr;
            lblNombre.Text = "NOMBRE: " + Metodos.UsuarioON.nombre + " " + Metodos.UsuarioON.ape_pat + " " + Metodos.UsuarioON.ape_mat;
            lblEdad.Text = "EDAD: "+Metodos.UsuarioON.edad;
            lblEmail.Text = "EDAD: "+Metodos.UsuarioON.email;
            lblTafil.Text = "TIPO DE AFILIADO: "+Metodos.UsuarioON.tafil;
            lblTelefono.Text = "TELEFONO: "+ Metodos.UsuarioON.tel;
            lblTusr.Text = "TIPO DE USUARIO: "+Metodos.UsuarioON.tusr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //MinimizeBox = false;
        }

        private void btnModDon_Click(object sender, EventArgs e)
        {

        }


    }
}
