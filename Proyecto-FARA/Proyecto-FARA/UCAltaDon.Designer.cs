namespace Proyecto_FARA
{
    partial class UCAltaDon
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbDonante = new System.Windows.Forms.GroupBox();
            this.lblIDDR = new System.Windows.Forms.Label();
            this.lblDirecDR = new System.Windows.Forms.Label();
            this.lblTelDR = new System.Windows.Forms.Label();
            this.lblRFCDR = new System.Windows.Forms.Label();
            this.lblNombreDR = new System.Windows.Forms.Label();
            this.btnBuscarD = new System.Windows.Forms.Button();
            this.gpbProd = new System.Windows.Forms.GroupBox();
            this.lblIDPR = new System.Windows.Forms.Label();
            this.lblCNetoPR = new System.Windows.Forms.Label();
            this.lblMarcaPR = new System.Windows.Forms.Label();
            this.lblNombrePR = new System.Windows.Forms.Label();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.gpbEve = new System.Windows.Forms.GroupBox();
            this.lblIDER = new System.Windows.Forms.Label();
            this.lblEdoER = new System.Windows.Forms.Label();
            this.lblFecER = new System.Windows.Forms.Label();
            this.lblLugER = new System.Windows.Forms.Label();
            this.lblDescER = new System.Windows.Forms.Label();
            this.lblTipoER = new System.Windows.Forms.Label();
            this.lblNombreER = new System.Windows.Forms.Label();
            this.btnBuscarE = new System.Windows.Forms.Button();
            this.gpbResumen = new System.Windows.Forms.GroupBox();
            this.btnExpPDF = new System.Windows.Forms.Button();
            this.btnCarga = new System.Windows.Forms.Button();
            this.btnElim = new System.Windows.Forms.Button();
            this.btnAgre = new System.Windows.Forms.Button();
            this.dgvRes = new System.Windows.Forms.DataGridView();
            this.clmIDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnDonante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIDPR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIDEV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnEve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbDonante.SuspendLayout();
            this.gpbProd.SuspendLayout();
            this.gpbEve.SuspendLayout();
            this.gpbResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDonante
            // 
            this.gpbDonante.Controls.Add(this.lblIDDR);
            this.gpbDonante.Controls.Add(this.lblDirecDR);
            this.gpbDonante.Controls.Add(this.lblTelDR);
            this.gpbDonante.Controls.Add(this.lblRFCDR);
            this.gpbDonante.Controls.Add(this.lblNombreDR);
            this.gpbDonante.Controls.Add(this.btnBuscarD);
            this.gpbDonante.Location = new System.Drawing.Point(18, 13);
            this.gpbDonante.Name = "gpbDonante";
            this.gpbDonante.Size = new System.Drawing.Size(455, 130);
            this.gpbDonante.TabIndex = 1;
            this.gpbDonante.TabStop = false;
            this.gpbDonante.Text = "Donante";
            // 
            // lblIDDR
            // 
            this.lblIDDR.AutoSize = true;
            this.lblIDDR.Location = new System.Drawing.Point(361, 59);
            this.lblIDDR.Name = "lblIDDR";
            this.lblIDDR.Size = new System.Drawing.Size(18, 13);
            this.lblIDDR.TabIndex = 13;
            this.lblIDDR.Text = "ID";
            this.lblIDDR.Visible = false;
            // 
            // lblDirecDR
            // 
            this.lblDirecDR.AutoSize = true;
            this.lblDirecDR.Location = new System.Drawing.Point(20, 100);
            this.lblDirecDR.Name = "lblDirecDR";
            this.lblDirecDR.Size = new System.Drawing.Size(55, 13);
            this.lblDirecDR.TabIndex = 12;
            this.lblDirecDR.Text = "Dirección:";
            // 
            // lblTelDR
            // 
            this.lblTelDR.AutoSize = true;
            this.lblTelDR.Location = new System.Drawing.Point(20, 77);
            this.lblTelDR.Name = "lblTelDR";
            this.lblTelDR.Size = new System.Drawing.Size(52, 13);
            this.lblTelDR.TabIndex = 11;
            this.lblTelDR.Text = "Telefono:";
            // 
            // lblRFCDR
            // 
            this.lblRFCDR.AutoSize = true;
            this.lblRFCDR.Location = new System.Drawing.Point(20, 55);
            this.lblRFCDR.Name = "lblRFCDR";
            this.lblRFCDR.Size = new System.Drawing.Size(31, 13);
            this.lblRFCDR.TabIndex = 10;
            this.lblRFCDR.Text = "RFC:";
            // 
            // lblNombreDR
            // 
            this.lblNombreDR.AutoSize = true;
            this.lblNombreDR.Location = new System.Drawing.Point(20, 31);
            this.lblNombreDR.Name = "lblNombreDR";
            this.lblNombreDR.Size = new System.Drawing.Size(93, 13);
            this.lblNombreDR.TabIndex = 9;
            this.lblNombreDR.Text = "Nombre completo:";
            // 
            // btnBuscarD
            // 
            this.btnBuscarD.Location = new System.Drawing.Point(364, 19);
            this.btnBuscarD.Name = "btnBuscarD";
            this.btnBuscarD.Size = new System.Drawing.Size(83, 37);
            this.btnBuscarD.TabIndex = 8;
            this.btnBuscarD.Text = "Buscar donante";
            this.btnBuscarD.UseVisualStyleBackColor = true;
            this.btnBuscarD.Click += new System.EventHandler(this.btnBuscarD_Click);
            // 
            // gpbProd
            // 
            this.gpbProd.Controls.Add(this.lblIDPR);
            this.gpbProd.Controls.Add(this.lblCNetoPR);
            this.gpbProd.Controls.Add(this.lblMarcaPR);
            this.gpbProd.Controls.Add(this.lblNombrePR);
            this.gpbProd.Controls.Add(this.btnBuscarP);
            this.gpbProd.Location = new System.Drawing.Point(18, 149);
            this.gpbProd.Name = "gpbProd";
            this.gpbProd.Size = new System.Drawing.Size(455, 125);
            this.gpbProd.TabIndex = 2;
            this.gpbProd.TabStop = false;
            this.gpbProd.Text = "Producto";
            // 
            // lblIDPR
            // 
            this.lblIDPR.AutoSize = true;
            this.lblIDPR.Location = new System.Drawing.Point(361, 47);
            this.lblIDPR.Name = "lblIDPR";
            this.lblIDPR.Size = new System.Drawing.Size(18, 13);
            this.lblIDPR.TabIndex = 8;
            this.lblIDPR.Text = "ID";
            this.lblIDPR.Visible = false;
            // 
            // lblCNetoPR
            // 
            this.lblCNetoPR.AutoSize = true;
            this.lblCNetoPR.Location = new System.Drawing.Point(20, 78);
            this.lblCNetoPR.Name = "lblCNetoPR";
            this.lblCNetoPR.Size = new System.Drawing.Size(46, 13);
            this.lblCNetoPR.TabIndex = 7;
            this.lblCNetoPR.Text = "C. Neto:";
            // 
            // lblMarcaPR
            // 
            this.lblMarcaPR.AutoSize = true;
            this.lblMarcaPR.Location = new System.Drawing.Point(20, 55);
            this.lblMarcaPR.Name = "lblMarcaPR";
            this.lblMarcaPR.Size = new System.Drawing.Size(40, 13);
            this.lblMarcaPR.TabIndex = 6;
            this.lblMarcaPR.Text = "Marca:";
            // 
            // lblNombrePR
            // 
            this.lblNombrePR.AutoSize = true;
            this.lblNombrePR.Location = new System.Drawing.Point(20, 31);
            this.lblNombrePR.Name = "lblNombrePR";
            this.lblNombrePR.Size = new System.Drawing.Size(112, 13);
            this.lblNombrePR.TabIndex = 5;
            this.lblNombrePR.Text = "Nombre del producto: ";
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.Location = new System.Drawing.Point(364, 7);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(83, 37);
            this.btnBuscarP.TabIndex = 4;
            this.btnBuscarP.Text = "Buscar producto";
            this.btnBuscarP.UseVisualStyleBackColor = true;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // gpbEve
            // 
            this.gpbEve.Controls.Add(this.lblIDER);
            this.gpbEve.Controls.Add(this.lblEdoER);
            this.gpbEve.Controls.Add(this.lblFecER);
            this.gpbEve.Controls.Add(this.lblLugER);
            this.gpbEve.Controls.Add(this.lblDescER);
            this.gpbEve.Controls.Add(this.lblTipoER);
            this.gpbEve.Controls.Add(this.lblNombreER);
            this.gpbEve.Controls.Add(this.btnBuscarE);
            this.gpbEve.Location = new System.Drawing.Point(18, 280);
            this.gpbEve.Name = "gpbEve";
            this.gpbEve.Size = new System.Drawing.Size(455, 151);
            this.gpbEve.TabIndex = 3;
            this.gpbEve.TabStop = false;
            this.gpbEve.Text = "Evento";
            // 
            // lblIDER
            // 
            this.lblIDER.AutoSize = true;
            this.lblIDER.Location = new System.Drawing.Point(361, 57);
            this.lblIDER.Name = "lblIDER";
            this.lblIDER.Size = new System.Drawing.Size(18, 13);
            this.lblIDER.TabIndex = 7;
            this.lblIDER.Text = "ID";
            this.lblIDER.Visible = false;
            // 
            // lblEdoER
            // 
            this.lblEdoER.AutoSize = true;
            this.lblEdoER.Location = new System.Drawing.Point(253, 121);
            this.lblEdoER.Name = "lblEdoER";
            this.lblEdoER.Size = new System.Drawing.Size(96, 13);
            this.lblEdoER.TabIndex = 6;
            this.lblEdoER.Text = "Estado del evento:";
            // 
            // lblFecER
            // 
            this.lblFecER.AutoSize = true;
            this.lblFecER.Location = new System.Drawing.Point(20, 99);
            this.lblFecER.Name = "lblFecER";
            this.lblFecER.Size = new System.Drawing.Size(93, 13);
            this.lblFecER.TabIndex = 5;
            this.lblFecER.Text = "Fecha del evento:";
            // 
            // lblLugER
            // 
            this.lblLugER.AutoSize = true;
            this.lblLugER.Location = new System.Drawing.Point(20, 77);
            this.lblLugER.Name = "lblLugER";
            this.lblLugER.Size = new System.Drawing.Size(90, 13);
            this.lblLugER.TabIndex = 4;
            this.lblLugER.Text = "Lugar del evento:";
            // 
            // lblDescER
            // 
            this.lblDescER.AutoSize = true;
            this.lblDescER.Location = new System.Drawing.Point(20, 55);
            this.lblDescER.Name = "lblDescER";
            this.lblDescER.Size = new System.Drawing.Size(66, 13);
            this.lblDescER.TabIndex = 3;
            this.lblDescER.Text = "Descripción:";
            // 
            // lblTipoER
            // 
            this.lblTipoER.AutoSize = true;
            this.lblTipoER.Location = new System.Drawing.Point(20, 121);
            this.lblTipoER.Name = "lblTipoER";
            this.lblTipoER.Size = new System.Drawing.Size(82, 13);
            this.lblTipoER.TabIndex = 2;
            this.lblTipoER.Text = "Tipo de evento:";
            // 
            // lblNombreER
            // 
            this.lblNombreER.AutoSize = true;
            this.lblNombreER.Location = new System.Drawing.Point(20, 29);
            this.lblNombreER.Name = "lblNombreER";
            this.lblNombreER.Size = new System.Drawing.Size(101, 13);
            this.lblNombreER.TabIndex = 1;
            this.lblNombreER.Text = "Nombre de evento: ";
            // 
            // btnBuscarE
            // 
            this.btnBuscarE.Location = new System.Drawing.Point(364, 17);
            this.btnBuscarE.Name = "btnBuscarE";
            this.btnBuscarE.Size = new System.Drawing.Size(83, 37);
            this.btnBuscarE.TabIndex = 0;
            this.btnBuscarE.Text = "Buscar evento";
            this.btnBuscarE.UseVisualStyleBackColor = true;
            this.btnBuscarE.Click += new System.EventHandler(this.btnBuscarE_Click);
            // 
            // gpbResumen
            // 
            this.gpbResumen.Controls.Add(this.btnExpPDF);
            this.gpbResumen.Controls.Add(this.btnCarga);
            this.gpbResumen.Controls.Add(this.btnElim);
            this.gpbResumen.Controls.Add(this.btnAgre);
            this.gpbResumen.Controls.Add(this.dgvRes);
            this.gpbResumen.Location = new System.Drawing.Point(479, 13);
            this.gpbResumen.Name = "gpbResumen";
            this.gpbResumen.Size = new System.Drawing.Size(540, 418);
            this.gpbResumen.TabIndex = 5;
            this.gpbResumen.TabStop = false;
            this.gpbResumen.Text = "Resumen";
            // 
            // btnExpPDF
            // 
            this.btnExpPDF.Location = new System.Drawing.Point(436, 350);
            this.btnExpPDF.Name = "btnExpPDF";
            this.btnExpPDF.Size = new System.Drawing.Size(90, 45);
            this.btnExpPDF.TabIndex = 4;
            this.btnExpPDF.Text = "Exportar donaciones";
            this.btnExpPDF.UseVisualStyleBackColor = true;
            this.btnExpPDF.Click += new System.EventHandler(this.btnExpPDF_Click);
            // 
            // btnCarga
            // 
            this.btnCarga.Location = new System.Drawing.Point(436, 35);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(90, 45);
            this.btnCarga.TabIndex = 3;
            this.btnCarga.Text = "Cargar donaciones";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // btnElim
            // 
            this.btnElim.Location = new System.Drawing.Point(125, 35);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(90, 45);
            this.btnElim.TabIndex = 2;
            this.btnElim.Text = "Eliminar seleccionado";
            this.btnElim.UseVisualStyleBackColor = true;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
            // 
            // btnAgre
            // 
            this.btnAgre.Location = new System.Drawing.Point(19, 35);
            this.btnAgre.Name = "btnAgre";
            this.btnAgre.Size = new System.Drawing.Size(91, 45);
            this.btnAgre.TabIndex = 1;
            this.btnAgre.Text = "Agregar al listado";
            this.btnAgre.UseVisualStyleBackColor = true;
            this.btnAgre.Click += new System.EventHandler(this.btnAgre_Click);
            // 
            // dgvRes
            // 
            this.dgvRes.AllowUserToAddRows = false;
            this.dgvRes.AllowUserToDeleteRows = false;
            this.dgvRes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIDD,
            this.cmnDonante,
            this.cmnCantidad,
            this.clmIDPR,
            this.cmn,
            this.clmIDEV,
            this.cmnEve});
            this.dgvRes.Location = new System.Drawing.Point(19, 86);
            this.dgvRes.Name = "dgvRes";
            this.dgvRes.Size = new System.Drawing.Size(507, 235);
            this.dgvRes.TabIndex = 0;
            // 
            // clmIDD
            // 
            this.clmIDD.HeaderText = "ID DONANTE";
            this.clmIDD.Name = "clmIDD";
            this.clmIDD.Visible = false;
            // 
            // cmnDonante
            // 
            this.cmnDonante.HeaderText = "Donante";
            this.cmnDonante.Name = "cmnDonante";
            this.cmnDonante.ReadOnly = true;
            // 
            // cmnCantidad
            // 
            this.cmnCantidad.HeaderText = "Cantidad";
            this.cmnCantidad.Name = "cmnCantidad";
            // 
            // clmIDPR
            // 
            this.clmIDPR.HeaderText = "ID PRODUCTO";
            this.clmIDPR.Name = "clmIDPR";
            this.clmIDPR.Visible = false;
            // 
            // cmn
            // 
            this.cmn.HeaderText = "Producto";
            this.cmn.Name = "cmn";
            this.cmn.ReadOnly = true;
            // 
            // clmIDEV
            // 
            this.clmIDEV.HeaderText = "ID EVENTO";
            this.clmIDEV.Name = "clmIDEV";
            this.clmIDEV.Visible = false;
            // 
            // cmnEve
            // 
            this.cmnEve.HeaderText = "Evento";
            this.cmnEve.Name = "cmnEve";
            this.cmnEve.ReadOnly = true;
            // 
            // UCAltaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbResumen);
            this.Controls.Add(this.gpbEve);
            this.Controls.Add(this.gpbProd);
            this.Controls.Add(this.gpbDonante);
            this.Name = "UCAltaDon";
            this.Size = new System.Drawing.Size(1045, 453);
            this.gpbDonante.ResumeLayout(false);
            this.gpbDonante.PerformLayout();
            this.gpbProd.ResumeLayout(false);
            this.gpbProd.PerformLayout();
            this.gpbEve.ResumeLayout(false);
            this.gpbEve.PerformLayout();
            this.gpbResumen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDonante;
        private System.Windows.Forms.Button btnBuscarD;
        private System.Windows.Forms.Label lblRFCDR;
        private System.Windows.Forms.Label lblNombreDR;
        private System.Windows.Forms.Label lblDirecDR;
        private System.Windows.Forms.Label lblTelDR;
        private System.Windows.Forms.GroupBox gpbProd;
        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.Label lblNombrePR;
        private System.Windows.Forms.Label lblCNetoPR;
        private System.Windows.Forms.Label lblMarcaPR;
        private System.Windows.Forms.Label lblIDDR;
        private System.Windows.Forms.Label lblIDPR;
        private System.Windows.Forms.GroupBox gpbEve;
        private System.Windows.Forms.Label lblTipoER;
        private System.Windows.Forms.Label lblNombreER;
        private System.Windows.Forms.Button btnBuscarE;
        private System.Windows.Forms.Label lblDescER;
        private System.Windows.Forms.Label lblLugER;
        private System.Windows.Forms.Label lblEdoER;
        private System.Windows.Forms.Label lblFecER;
        private System.Windows.Forms.Label lblIDER;
        private System.Windows.Forms.GroupBox gpbResumen;
        private System.Windows.Forms.Button btnCarga;
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.Button btnAgre;
        private System.Windows.Forms.DataGridView dgvRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnDonante;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDPR;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDEV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnEve;
        private System.Windows.Forms.Button btnExpPDF;
    }
}
