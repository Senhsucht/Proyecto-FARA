using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_FARA
{
    public partial class UCConAfi : UserControl, iModulo
    {
        Metodos Mt = new Metodos();
        DataTable datos = new DataTable();
        SqlDataAdapter ad = new SqlDataAdapter();
        int[] ids = null;

        public UCConAfi()
        {
            InitializeComponent();
        }

        private void UCConAfi_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvAfil.Rows.Clear();

            string busqueda = "SELECT * FROM AFIL";
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
                object[] renglon = new Object[10];
                Metodos.consultarDatos(ids[i], "afiliado");
                renglon[0] = Metodos.ID;
                renglon[1] = Metodos.Nom;
                renglon[2] = Metodos.ApeP;
                renglon[3] = Metodos.ApeM;
                renglon[4] = Metodos.Edad;
                renglon[5] = Metodos.Tel;
                renglon[6] = Metodos.Email;
                renglon[7] = Metodos.Dir;
                renglon[8] = Metodos.tAfil;
                renglon[9] = Metodos.UA;

                dgvAfil.Rows.Add(renglon);
            }


        }
    }

}
