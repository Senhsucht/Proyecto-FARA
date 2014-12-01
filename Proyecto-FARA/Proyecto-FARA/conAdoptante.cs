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
    public partial class conAdoptante : Form
    {
        Metodos Mt = new Metodos();
        DataTable datos = new DataTable();
        SqlDataAdapter ad = new SqlDataAdapter();
        int[] ids = null;


        public conAdoptante()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvAdop.Rows.Clear();

            string busqueda = "SELECT * FROM ADOPTANTE";
            string Nom = this.txtNom.Text;
            string AP = this.txtApeP.Text;
            string AM = this.txtApeM.Text;

            if (Nom == "" && AP == "" && AM == "")
            {
                ad = Mt.BusquedaC(busqueda);
            }
            else
            {
                busqueda = busqueda + " WHERE";

                if (Nom != "")
                {
                    busqueda = busqueda + " NOMBRE = '" + Nom + "'";
                }
                if (Nom != "" && AP != "")
                {
                    busqueda = busqueda + " AND APE_PAT = '" + AP + "'";

                }
                else
                {
                    if (AP != "")
                    {
                        busqueda = busqueda + " APE_PAT = '" + AP + "'";
                    }
                }
                if ((Nom != "" || AP != "") && AM != "")
                {
                    busqueda = busqueda + " AND APE_MAT = '" + AM + "'";

                }
                else
                {
                    if (AM != "")
                    {
                        busqueda = busqueda + " APE_MAT = '" + AM + "'";
                    }
                }
                        

                ad = Mt.BusquedaC(busqueda);

            }

            ids = Metodos.colecDatos(busqueda);
            int total = Metodos.ConsultaIds(busqueda);
            for (int i = 0; i < total; i++)
            {
                object[] renglon = new Object[8];
                Metodos.consultarDatos(ids[i], "donante");
                renglon[0] = Metodos.ID;
                renglon[1] = Metodos.Nom;
                renglon[2] = Metodos.ApeP;
                renglon[3] = Metodos.ApeM;
                renglon[4] = Metodos.Edad;
                renglon[5] = Metodos.Tel;
                renglon[6] = Metodos.Email;
                renglon[7] = Metodos.Dir;
                renglon[8] = Metodos.UA;

                dgvAdop.Rows.Add(renglon);

            }

            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int idD = int.Parse(dgvAdop.CurrentRow.Cells["clmID"].Value.ToString());
            Metodos.consultarDatos(idD, "adoptante");

            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
