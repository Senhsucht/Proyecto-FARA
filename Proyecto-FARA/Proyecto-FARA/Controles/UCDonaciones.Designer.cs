namespace Proyecto_FARA
{
    partial class UCDonaciones
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
            this.dgvDon = new System.Windows.Forms.DataGridView();
            this.btnBuscarD = new System.Windows.Forms.Button();
            this.lblRFCD = new System.Windows.Forms.Label();
            this.txtRFCDon = new System.Windows.Forms.TextBox();
            this.txtApeMDon = new System.Windows.Forms.TextBox();
            this.lblApe_PatD = new System.Windows.Forms.Label();
            this.txtApePDon = new System.Windows.Forms.TextBox();
            this.lblApe_MatD = new System.Windows.Forms.Label();
            this.lblNombreD = new System.Windows.Forms.Label();
            this.txtNomDon = new System.Windows.Forms.TextBox();
            this.gpbProd = new System.Windows.Forms.GroupBox();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.txtMarProd = new System.Windows.Forms.TextBox();
            this.lblMarcaP = new System.Windows.Forms.Label();
            this.lblNombreP = new System.Windows.Forms.Label();
            this.txtNomProd = new System.Windows.Forms.TextBox();
            this.gpbEve = new System.Windows.Forms.GroupBox();
            this.txtNomEve = new System.Windows.Forms.TextBox();
            this.lblTipEv = new System.Windows.Forms.Label();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.btnBuscarE = new System.Windows.Forms.Button();
            this.gpbResumen = new System.Windows.Forms.GroupBox();
            this.btnCarga = new System.Windows.Forms.Button();
            this.btnElim = new System.Windows.Forms.Button();
            this.btnAgre = new System.Windows.Forms.Button();
            this.dgvRes = new System.Windows.Forms.DataGridView();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.dgvEve = new System.Windows.Forms.DataGridView();
            this.clmIDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNomP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCNETO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmULT_ACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAPPAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAPMAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmULTACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNOMEVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDESCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLUGAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTEVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEVEEDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmULT_ACT_EVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTEVE = new System.Windows.Forms.TextBox();
            this.clmIDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnDonante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIDPR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIDEV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnEve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbDonante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDon)).BeginInit();
            this.gpbProd.SuspendLayout();
            this.gpbEve.SuspendLayout();
            this.gpbResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEve)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDonante
            // 
            this.gpbDonante.Controls.Add(this.dgvDon);
            this.gpbDonante.Controls.Add(this.btnBuscarD);
            this.gpbDonante.Controls.Add(this.lblRFCD);
            this.gpbDonante.Controls.Add(this.txtRFCDon);
            this.gpbDonante.Controls.Add(this.txtApeMDon);
            this.gpbDonante.Controls.Add(this.lblApe_PatD);
            this.gpbDonante.Controls.Add(this.txtApePDon);
            this.gpbDonante.Controls.Add(this.lblApe_MatD);
            this.gpbDonante.Controls.Add(this.lblNombreD);
            this.gpbDonante.Controls.Add(this.txtNomDon);
            this.gpbDonante.Location = new System.Drawing.Point(24, 19);
            this.gpbDonante.Name = "gpbDonante";
            this.gpbDonante.Size = new System.Drawing.Size(700, 342);
            this.gpbDonante.TabIndex = 0;
            this.gpbDonante.TabStop = false;
            this.gpbDonante.Text = "Donante";
            // 
            // dgvDon
            // 
            this.dgvDon.AllowUserToAddRows = false;
            this.dgvDon.AllowUserToDeleteRows = false;
            this.dgvDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmNombre,
            this.clmAPPAT,
            this.clmAPMAT,
            this.clmRFC,
            this.clmTEL,
            this.clmDIRECCION,
            this.clmULTACT});
            this.dgvDon.Location = new System.Drawing.Point(19, 61);
            this.dgvDon.Name = "dgvDon";
            this.dgvDon.ReadOnly = true;
            this.dgvDon.Size = new System.Drawing.Size(650, 275);
            this.dgvDon.TabIndex = 10;
            // 
            // btnBuscarD
            // 
            this.btnBuscarD.Location = new System.Drawing.Point(574, 32);
            this.btnBuscarD.Name = "btnBuscarD";
            this.btnBuscarD.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarD.TabIndex = 8;
            this.btnBuscarD.Text = "Buscar";
            this.btnBuscarD.UseVisualStyleBackColor = true;
            this.btnBuscarD.Click += new System.EventHandler(this.busquedaDon);
            // 
            // lblRFCD
            // 
            this.lblRFCD.AutoSize = true;
            this.lblRFCD.Location = new System.Drawing.Point(437, 21);
            this.lblRFCD.Name = "lblRFCD";
            this.lblRFCD.Size = new System.Drawing.Size(28, 13);
            this.lblRFCD.TabIndex = 7;
            this.lblRFCD.Text = "RFC";
            // 
            // txtRFCDon
            // 
            this.txtRFCDon.Location = new System.Drawing.Point(454, 35);
            this.txtRFCDon.Name = "txtRFCDon";
            this.txtRFCDon.Size = new System.Drawing.Size(100, 20);
            this.txtRFCDon.TabIndex = 6;
            // 
            // txtApeMDon
            // 
            this.txtApeMDon.Location = new System.Drawing.Point(330, 35);
            this.txtApeMDon.Name = "txtApeMDon";
            this.txtApeMDon.Size = new System.Drawing.Size(100, 20);
            this.txtApeMDon.TabIndex = 5;
            // 
            // lblApe_PatD
            // 
            this.lblApe_PatD.AutoSize = true;
            this.lblApe_PatD.Location = new System.Drawing.Point(186, 19);
            this.lblApe_PatD.Name = "lblApe_PatD";
            this.lblApe_PatD.Size = new System.Drawing.Size(84, 13);
            this.lblApe_PatD.TabIndex = 4;
            this.lblApe_PatD.Text = "Apellido Paterno";
            // 
            // txtApePDon
            // 
            this.txtApePDon.Location = new System.Drawing.Point(203, 35);
            this.txtApePDon.Name = "txtApePDon";
            this.txtApePDon.Size = new System.Drawing.Size(100, 20);
            this.txtApePDon.TabIndex = 3;
            // 
            // lblApe_MatD
            // 
            this.lblApe_MatD.AutoSize = true;
            this.lblApe_MatD.Location = new System.Drawing.Point(312, 21);
            this.lblApe_MatD.Name = "lblApe_MatD";
            this.lblApe_MatD.Size = new System.Drawing.Size(86, 13);
            this.lblApe_MatD.TabIndex = 2;
            this.lblApe_MatD.Text = "Apellido Materno";
            // 
            // lblNombreD
            // 
            this.lblNombreD.AutoSize = true;
            this.lblNombreD.Location = new System.Drawing.Point(56, 16);
            this.lblNombreD.Name = "lblNombreD";
            this.lblNombreD.Size = new System.Drawing.Size(44, 13);
            this.lblNombreD.TabIndex = 1;
            this.lblNombreD.Text = "Nombre";
            // 
            // txtNomDon
            // 
            this.txtNomDon.Location = new System.Drawing.Point(74, 35);
            this.txtNomDon.Name = "txtNomDon";
            this.txtNomDon.Size = new System.Drawing.Size(100, 20);
            this.txtNomDon.TabIndex = 0;
            // 
            // gpbProd
            // 
            this.gpbProd.Controls.Add(this.dgvProd);
            this.gpbProd.Controls.Add(this.btnBuscarP);
            this.gpbProd.Controls.Add(this.txtMarProd);
            this.gpbProd.Controls.Add(this.lblMarcaP);
            this.gpbProd.Controls.Add(this.lblNombreP);
            this.gpbProd.Controls.Add(this.txtNomProd);
            this.gpbProd.Location = new System.Drawing.Point(24, 386);
            this.gpbProd.Name = "gpbProd";
            this.gpbProd.Size = new System.Drawing.Size(700, 350);
            this.gpbProd.TabIndex = 1;
            this.gpbProd.TabStop = false;
            this.gpbProd.Text = "Producto";
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.Location = new System.Drawing.Point(355, 39);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarP.TabIndex = 4;
            this.btnBuscarP.Text = "Buscar";
            this.btnBuscarP.UseVisualStyleBackColor = true;
            this.btnBuscarP.Click += new System.EventHandler(this.busquedaProd);
            // 
            // txtMarProd
            // 
            this.txtMarProd.Location = new System.Drawing.Point(203, 42);
            this.txtMarProd.Name = "txtMarProd";
            this.txtMarProd.Size = new System.Drawing.Size(121, 20);
            this.txtMarProd.TabIndex = 3;
            // 
            // lblMarcaP
            // 
            this.lblMarcaP.AutoSize = true;
            this.lblMarcaP.Location = new System.Drawing.Point(186, 27);
            this.lblMarcaP.Name = "lblMarcaP";
            this.lblMarcaP.Size = new System.Drawing.Size(37, 13);
            this.lblMarcaP.TabIndex = 2;
            this.lblMarcaP.Text = "Marca";
            // 
            // lblNombreP
            // 
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.Location = new System.Drawing.Point(56, 28);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(106, 13);
            this.lblNombreP.TabIndex = 1;
            this.lblNombreP.Text = "Nombre del producto";
            // 
            // txtNomProd
            // 
            this.txtNomProd.Location = new System.Drawing.Point(74, 44);
            this.txtNomProd.Name = "txtNomProd";
            this.txtNomProd.Size = new System.Drawing.Size(100, 20);
            this.txtNomProd.TabIndex = 0;
            // 
            // gpbEve
            // 
            this.gpbEve.Controls.Add(this.txtTEVE);
            this.gpbEve.Controls.Add(this.dgvEve);
            this.gpbEve.Controls.Add(this.txtNomEve);
            this.gpbEve.Controls.Add(this.lblTipEv);
            this.gpbEve.Controls.Add(this.lblNombreE);
            this.gpbEve.Controls.Add(this.btnBuscarE);
            this.gpbEve.Location = new System.Drawing.Point(730, 19);
            this.gpbEve.Name = "gpbEve";
            this.gpbEve.Size = new System.Drawing.Size(700, 350);
            this.gpbEve.TabIndex = 2;
            this.gpbEve.TabStop = false;
            this.gpbEve.Text = "Evento";
            // 
            // txtNomEve
            // 
            this.txtNomEve.Location = new System.Drawing.Point(74, 54);
            this.txtNomEve.Name = "txtNomEve";
            this.txtNomEve.Size = new System.Drawing.Size(100, 20);
            this.txtNomEve.TabIndex = 6;
            // 
            // lblTipEv
            // 
            this.lblTipEv.AutoSize = true;
            this.lblTipEv.Location = new System.Drawing.Point(186, 37);
            this.lblTipEv.Name = "lblTipEv";
            this.lblTipEv.Size = new System.Drawing.Size(79, 13);
            this.lblTipEv.TabIndex = 2;
            this.lblTipEv.Text = "Tipo de evento";
            // 
            // lblNombreE
            // 
            this.lblNombreE.AutoSize = true;
            this.lblNombreE.Location = new System.Drawing.Point(56, 38);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(95, 13);
            this.lblNombreE.TabIndex = 1;
            this.lblNombreE.Text = "Nombre de evento";
            // 
            // btnBuscarE
            // 
            this.btnBuscarE.Location = new System.Drawing.Point(355, 53);
            this.btnBuscarE.Name = "btnBuscarE";
            this.btnBuscarE.Size = new System.Drawing.Size(75, 21);
            this.btnBuscarE.TabIndex = 0;
            this.btnBuscarE.Text = "Buscar";
            this.btnBuscarE.UseVisualStyleBackColor = true;
            this.btnBuscarE.Click += new System.EventHandler(this.busquedaEVE);
            // 
            // gpbResumen
            // 
            this.gpbResumen.Controls.Add(this.btnCarga);
            this.gpbResumen.Controls.Add(this.btnElim);
            this.gpbResumen.Controls.Add(this.btnAgre);
            this.gpbResumen.Controls.Add(this.dgvRes);
            this.gpbResumen.Location = new System.Drawing.Point(730, 386);
            this.gpbResumen.Name = "gpbResumen";
            this.gpbResumen.Size = new System.Drawing.Size(700, 384);
            this.gpbResumen.TabIndex = 4;
            this.gpbResumen.TabStop = false;
            this.gpbResumen.Text = "Resumen";
            // 
            // btnCarga
            // 
            this.btnCarga.Location = new System.Drawing.Point(559, 35);
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
            this.dgvRes.Size = new System.Drawing.Size(650, 238);
            this.dgvRes.TabIndex = 0;
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToAddRows = false;
            this.dgvProd.AllowUserToDeleteRows = false;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIDP,
            this.clmNomP,
            this.clmMARCA,
            this.clmCNETO,
            this.clmULT_ACT});
            this.dgvProd.Location = new System.Drawing.Point(19, 68);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.Size = new System.Drawing.Size(650, 249);
            this.dgvProd.TabIndex = 5;
            // 
            // dgvEve
            // 
            this.dgvEve.AllowUserToAddRows = false;
            this.dgvEve.AllowUserToDeleteRows = false;
            this.dgvEve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIDE,
            this.clmNOMEVE,
            this.clmDESCR,
            this.clmLUGAR,
            this.clmFECHA,
            this.clmTEVE,
            this.clmEVEEDO,
            this.clmULT_ACT_EVE});
            this.dgvEve.Location = new System.Drawing.Point(19, 81);
            this.dgvEve.Name = "dgvEve";
            this.dgvEve.ReadOnly = true;
            this.dgvEve.Size = new System.Drawing.Size(650, 248);
            this.dgvEve.TabIndex = 7;
            // 
            // clmIDP
            // 
            this.clmIDP.HeaderText = "ID";
            this.clmIDP.Name = "clmIDP";
            this.clmIDP.ReadOnly = true;
            this.clmIDP.Visible = false;
            // 
            // clmNomP
            // 
            this.clmNomP.HeaderText = "NOMBRE";
            this.clmNomP.Name = "clmNomP";
            this.clmNomP.ReadOnly = true;
            // 
            // clmMARCA
            // 
            this.clmMARCA.HeaderText = "MARCA";
            this.clmMARCA.Name = "clmMARCA";
            this.clmMARCA.ReadOnly = true;
            // 
            // clmCNETO
            // 
            this.clmCNETO.HeaderText = "CONTENIDO NETO";
            this.clmCNETO.Name = "clmCNETO";
            this.clmCNETO.ReadOnly = true;
            // 
            // clmULT_ACT
            // 
            this.clmULT_ACT.HeaderText = "ULTIMA ACTUALIZACION";
            this.clmULT_ACT.Name = "clmULT_ACT";
            this.clmULT_ACT.ReadOnly = true;
            this.clmULT_ACT.Visible = false;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Visible = false;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "NOMBRE";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmAPPAT
            // 
            this.clmAPPAT.HeaderText = "APELLIDO PATERNO";
            this.clmAPPAT.Name = "clmAPPAT";
            this.clmAPPAT.ReadOnly = true;
            // 
            // clmAPMAT
            // 
            this.clmAPMAT.HeaderText = "APELLIDO MATERNO";
            this.clmAPMAT.Name = "clmAPMAT";
            this.clmAPMAT.ReadOnly = true;
            // 
            // clmRFC
            // 
            this.clmRFC.HeaderText = "RFC";
            this.clmRFC.Name = "clmRFC";
            this.clmRFC.ReadOnly = true;
            // 
            // clmTEL
            // 
            this.clmTEL.HeaderText = "TELEFONO";
            this.clmTEL.Name = "clmTEL";
            this.clmTEL.ReadOnly = true;
            // 
            // clmDIRECCION
            // 
            this.clmDIRECCION.HeaderText = "DIRECCION";
            this.clmDIRECCION.Name = "clmDIRECCION";
            this.clmDIRECCION.ReadOnly = true;
            // 
            // clmULTACT
            // 
            this.clmULTACT.HeaderText = "ULTIMA ACTUALIZACION";
            this.clmULTACT.Name = "clmULTACT";
            this.clmULTACT.ReadOnly = true;
            this.clmULTACT.Visible = false;
            // 
            // clmIDE
            // 
            this.clmIDE.HeaderText = "ID";
            this.clmIDE.Name = "clmIDE";
            this.clmIDE.ReadOnly = true;
            this.clmIDE.Visible = false;
            // 
            // clmNOMEVE
            // 
            this.clmNOMEVE.HeaderText = "NOMBRE DE EVENTO";
            this.clmNOMEVE.Name = "clmNOMEVE";
            this.clmNOMEVE.ReadOnly = true;
            // 
            // clmDESCR
            // 
            this.clmDESCR.HeaderText = "DESCRIPCION";
            this.clmDESCR.Name = "clmDESCR";
            this.clmDESCR.ReadOnly = true;
            // 
            // clmLUGAR
            // 
            this.clmLUGAR.HeaderText = "LUGAR DEL EVENTO";
            this.clmLUGAR.Name = "clmLUGAR";
            this.clmLUGAR.ReadOnly = true;
            // 
            // clmFECHA
            // 
            this.clmFECHA.HeaderText = "FECHA DEL EVENTO";
            this.clmFECHA.Name = "clmFECHA";
            this.clmFECHA.ReadOnly = true;
            // 
            // clmTEVE
            // 
            this.clmTEVE.HeaderText = "TIPO DE EVENTO";
            this.clmTEVE.Name = "clmTEVE";
            this.clmTEVE.ReadOnly = true;
            this.clmTEVE.Visible = false;
            // 
            // clmEVEEDO
            // 
            this.clmEVEEDO.HeaderText = "ESTADO DEL EVENTO";
            this.clmEVEEDO.Name = "clmEVEEDO";
            this.clmEVEEDO.ReadOnly = true;
            // 
            // clmULT_ACT_EVE
            // 
            this.clmULT_ACT_EVE.HeaderText = "ULTIMA ACTUALIZACION";
            this.clmULT_ACT_EVE.Name = "clmULT_ACT_EVE";
            this.clmULT_ACT_EVE.ReadOnly = true;
            this.clmULT_ACT_EVE.Visible = false;
            // 
            // txtTEVE
            // 
            this.txtTEVE.Location = new System.Drawing.Point(203, 55);
            this.txtTEVE.Name = "txtTEVE";
            this.txtTEVE.Size = new System.Drawing.Size(121, 20);
            this.txtTEVE.TabIndex = 8;
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
            // 
            // UCDonaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbResumen);
            this.Controls.Add(this.gpbEve);
            this.Controls.Add(this.gpbProd);
            this.Controls.Add(this.gpbDonante);
            this.Name = "UCDonaciones";
            this.Size = new System.Drawing.Size(1500, 804);
            this.gpbDonante.ResumeLayout(false);
            this.gpbDonante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDon)).EndInit();
            this.gpbProd.ResumeLayout(false);
            this.gpbProd.PerformLayout();
            this.gpbEve.ResumeLayout(false);
            this.gpbEve.PerformLayout();
            this.gpbResumen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEve)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDonante;
        private System.Windows.Forms.Button btnBuscarD;
        private System.Windows.Forms.Label lblRFCD;
        private System.Windows.Forms.TextBox txtRFCDon;
        private System.Windows.Forms.TextBox txtApeMDon;
        private System.Windows.Forms.Label lblApe_PatD;
        private System.Windows.Forms.TextBox txtApePDon;
        private System.Windows.Forms.Label lblApe_MatD;
        private System.Windows.Forms.Label lblNombreD;
        private System.Windows.Forms.TextBox txtNomDon;
        private System.Windows.Forms.GroupBox gpbProd;
        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.TextBox txtMarProd;
        private System.Windows.Forms.Label lblMarcaP;
        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.TextBox txtNomProd;
        private System.Windows.Forms.GroupBox gpbEve;
        private System.Windows.Forms.TextBox txtNomEve;
        private System.Windows.Forms.Label lblTipEv;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.Button btnBuscarE;
        private System.Windows.Forms.GroupBox gpbResumen;
        private System.Windows.Forms.DataGridView dgvRes;
        private System.Windows.Forms.Button btnCarga;
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.Button btnAgre;
        private System.Windows.Forms.DataGridView dgvDon;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAPPAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAPMAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmULTACT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNomP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCNETO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmULT_ACT;
        private System.Windows.Forms.DataGridView dgvEve;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNOMEVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDESCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLUGAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTEVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEVEEDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmULT_ACT_EVE;
        private System.Windows.Forms.TextBox txtTEVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnDonante;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDPR;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDEV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnEve;
    }
}
