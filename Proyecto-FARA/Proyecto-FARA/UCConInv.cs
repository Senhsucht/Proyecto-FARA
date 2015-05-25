using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO; 

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
                renglon[5] = Metodos.Descr;
                renglon[6] = Metodos.UA;


                dgvProd.Rows.Add(renglon);

            }

            double cant=0;

            for (int i = 0; i < dgvProd.RowCount; i++)
            {
                cant = cant + Convert.ToDouble(dgvProd.Rows[i].Cells["clmCant"].Value);
            }
            textBox1.Text = cant.ToString();

        }

        private void btnExpPDF_Click(object sender, EventArgs e)
        {
            createPDFcarga();

            MessageBox.Show("Archivo creado.");
        }

        private void createPDFcarga()
        {

            string fecha = DateTime.Now.ToString("M-d-yyyy H.mm.ss");
            string nombreDoc = "INVENTARIO " + fecha + ".pdf";
            string RESULT = (@"C:\Users\Angel\Documents\GitHub\Proyecto-FARA\Proyecto-FARA\Proyecto-FARA\PDF\AltaDonacion " + fecha + ".pdf");
            Document document = new Document();

            PdfWriter wri = PdfWriter.GetInstance(document,
                          new FileStream(RESULT, FileMode.Create));


            iTextSharp.text.Image logo =
                iTextSharp.text.Image.GetInstance(@"C:\Users\Angel\Documents\GitHub\Proyecto-FARA\Proyecto-FARA\Proyecto-FARA\Recursos\FARA-LOGO.jpg");

            logo.Alignment = iTextSharp.text.Image.LEFT_ALIGN;

            iTextSharp.text.Paragraph cabecero = new Paragraph("INVENTARIO ACTUAL " + fecha);

            PdfPTable tabla = new PdfPTable(dgvProd.Columns.Count);

            for (int i = 0; i < dgvProd.Columns.Count; i++)
            {
                tabla.AddCell(dgvProd.Columns[i].HeaderText);
            }

            for (int i = 0; i < dgvProd.Rows.Count; i++)
            {
                for (int j = 0; j < dgvProd.Columns.Count; j++)
                {
                    if (dgvProd[j, i].Value != null)
                    {
                        tabla.AddCell(new Phrase(dgvProd[j, i].Value.ToString()));
                    }
                    else
                    {
                        tabla.AddCell(new Phrase(""));
                    }
                }
            }



            document.Open();
            document.Add(logo);
            document.Add(cabecero);

            document.Add(tabla);


            document.Close();
        }


    }
}
