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
    public partial class conProducto : Form
    {
        Metodos Mt = new Metodos();
        DataSet datos = new DataSet();
        SqlDataAdapter ad = new SqlDataAdapter();
        int[] ids = null;


        public conProducto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int idD = int.Parse(dgvProd.CurrentRow.Cells["clmID"].Value.ToString());
            Metodos.consultarDatos(idD, "producto");

            Close();
        }


        private void busquedaProd(object sender, EventArgs e)
        {
            datos.Clear();

            string busqueda = "SELECT * FROM PRODUCTO";
            string NPROD = this.txtNomProd.Text;
            string MPROD = this.txtMarProd.Text;

            if (NPROD == "" && MPROD == "")
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
                object[] renglon = new Object[dgvProd.ColumnCount];
                Metodos.consultarDatos(ids[i], "producto");
                renglon[0] = Metodos.ID;
                renglon[1] = Metodos.Nom;
                renglon[2] = Metodos.MarPro;
                renglon[3] = Metodos.CNetPro;
                renglon[4] = Metodos.UA;


                dgvProd.Rows.Add(renglon);

            }




        }

    }
}
