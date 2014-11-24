using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_FARA.Formas
{
    public partial class conDonante : Form
    {
        Metodos Mt = new Metodos();
        DataSet datos = new DataSet();
        SqlDataAdapter ad = new SqlDataAdapter();
        int[] ids = null;

        public conDonante()
        {
            InitializeComponent();
        }

                private void busquedaDon(object sender, EventArgs e)
        {
                datos.Clear();
            
            string busqueda = "SELECT * FROM DONANTE";
            string NDon = this.txtNomDon.Text;
            string APDon = this.txtApePDon.Text;
            string AMDon = this.txtApeMDon.Text;
            string RFCDon = this.txtRFCDon.Text;

            if (NDon == "" && APDon == "" && AMDon == "" && RFCDon == "")
            {
                ad = Mt.BusquedaC(busqueda);
            }
            else
            {
                busqueda = busqueda + " WHERE";

                if (NDon != "")
                {
                    busqueda = busqueda + " NOMBRE = '" + NDon + "'";
                }
                if (NDon != "" && APDon != "")
                {
                    busqueda = busqueda + " AND APE_PAT = '" + APDon + "'";

                }
                else
                {
                    if (APDon != "")
                    {
                        busqueda = busqueda + " APE_PAT = '" + APDon + "'";
                    }
                }
                if ((NDon != "" || APDon != "") && AMDon != "")
                {
                    busqueda = busqueda + " AND APE_MAT = '" + AMDon + "'";

                }
                else
                {
                    if (AMDon != "")
                    {
                        busqueda = busqueda + " APE_MAT = '" + AMDon + "'";
                    }
                }

                if ((NDon != "" || APDon != "" || AMDon != "") && RFCDon != "")
                {
                    busqueda = busqueda + " AND RFC = '" + RFCDon + "'";
                }
                else
                {
                    busqueda = busqueda + " RFC = '" + RFCDon + "'";
                }

                ad = Mt.BusquedaC(busqueda);

            }

            ids = Metodos.colecDatos(busqueda);
            int total = Metodos.ConsultaIds(busqueda);
            for (int i = 0; i < total; i++)
            {
                object[] renglon = new Object[8];
                Metodos.consultarDatos(ids[i],"donante");
                renglon[0] = Metodos.ID;
                renglon[1] = Metodos.Nom;
                renglon[2] = Metodos.ApeP;
                renglon[3] = Metodos.ApeM;
                renglon[4] = Metodos.RFCD;
                renglon[5] = Metodos.TelD;
                renglon[6] = Metodos.DirD;
                renglon[7] = Metodos.UA;

                dgvDon.Rows.Add(renglon);

            }


            
            
        }
    }
}
