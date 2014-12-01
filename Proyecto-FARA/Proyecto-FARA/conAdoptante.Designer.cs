namespace Proyecto_FARA
{
    partial class conAdoptante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conAdoptante));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gpbDonante = new System.Windows.Forms.GroupBox();
            this.dgvAdop = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAPPAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAPMAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmULTACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtApeM = new System.Windows.Forms.TextBox();
            this.lblApe_PatD = new System.Windows.Forms.Label();
            this.txtApeP = new System.Windows.Forms.TextBox();
            this.lblApe_MatD = new System.Windows.Forms.Label();
            this.lblNombreD = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.gpbDonante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdop)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(518, 305);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(424, 305);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gpbDonante
            // 
            this.gpbDonante.Controls.Add(this.dgvAdop);
            this.gpbDonante.Controls.Add(this.btnBuscar);
            this.gpbDonante.Controls.Add(this.txtApeM);
            this.gpbDonante.Controls.Add(this.lblApe_PatD);
            this.gpbDonante.Controls.Add(this.txtApeP);
            this.gpbDonante.Controls.Add(this.lblApe_MatD);
            this.gpbDonante.Controls.Add(this.lblNombreD);
            this.gpbDonante.Controls.Add(this.txtNom);
            this.gpbDonante.Location = new System.Drawing.Point(12, 12);
            this.gpbDonante.Name = "gpbDonante";
            this.gpbDonante.Size = new System.Drawing.Size(603, 287);
            this.gpbDonante.TabIndex = 4;
            this.gpbDonante.TabStop = false;
            this.gpbDonante.Text = "Adoptante";
            // 
            // dgvAdop
            // 
            this.dgvAdop.AllowUserToAddRows = false;
            this.dgvAdop.AllowUserToDeleteRows = false;
            this.dgvAdop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmNombre,
            this.clmAPPAT,
            this.clmAPMAT,
            this.clmEdad,
            this.clmTEL,
            this.clmEmail,
            this.clmDIRECCION,
            this.clmULTACT});
            this.dgvAdop.Location = new System.Drawing.Point(19, 61);
            this.dgvAdop.Name = "dgvAdop";
            this.dgvAdop.ReadOnly = true;
            this.dgvAdop.Size = new System.Drawing.Size(562, 210);
            this.dgvAdop.TabIndex = 10;
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
            // clmEdad
            // 
            this.clmEdad.HeaderText = "EDAD";
            this.clmEdad.Name = "clmEdad";
            this.clmEdad.ReadOnly = true;
            // 
            // clmTEL
            // 
            this.clmTEL.HeaderText = "TELEFONO";
            this.clmTEL.Name = "clmTEL";
            this.clmTEL.ReadOnly = true;
            // 
            // clmEmail
            // 
            this.clmEmail.HeaderText = "EMAIL";
            this.clmEmail.Name = "clmEmail";
            this.clmEmail.ReadOnly = true;
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
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(506, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtApeM
            // 
            this.txtApeM.Location = new System.Drawing.Point(350, 35);
            this.txtApeM.Name = "txtApeM";
            this.txtApeM.Size = new System.Drawing.Size(100, 20);
            this.txtApeM.TabIndex = 5;
            // 
            // lblApe_PatD
            // 
            this.lblApe_PatD.AutoSize = true;
            this.lblApe_PatD.Location = new System.Drawing.Point(172, 16);
            this.lblApe_PatD.Name = "lblApe_PatD";
            this.lblApe_PatD.Size = new System.Drawing.Size(84, 13);
            this.lblApe_PatD.TabIndex = 4;
            this.lblApe_PatD.Text = "Apellido Paterno";
            // 
            // txtApeP
            // 
            this.txtApeP.Location = new System.Drawing.Point(193, 32);
            this.txtApeP.Name = "txtApeP";
            this.txtApeP.Size = new System.Drawing.Size(100, 20);
            this.txtApeP.TabIndex = 3;
            // 
            // lblApe_MatD
            // 
            this.lblApe_MatD.AutoSize = true;
            this.lblApe_MatD.Location = new System.Drawing.Point(333, 16);
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
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(29, 32);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 0;
            // 
            // conAdoptante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 340);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gpbDonante);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "conAdoptante";
            this.Text = "Consulta adoptante";
            this.gpbDonante.ResumeLayout(false);
            this.gpbDonante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gpbDonante;
        private System.Windows.Forms.DataGridView dgvAdop;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtApeM;
        private System.Windows.Forms.Label lblApe_PatD;
        private System.Windows.Forms.TextBox txtApeP;
        private System.Windows.Forms.Label lblApe_MatD;
        private System.Windows.Forms.Label lblNombreD;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAPPAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAPMAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmULTACT;
    }
}