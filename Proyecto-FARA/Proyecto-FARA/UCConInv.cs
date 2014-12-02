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
    public partial class UCConInv : UserControl,iModulo
    {

        Metodos Mt = new Metodos();
        DataSet datos = new DataSet();
        SqlDataAdapter ad = new SqlDataAdapter();
        int[] ids = null;

        public UCConInv()
        {
            InitializeComponent();
        }


        private void busquedaProd(object sender, EventArgs e)
        {
            dgvProd.Rows.Clear();

            string busqueda = "SELECT I.ID,P.NOMBRE,P.MARCA,I.CANTIDAD,P.CNETO,I.DESCR,I.ULT_ACT FROM [INVENTARIO] I INNER JOIN [PRODUCTO] P ON I.ID_PRODUCTO=P.ID";
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
                    busqueda = busqueda + " P.NOMBRE = '" + NPROD + "'";
                }
                if (NPROD != "" && MPROD != "")
                {
                    busqueda = busqueda + " AND P.MARCA = '" + MPROD + "'";

                }
                else
                {
                    if (MPROD != "")
                    {
                        busqueda = busqueda + " P.MARCA = '" + MPROD + "'";
                    }
                }


                ad = Mt.BusquedaC(busqueda);

            }

            ids = Metodos.colecDatos(busqueda);
            int total = Metodos.ConsultaIds(busqueda);
            for (int i = 0; i < total; i++)
            {
                object[] renglon = new Object[dgvProd.ColumnCount];
                Metodos.consultarDatos(ids[i], "conInv");
                renglon[0] = Metodos.ID;
                renglon[1] = Metodos.Nom;
                renglon[2] = Metodos.MarPro;
                renglon[3] = Metodos.Cantidad;
                renglon[4] = Metodos.CNetPro;
                renglon[5] = Metodos.UA;


                dgvProd.Rows.Add(renglon);

            }




        }

    }
}
