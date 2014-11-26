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
        private iModulo actualMod { get; set; }

        public Home()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            //Metodos mt = new Metodos();
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;


            //Mostrar datos del usuario
            lblUsr.Text = "USUARIO: "+ Metodos.UsuarioON.usr;
            lblNombre.Text = "NOMBRE: " + Metodos.UsuarioON.nombre + " " + Metodos.UsuarioON.ape_pat + " " + Metodos.UsuarioON.ape_mat;
            lblEdad.Text = "EDAD: "+Metodos.UsuarioON.edad;
            lblEmail.Text = "EMAIL: "+Metodos.UsuarioON.email;
            lblTafil.Text = "TIPO DE AFILIADO: "+Metodos.UsuarioON.tafil;
            lblTelefono.Text = "TELEFONO: "+ Metodos.UsuarioON.tel;
            lblTusr.Text = "TIPO DE USUARIO: "+Metodos.UsuarioON.tusr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cerrar ventana
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //MinimizeBox = false;
        }


        private void cambiarMod(UserControl nMod)
        {
            if (actualMod != null)
            {
                ((IDisposable)actualMod).Dispose();
            }

            actualMod = (iModulo)nMod;
            nMod.Dock = DockStyle.Fill;
            nMod.Parent = splitContainer2.Panel2;

        }

        private void seleccionarControl(object sender, EventArgs e)
        {
            string nomCom = ((Button)sender).Text;


            switch (nomCom)
            {
                case "Alta de donaciones":
                    
                    cambiarMod(new UCAltaDon());
                    break;

            }
        }

        private void camCom(object sender, EventArgs e)
            {
                string nomMod = ((Button)sender).Text;
                btnAlta.Visible = true;
                btnMod.Visible = true;
                btnCon.Visible = true;

                switch (nomMod)
                {
                    case "USUARIOS":
                        
                        gpbComm.Text = "Usuarios";
                        btnAlta.Text = "Alta de usuario";
                        btnMod.Text = "Modificación de usuario";
                        btnCon.Text = "Consulta de usuario";

                        break;

                    case "AFILIADOS":
                        
                        gpbComm.Text = "Afiliados";
                        btnAlta.Text = "Alta de afiliado";
                        btnMod.Text = "Modificación de afiliado";
                        btnCon.Text = "Consulta de afiliado";
                        break;
                    case "RESCATE":
                       
                        gpbComm.Text = "Rescate";
                        btnAlta.Text = "Alta de rescate";
                        btnMod.Text = "Modificación de rescate";
                        btnCon.Text = "Consulta de rescate";
                        break;
                    case "INVENTARIO":
                        
                        gpbComm.Text = "Inventario";
                        btnAlta.Text = "Alta de inventario";
                        btnMod.Text = "Baja de inventario";
                        btnCon.Text = "Consulta de inventario";
                        break;
                    case "DONACIONES":

                        gpbComm.Text = "Donaciones";
                        btnAlta.Text = "Alta de donaciones";
                        btnMod.Text = "Modificación de donaciones";
                        btnCon.Text = "Consulta de donaciones";
                        break;
                    case "ADOPCIONES":

                        gpbComm.Text = "Adopciones";
                        btnAlta.Text = "Alta de adopciones";
                        btnMod.Text = "Modificación de adopciones";
                        btnCon.Text = "Consulta de adopciones";
                        break;
                    case "EVENTOS":

                        gpbComm.Text = "Eventos";
                        btnAlta.Text = "Alta de eventos";
                        btnMod.Text = "Modificación de eventos";
                        btnCon.Text = "Consulta de eventos";
                        break;

                }
            }

    }
}
