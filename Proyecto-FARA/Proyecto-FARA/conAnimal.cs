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
    public partial class conAnimal : Form
    {
        Metodos Mt = new Metodos();
        DataTable datos = new DataTable();
        SqlDataAdapter ad = new SqlDataAdapter();
        int[] ids = null;

        public conAnimal()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvAni.Rows.Clear();

            string busqueda = "SELECT * FROM ANIMAL";
            string Nom = this.txtNom.Text;
            string TAni = this.cbxTAni.Text;
            string RAni = this.cbxRAni.Text;
            string Edad = this.txtEdad.Text;

            if (Nom == "" && TAni == "" && RAni == "" && Edad == "")
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
                if (Nom != "" && RAni != "")
                {
                    busqueda = busqueda + " AND ID_RAZA = (SELECT ID FROM RAZA WHERE RAZA = '" + RAni + "'";

                }
                else
                {
                    if (RAni != "")
                    {
                        busqueda = busqueda + " ID_RAZA = (SELECT ID FROM RAZA WHERE RAZA = '" + RAni + "'";
                    }
                }
                if ((Nom != "" || RAni != "") && TAni != "")
                {
                    busqueda = busqueda + " AND ID_RAZA = (SELECT ID FROM RAZA WHERE ID_TANIMAL = (SELECT ID FROM TANIMAL WHERE TANIMAL = '" + TAni + "'";

                }
                else
                {
                    if (TAni != "")
                    {
                        busqueda = busqueda + " ID_RAZA = (SELECT ID FROM RAZA WHERE ID_TANIMAL = (SELECT ID FROM TANIMAL WHERE TANIMAL = '" + TAni + "'";
                    }
                }


                ad = Mt.BusquedaC(busqueda);

            }

            ids = Metodos.colecDatos(busqueda);
            int total = Metodos.ConsultaIds(busqueda);
            for (int i = 0; i < total; i++)
            {
                object[] renglon = new Object[dgvAni.ColumnCount];
                Metodos.consultarDatos(ids[i], "animal");
                renglon[0] = Metodos.ID;
                renglon[1] = Metodos.Nom;
                renglon[3] = Metodos.rAni;
                renglon[4] = Metodos.Edad;
                renglon[5] = Metodos.UA;

                dgvAni.Rows.Add(renglon);

            }

        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int idD = int.Parse(dgvAni.CurrentRow.Cells["clmID"].Value.ToString());
            Metodos.consultarDatos(idD, "animal");

            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
