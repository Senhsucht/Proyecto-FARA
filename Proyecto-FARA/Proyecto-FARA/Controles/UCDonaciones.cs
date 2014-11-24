using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Proyecto_FARA;
using System.Data.SqlClient;

namespace Proyecto_FARA
{
    public partial class UCDonaciones : UserControl,iModulo
    {
        
        Metodos Mt = new Metodos();
        DataSet datos = new DataSet();
        SqlDataAdapter ad = new SqlDataAdapter();
        int[] ids = null;

        public UCDonaciones()
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

        private void busquedaProd(object sender, EventArgs e)
        {
            datos.Clear();

            string busqueda = "SELECT * FROM PRODUCTO";
            string NPROD = this.txtNomProd.Text;
            string MPROD = this.txtMarProd.Text;

            if (NPROD == "" && MPROD == "" )
            {
                ad = Mt.BusquedaC(busqueda);
            }
            else
            {
                busqueda = busqueda + " WHERE";

                if (NPROD != "")
                {
                    busqueda = busqueda + " NOMBRE = '" + NPROD + "'";
                }
                if (NPROD != "" && MPROD != "")
                {
                    busqueda = busqueda + " AND MARCA = '" + MPROD + "'";

                }
                else
                {
                    if (MPROD != "")
                    {
                        busqueda = busqueda + " MARCA = '" + MPROD + "'";
                    }
                }
               

                ad = Mt.BusquedaC(busqueda);

            }

            ids = Metodos.colecDatos(busqueda);
            int total = Metodos.ConsultaIds(busqueda);
            for (int i = 0; i < total; i++)
            {
                object[] renglon = new Object[5];
                Metodos.consultarDatos(ids[i], "producto");
                renglon[0] = Metodos.ID;
                renglon[1] = Metodos.Nom;
                renglon[2] = Metodos.MarPro;
                renglon[3] = Metodos.CNetPro;
                renglon[4] = Metodos.UA;


                dgvProd.Rows.Add(renglon);

            }




        }

        private void busquedaEVE(object sender, EventArgs e)
        {
            datos.Clear();

            string busqueda = "SELECT * FROM EVENTO";
            string NEVE = this.txtNomEve.Text;
            string TEVE = this.txtTEVE.Text;


            if (NEVE == "" && TEVE == "")
            {
                ad = Mt.BusquedaC(busqueda);
            }
            else
            {
                busqueda = busqueda + " WHERE";

                if (NEVE != "")
                {
                    busqueda = busqueda + " NOMBRE = '" + NEVE + "'";
                }
                if (NEVE != "" && TEVE != "")
                {
                    busqueda = busqueda + " AND ID_TEVENTO = '" + TEVE + "'";

                }
                else
                {
                    if (TEVE != "")
                    {
                        busqueda = busqueda + " ID_TEVENTO = '" + TEVE + "'";
                    }
                }
               
                ad = Mt.BusquedaC(busqueda);

            }

            ids = Metodos.colecDatos(busqueda);
            int total = Metodos.ConsultaIds(busqueda);
            for (int i = 0; i < total; i++)
            {
                object[] renglon = new Object[8];
                Metodos.consultarDatos(ids[i], "evento");
                renglon[0] = Metodos.ID;
                renglon[1] = Metodos.Nom;
                renglon[2] = Metodos.Descr;
                renglon[3] = Metodos.LugEve;
                renglon[4] = Metodos.FecEve;
                renglon[5] = Metodos.IDtEve;
                renglon[6] = Metodos.EveEdo;
                renglon[7] = Metodos.UA;

                dgvEve.Rows.Add(renglon);

            }




        }

        private void btnAgre_Click(object sender, EventArgs e)
        {
            string idD = dgvDon.CurrentRow.Cells["clmID"].Value.ToString();
            string donante = dgvDon.CurrentRow.Cells["clmNombre"].Value.ToString() + " " + dgvDon.CurrentRow.Cells["clmAPPAT"].Value.ToString() + " " + dgvDon.CurrentRow.Cells["clmAPMAT"].Value.ToString();
            string idP = dgvProd.CurrentRow.Cells["clmIDP"].Value.ToString();
            string Prod = dgvProd.CurrentRow.Cells["clmNomP"].Value.ToString();
            string idE = dgvEve.CurrentRow.Cells["clmIDE"].Value.ToString();
            string eve = dgvEve.CurrentRow.Cells["clmNOMEVE"].Value.ToString();

            object[] renglon = new Object[7];

            renglon[0] = idD;
            renglon[1] = donante;
            renglon[2] = "";
            renglon[3] = idP;
            renglon[4] = Prod;
            renglon[5] = idE;
            renglon[6] = eve;
            
            dgvRes.Rows.Add(renglon);
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            int c = dgvRes.Rows.Count - 1;

            for (int i = 0; i < c; i++)
            {
                Metodos.AltaInv(dgvRes.Rows[i].Cells["clmIDD"].Value.ToString(), dgvRes.Rows[i].Cells["cmnCantidad"].Value.ToString(), dgvRes.Rows[i].Cells["clmIDPR"].Value.ToString(), dgvRes.Rows[i].Cells["clmIDEV"].Value.ToString());
            }
        }
    }
}
