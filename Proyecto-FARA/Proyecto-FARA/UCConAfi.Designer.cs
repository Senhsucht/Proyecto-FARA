namespace Proyecto_FARA
{
    partial class UCConAfi
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbAfiliado = new System.Windows.Forms.GroupBox();
            this.dgvAfil = new System.Windows.Forms.DataGridView();
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
            this.gpbAfiliado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfil)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbAfiliado
            // 
            this.gpbAfiliado.Controls.Add(this.dgvAfil);
            this.gpbAfiliado.Controls.Add(this.btnBuscar);
            this.gpbAfiliado.Controls.Add(this.txtApeM);
            this.gpbAfiliado.Controls.Add(this.lblApe_PatD);
            this.gpbAfiliado.Controls.Add(this.txtApeP);
            this.gpbAfiliado.Controls.Add(this.lblApe_MatD);
            this.gpbAfiliado.Controls.Add(this.lblNombreD);
            this.gpbAfiliado.Controls.Add(this.txtNom);
            this.gpbAfiliado.Location = new System.Drawing.Point(162, 19);
            this.gpbAfiliado.Name = "gpbAfiliado";
            this.gpbAfiliado.Size = new System.Drawing.Size(780, 391);
            this.gpbAfiliado.TabIndex = 10;
            this.gpbAfiliado.TabStop = false;
            this.gpbAfiliado.Text = "Adoptante";
            // 
            // dgvAfil
            // 
            this.dgvAfil.AllowUserToAddRows = false;
            this.dgvAfil.AllowUserToDeleteRows = false;
            this.dgvAfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAfil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmNombre,
            this.clmAPPAT,
            this.clmAPMAT,
            this.clmEdad,
            this.clmTEL,
            this.clmEmail,
            this.clmDIRECCION,
            this.clmULTACT});
            this.dgvAfil.Location = new System.Drawing.Point(19, 61);
            this.dgvAfil.Name = "dgvAfil";
            this.dgvAfil.ReadOnly = true;
            this.dgvAfil.Size = new System.Drawing.Size(744, 258);
            this.dgvAfil.TabIndex = 10;
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
            this.btnBuscar.Location = new System.Drawing.Point(658, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtApeM
            // 
            this.txtApeM.Location = new System.Drawing.Point(353, 32);
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
            this.txtApeP.Location = new System.Drawing.Point(190, 32);
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
            // UCConAfi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbAfiliado);
            this.Name = "UCConAfi";
            this.Size = new System.Drawing.Size(1045, 453);
            this.Load += new System.EventHandler(this.UCConAfi_Load);
            this.gpbAfiliado.ResumeLayout(false);
            this.gpbAfiliado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAfiliado;
        private System.Windows.Forms.DataGridView dgvAfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAPPAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAPMAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmULTACT;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtApeM;
        private System.Windows.Forms.Label lblApe_PatD;
        private System.Windows.Forms.TextBox txtApeP;
        private System.Windows.Forms.Label lblApe_MatD;
        private System.Windows.Forms.Label lblNombreD;
        private System.Windows.Forms.TextBox txtNom;


    }
}
