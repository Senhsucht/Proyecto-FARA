namespace Proyecto_FARA.Formas
{
    partial class conDonante
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conDonante));
            this.gpbDonante = new System.Windows.Forms.GroupBox();
            this.dgvDon = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAPPAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAPMAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmULTACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarD = new System.Windows.Forms.Button();
            this.lblRFCD = new System.Windows.Forms.Label();
            this.txtRFCDon = new System.Windows.Forms.TextBox();
            this.txtApeMDon = new System.Windows.Forms.TextBox();
            this.lblApe_PatD = new System.Windows.Forms.Label();
            this.txtApePDon = new System.Windows.Forms.TextBox();
            this.lblApe_MatD = new System.Windows.Forms.Label();
            this.lblNombreD = new System.Windows.Forms.Label();
            this.txtNomDon = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpbDonante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDon)).BeginInit();
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
            this.gpbDonante.Location = new System.Drawing.Point(12, 12);
            this.gpbDonante.Name = "gpbDonante";
            this.gpbDonante.Size = new System.Drawing.Size(603, 287);
            this.gpbDonante.TabIndex = 1;
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
            this.dgvDon.Size = new System.Drawing.Size(562, 210);
            this.dgvDon.TabIndex = 10;
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
            // btnBuscarD
            // 
            this.btnBuscarD.Location = new System.Drawing.Point(506, 32);
            this.btnBuscarD.Name = "btnBuscarD";
            this.btnBuscarD.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarD.TabIndex = 8;
            this.btnBuscarD.Text = "Buscar";
            this.btnBuscarD.UseVisualStyleBackColor = true;
            // 
            // lblRFCD
            // 
            this.lblRFCD.AutoSize = true;
            this.lblRFCD.Location = new System.Drawing.Point(383, 21);
            this.lblRFCD.Name = "lblRFCD";
            this.lblRFCD.Size = new System.Drawing.Size(28, 13);
            this.lblRFCD.TabIndex = 7;
            this.lblRFCD.Text = "RFC";
            // 
            // txtRFCDon
            // 
            this.txtRFCDon.Location = new System.Drawing.Point(400, 35);
            this.txtRFCDon.Name = "txtRFCDon";
            this.txtRFCDon.Size = new System.Drawing.Size(100, 20);
            this.txtRFCDon.TabIndex = 6;
            // 
            // txtApeMDon
            // 
            this.txtApeMDon.Location = new System.Drawing.Point(276, 35);
            this.txtApeMDon.Name = "txtApeMDon";
            this.txtApeMDon.Size = new System.Drawing.Size(100, 20);
            this.txtApeMDon.TabIndex = 5;
            // 
            // lblApe_PatD
            // 
            this.lblApe_PatD.AutoSize = true;
            this.lblApe_PatD.Location = new System.Drawing.Point(132, 19);
            this.lblApe_PatD.Name = "lblApe_PatD";
            this.lblApe_PatD.Size = new System.Drawing.Size(84, 13);
            this.lblApe_PatD.TabIndex = 4;
            this.lblApe_PatD.Text = "Apellido Paterno";
            // 
            // txtApePDon
            // 
            this.txtApePDon.Location = new System.Drawing.Point(149, 35);
            this.txtApePDon.Name = "txtApePDon";
            this.txtApePDon.Size = new System.Drawing.Size(100, 20);
            this.txtApePDon.TabIndex = 3;
            // 
            // lblApe_MatD
            // 
            this.lblApe_MatD.AutoSize = true;
            this.lblApe_MatD.Location = new System.Drawing.Point(258, 21);
            this.lblApe_MatD.Name = "lblApe_MatD";
            this.lblApe_MatD.Size = new System.Drawing.Size(86, 13);
            this.lblApe_MatD.TabIndex = 2;
            this.lblApe_MatD.Text = "Apellido Materno";
            // 
            // lblNombreD
            // 
            this.lblNombreD.AutoSize = true;
            this.lblNombreD.Location = new System.Drawing.Point(11, 16);
            this.lblNombreD.Name = "lblNombreD";
            this.lblNombreD.Size = new System.Drawing.Size(44, 13);
            this.lblNombreD.TabIndex = 1;
            this.lblNombreD.Text = "Nombre";
            // 
            // txtNomDon
            // 
            this.txtNomDon.Location = new System.Drawing.Point(29, 35);
            this.txtNomDon.Name = "txtNomDon";
            this.txtNomDon.Size = new System.Drawing.Size(100, 20);
            this.txtNomDon.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(424, 306);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(518, 305);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // conDonante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 340);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gpbDonante);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "conDonante";
            this.Text = "conDonante";
            this.gpbDonante.ResumeLayout(false);
            this.gpbDonante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDonante;
        private System.Windows.Forms.DataGridView dgvDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAPPAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAPMAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmULTACT;
        private System.Windows.Forms.Button btnBuscarD;
        private System.Windows.Forms.Label lblRFCD;
        private System.Windows.Forms.TextBox txtRFCDon;
        private System.Windows.Forms.TextBox txtApeMDon;
        private System.Windows.Forms.Label lblApe_PatD;
        private System.Windows.Forms.TextBox txtApePDon;
        private System.Windows.Forms.Label lblApe_MatD;
        private System.Windows.Forms.Label lblNombreD;
        private System.Windows.Forms.TextBox txtNomDon;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}