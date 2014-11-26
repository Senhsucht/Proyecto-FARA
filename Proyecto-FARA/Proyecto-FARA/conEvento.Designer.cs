namespace Proyecto_FARA
{
    partial class conEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conEvento));
            this.gpbEve = new System.Windows.Forms.GroupBox();
            this.txtTEVE = new System.Windows.Forms.TextBox();
            this.dgvEve = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNOMEVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDESCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLUGAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTEVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEVEEDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmULT_ACT_EVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNomEve = new System.Windows.Forms.TextBox();
            this.lblTipEv = new System.Windows.Forms.Label();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.btnBuscarE = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpbEve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEve)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbEve
            // 
            this.gpbEve.Controls.Add(this.txtTEVE);
            this.gpbEve.Controls.Add(this.dgvEve);
            this.gpbEve.Controls.Add(this.txtNomEve);
            this.gpbEve.Controls.Add(this.lblTipEv);
            this.gpbEve.Controls.Add(this.lblNombreE);
            this.gpbEve.Controls.Add(this.btnBuscarE);
            this.gpbEve.Location = new System.Drawing.Point(12, 12);
            this.gpbEve.Name = "gpbEve";
            this.gpbEve.Size = new System.Drawing.Size(602, 287);
            this.gpbEve.TabIndex = 3;
            this.gpbEve.TabStop = false;
            this.gpbEve.Text = "Evento";
            // 
            // txtTEVE
            // 
            this.txtTEVE.Location = new System.Drawing.Point(214, 36);
            this.txtTEVE.Name = "txtTEVE";
            this.txtTEVE.Size = new System.Drawing.Size(121, 20);
            this.txtTEVE.TabIndex = 8;
            // 
            // dgvEve
            // 
            this.dgvEve.AllowUserToAddRows = false;
            this.dgvEve.AllowUserToDeleteRows = false;
            this.dgvEve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmNOMEVE,
            this.clmDESCR,
            this.clmLUGAR,
            this.clmFECHA,
            this.clmTEVE,
            this.clmEVEEDO,
            this.clmULT_ACT_EVE});
            this.dgvEve.Location = new System.Drawing.Point(19, 61);
            this.dgvEve.Name = "dgvEve";
            this.dgvEve.ReadOnly = true;
            this.dgvEve.Size = new System.Drawing.Size(561, 210);
            this.dgvEve.TabIndex = 7;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Visible = false;
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
            // txtNomEve
            // 
            this.txtNomEve.Location = new System.Drawing.Point(75, 35);
            this.txtNomEve.Name = "txtNomEve";
            this.txtNomEve.Size = new System.Drawing.Size(100, 20);
            this.txtNomEve.TabIndex = 6;
            // 
            // lblTipEv
            // 
            this.lblTipEv.AutoSize = true;
            this.lblTipEv.Location = new System.Drawing.Point(197, 18);
            this.lblTipEv.Name = "lblTipEv";
            this.lblTipEv.Size = new System.Drawing.Size(79, 13);
            this.lblTipEv.TabIndex = 2;
            this.lblTipEv.Text = "Tipo de evento";
            // 
            // lblNombreE
            // 
            this.lblNombreE.AutoSize = true;
            this.lblNombreE.Location = new System.Drawing.Point(57, 19);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(95, 13);
            this.lblNombreE.TabIndex = 1;
            this.lblNombreE.Text = "Nombre de evento";
            // 
            // btnBuscarE
            // 
            this.btnBuscarE.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBuscarE.Location = new System.Drawing.Point(485, 35);
            this.btnBuscarE.Name = "btnBuscarE";
            this.btnBuscarE.Size = new System.Drawing.Size(75, 21);
            this.btnBuscarE.TabIndex = 0;
            this.btnBuscarE.Text = "Buscar";
            this.btnBuscarE.UseVisualStyleBackColor = true;
            this.btnBuscarE.Click += new System.EventHandler(this.busquedaEVE);
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAceptar.Location = new System.Drawing.Point(424, 305);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(517, 305);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // conEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(626, 340);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gpbEve);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "conEvento";
            this.Text = "conEvento";
            this.gpbEve.ResumeLayout(false);
            this.gpbEve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEve)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbEve;
        private System.Windows.Forms.TextBox txtTEVE;
        private System.Windows.Forms.DataGridView dgvEve;
        private System.Windows.Forms.TextBox txtNomEve;
        private System.Windows.Forms.Label lblTipEv;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.Button btnBuscarE;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNOMEVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDESCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLUGAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTEVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEVEEDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmULT_ACT_EVE;
    }
}