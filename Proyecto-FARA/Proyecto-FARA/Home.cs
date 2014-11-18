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
        VScrollBar SB = new VScrollBar();

        public Home()
        {
            InitializeComponent();
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.VerticalScroll.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            //Metodos mt = new Metodos();
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;


            //Mostrar datos del usuario
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
            string nomMod = ((Button)sender).Text;

            switch (nomMod)
            {
                case "DONACIONES":
                    Muestra m = new Muestra();

                    m.ShowDialog();
                    gpbComm.Text = "Donaciones";
                    cambiarMod(new UCDonaciones());
                    break;

            }
        }

        private void splitContainer2_Panel2_Scroll(object sender, ScrollEventArgs e)
        {
            this.splitContainer1.Panel1.VerticalScroll.Value = e.NewValue;
        }

        private void splitContainer2_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                splitContainer2.Panel2.VerticalScroll.Value = e.NewValue;
            }
        }



    }
}
