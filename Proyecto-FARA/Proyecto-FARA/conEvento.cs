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
    public partial class conEvento : Form
    {
        Metodos Mt = new Metodos();
        DataSet datos = new DataSet();
        SqlDataAdapter ad = new SqlDataAdapter();
        int[] ids = null;

        public conEvento()
        {
            InitializeComponent();
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int idD = int.Parse(dgvEve.CurrentRow.Cells["clmID"].Value.ToString());
            Metodos.consultarDatos(idD, "evento");

            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
