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
    public partial class UCAltaDon : UserControl,iModulo
    {        
        public UCAltaDon()
        {
            InitializeComponent();
        }

        private void btnBuscarD_Click(object sender, EventArgs e)
        {
            conDonante cd = new conDonante();
            cd.ShowDialog();

            lblIDDR.Text = Metodos.ID;
            lblNombreDR.Text = Metodos.Nom + " " + Metodos.ApeP + " " + Metodos.ApeM;
            lblRFCDR.Text =  Metodos.RFCD;
            lblTelDR.Text =  Metodos.Tel;
            lblDirecDR.Text =  Metodos.Dir;
            
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            conProducto cp = new conProducto();
            cp.ShowDialog();

            lblIDPR.Text = Metodos.ID;
            lblNombrePR.Text =  Metodos.Nom;
            lblMarcaPR.Text = Metodos.MarPro;
            lblCNetoPR.Text = Metodos.CNetPro;
        }

        private void btnBuscarE_Click(object sender, EventArgs e)
        {
            conEvento ce = new conEvento();
            ce.ShowDialog();

            lblIDER.Text = Metodos.ID;
            lblNombreER.Text = Metodos.Nom;
            lblDescER.Text = Metodos.Descr;
            lblLugER.Text = Metodos.LugEve;
            lblFecER.Text = Metodos.FecEve;
            lblTipoER.Text = Metodos.IDtEve;
            lblEdoER.Text = Metodos.EveEdo;
        }


        private void btnAgre_Click(object sender, EventArgs e)
        {
            string idD = lblIDDR.Text;
            string donante = lblNombreDR.Text;
            string idP = lblIDPR.Text;
            string Prod = lblNombrePR.Text;
            string idE = lblIDER.Text;
            string eve = lblNombreER.Text;

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
            dgvRes.Rows.RemoveAt(dgvRes.SelectedRows[0].Index);
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            int c = dgvRes.Rows.Count;
                        
            for (int i = 0; i < c; i++)
            {
                if (dgvRes.Rows[i].Cells["clmIDEV"].Value.ToString() != "ID")
                {
                    Metodos.AltaInv(dgvRes.Rows[i].Cells["clmIDD"].Value.ToString(), dgvRes.Rows[i].Cells["cmnCantidad"].Value.ToString(), dgvRes.Rows[i].Cells["clmIDPR"].Value.ToString(), dgvRes.Rows[i].Cells["clmIDEV"].Value.ToString());
                }
                else
                {
                    Metodos.AltaInv(dgvRes.Rows[i].Cells["clmIDD"].Value.ToString(), dgvRes.Rows[i].Cells["cmnCantidad"].Value.ToString(), dgvRes.Rows[i].Cells["clmIDPR"].Value.ToString(), "NULL");

                }
            }
            
            createPDFcarga();

            MessageBox.Show("Datos cargados exitosamente");

        }

        private void btnExpPDF_Click(object sender, EventArgs e)
        {
            createPDFcarga();

            MessageBox.Show("Archivo creado.");
        }

        private void createPDFcarga()
        {

            string fecha = DateTime.Now.ToString("M-d-yyyy H.mm.ss");
            string nombreDoc = "AltaDonacion " + fecha + ".pdf";
            string RESULT = (@"C:\Users\Angel\Documents\GitHub\Proyecto-FARA\Proyecto-FARA\Proyecto-FARA\PDF\AltaDonacion "+fecha+".pdf");
            Document document = new Document();

            PdfWriter wri = PdfWriter.GetInstance(document,
                          new FileStream(RESULT,FileMode.Create));


            iTextSharp.text.Image logo =
                iTextSharp.text.Image.GetInstance(@"C:\Users\Angel\Documents\GitHub\Proyecto-FARA\Proyecto-FARA\Proyecto-FARA\Recursos\FARA-LOGO.jpg");

            logo.Alignment = iTextSharp.text.Image.LEFT_ALIGN;

            iTextSharp.text.Paragraph cabecero = new Paragraph("CARGA DE DONACIONES "+fecha);

            PdfPTable tabla = new PdfPTable(dgvRes.Columns.Count);

            for (int i = 0; i < dgvRes.Columns.Count; i++)
            {
                tabla.AddCell(dgvRes.Columns[i].HeaderText);
            }

            for (int i = 0; i < dgvRes.Rows.Count; i++)
            {
                for (int j = 0; j < dgvRes.Columns.Count; j++)
                {
                    if (dgvRes[j, i].Value != null)
                    {
                        tabla.AddCell(new Phrase(dgvRes[j, i].Value.ToString()));
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
