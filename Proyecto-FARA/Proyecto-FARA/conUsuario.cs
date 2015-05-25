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
    public partial class conUsuario : Form
    {
        Metodos Mt = new Metodos();
        DataTable datos = new DataTable();
        SqlDataAdapter ad = new SqlDataAdapter();
        int[] ids = null;

        public conUsuario()
        {
            InitializeComponent();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvUsr.Rows.Clear();

            string busqueda = "SELECT u.id,U.USR,U.PWD,tu.TUSR as TUSR,u.ACTIVO,ta.descr as TAFIL,A.NOMBRE,a.APE_PAT,a.APE_MAT,a.EDAD,a.DIRECCION,a.TEL,a.EMAIL,u.ULT_ACT FROM USR U INNER JOIN AFIL A ON U.ID_AFIL=A.ID inner join TUSR tu on u.ID_TUSR=tu.id inner join tafil ta on a.id_tafil=ta.id";
            string usr = this.textBox1.Text;
            string Nom = this.txtNom.Text;
            string AP = this.txtApeP.Text;
            string AM = this.txtApeM.Text;

            if (usr == "" && Nom == "" && AP == "" && AM == "")
            {
                ad = Mt.BusquedaC(busqueda);
            }
            else
            {
                busqueda = busqueda + " WHERE";

                if (usr != "")
                {
                    busqueda = busqueda + " U.USR = '" + usr + "'";
                }
                if (usr != "" && Nom != "")
                {
                    busqueda = busqueda + " AND A.NOMBRE = '" + Nom + "'";

                }
                else
                {
                    if (Nom != "")
                    {
                        busqueda = busqueda + " A.NOMBRE = '" + Nom + "'";
                    }
                }
                if ((usr != "" || Nom != "") && AP != "")
                {
                    busqueda = busqueda + " AND A.APE_PAT = '" + AP + "'";

                }
                else
                {
                    if (AP != "")
                    {
                        busqueda = busqueda + " A.APE_PAT = '" + AP + "'";
                    }
                }

                if ((usr != "" || Nom != "" || AP != "") && AM != "")
                {
                    busqueda = busqueda + " AND A.APE_MAT = '" + AM + "'";
                }
                else
                {
                    if (AM != "")
                    {
                        busqueda = busqueda + " A.APE_MAT = '" + AM + "'";
                    }
                }

                ad = Mt.BusquedaC(busqueda);


            }

            ids = Metodos.colecDatos(busqueda);
            int total = Metodos.ConsultaIds(busqueda);
            for (int i = 0; i < total; i++)
            {
                object[] renglon = new Object[11];
                Metodos.consultarDatos(ids[i], "usuario");
                renglon[0] = Metodos.ID;
                renglon[1] = Metodos.Usr;
                renglon[2] = Metodos.Nom;
                renglon[3] = Metodos.ApeP;
                renglon[4] = Metodos.ApeM;
                renglon[5] = Metodos.Edad;
                renglon[6] = Metodos.Tel;
                renglon[7] = Metodos.Email;
                renglon[8] = Metodos.Dir;
                renglon[9] = Metodos.tAfil;
                renglon[10] = Metodos.UA;

                dgvUsr.Rows.Add(renglon);

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int idD = int.Parse(dgvUsr.CurrentRow.Cells["clmID"].Value.ToString());
                Metodos.consultarDatos(idD, "usuario");

                Close();
            }
            catch { };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        }
    }

