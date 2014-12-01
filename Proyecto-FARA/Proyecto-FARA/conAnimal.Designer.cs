namespace Proyecto_FARA
{
    partial class conAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conAnimal));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gpbDonante = new System.Windows.Forms.GroupBox();
            this.cbxTAni = new System.Windows.Forms.ComboBox();
            this.cbxRAni = new System.Windows.Forms.ComboBox();
            this.dgvAni = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTiAni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRANI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmULTACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblEdAni = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblTAni = new System.Windows.Forms.Label();
            this.lblRAni = new System.Windows.Forms.Label();
            this.lblNombreD = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.gpbDonante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAni)).BeginInit();
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
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(424, 305);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // gpbDonante
            // 
            this.gpbDonante.Controls.Add(this.cbxTAni);
            this.gpbDonante.Controls.Add(this.cbxRAni);
            this.gpbDonante.Controls.Add(this.dgvAni);
            this.gpbDonante.Controls.Add(this.btnBuscar);
            this.gpbDonante.Controls.Add(this.lblEdAni);
            this.gpbDonante.Controls.Add(this.txtEdad);
            this.gpbDonante.Controls.Add(this.lblTAni);
            this.gpbDonante.Controls.Add(this.lblRAni);
            this.gpbDonante.Controls.Add(this.lblNombreD);
            this.gpbDonante.Controls.Add(this.txtNom);
            this.gpbDonante.Location = new System.Drawing.Point(12, 12);
            this.gpbDonante.Name = "gpbDonante";
            this.gpbDonante.Size = new System.Drawing.Size(603, 287);
            this.gpbDonante.TabIndex = 4;
            this.gpbDonante.TabStop = false;
            this.gpbDonante.Text = "Donante";
            // 
            // cbxTAni
            // 
            this.cbxTAni.FormattingEnabled = true;
            this.cbxTAni.Location = new System.Drawing.Point(146, 34);
            this.cbxTAni.Name = "cbxTAni";
            this.cbxTAni.Size = new System.Drawing.Size(121, 21);
            this.cbxTAni.TabIndex = 12;
            // 
            // cbxRAni
            // 
            this.cbxRAni.FormattingEnabled = true;
            this.cbxRAni.Location = new System.Drawing.Point(273, 33);
            this.cbxRAni.Name = "cbxRAni";
            this.cbxRAni.Size = new System.Drawing.Size(121, 21);
            this.cbxRAni.TabIndex = 11;
            // 
            // dgvAni
            // 
            this.dgvAni.AllowUserToAddRows = false;
            this.dgvAni.AllowUserToDeleteRows = false;
            this.dgvAni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmNombre,
            this.clmTiAni,
            this.clmRANI,
            this.clmEDAD,
            this.clmULTACT});
            this.dgvAni.Location = new System.Drawing.Point(19, 61);
            this.dgvAni.Name = "dgvAni";
            this.dgvAni.ReadOnly = true;
            this.dgvAni.Size = new System.Drawing.Size(562, 210);
            this.dgvAni.TabIndex = 10;
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
            // clmTiAni
            // 
            this.clmTiAni.HeaderText = "TIPO";
            this.clmTiAni.Name = "clmTiAni";
            this.clmTiAni.ReadOnly = true;
            // 
            // clmRANI
            // 
            this.clmRANI.HeaderText = "RAZA";
            this.clmRANI.Name = "clmRANI";
            this.clmRANI.ReadOnly = true;
            // 
            // clmEDAD
            // 
            this.clmEDAD.HeaderText = "EDAD";
            this.clmEDAD.Name = "clmEDAD";
            this.clmEDAD.ReadOnly = true;
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
            this.btnBuscar.Location = new System.Drawing.Point(506, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblEdAni
            // 
            this.lblEdAni.AutoSize = true;
            this.lblEdAni.Location = new System.Drawing.Point(383, 20);
            this.lblEdAni.Name = "lblEdAni";
            this.lblEdAni.Size = new System.Drawing.Size(70, 13);
            this.lblEdAni.TabIndex = 7;
            this.lblEdAni.Text = "Edad (aprox.)";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(400, 34);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 6;
            // 
            // lblTAni
            // 
            this.lblTAni.AutoSize = true;
            this.lblTAni.Location = new System.Drawing.Point(132, 19);
            this.lblTAni.Name = "lblTAni";
            this.lblTAni.Size = new System.Drawing.Size(76, 13);
            this.lblTAni.TabIndex = 4;
            this.lblTAni.Text = "Tipo de animal";
            // 
            // lblRAni
            // 
            this.lblRAni.AutoSize = true;
            this.lblRAni.Location = new System.Drawing.Point(258, 19);
            this.lblRAni.Name = "lblRAni";
            this.lblRAni.Size = new System.Drawing.Size(82, 13);
            this.lblRAni.TabIndex = 2;
            this.lblRAni.Text = "Raza del animal";
            // 
            // lblNombreD
            // 
            this.lblNombreD.AutoSize = true;
            this.lblNombreD.Location = new System.Drawing.Point(16, 19);
            this.lblNombreD.Name = "lblNombreD";
            this.lblNombreD.Size = new System.Drawing.Size(44, 13);
            this.lblNombreD.TabIndex = 1;
            this.lblNombreD.Text = "Nombre";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(40, 35);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 0;
            // 
            // conAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 340);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gpbDonante);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "conAnimal";
            this.Text = "Consulta Animal";
            this.gpbDonante.ResumeLayout(false);
            this.gpbDonante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gpbDonante;
        private System.Windows.Forms.DataGridView dgvAni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblEdAni;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblTAni;
        private System.Windows.Forms.Label lblRAni;
        private System.Windows.Forms.Label lblNombreD;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ComboBox cbxTAni;
        private System.Windows.Forms.ComboBox cbxRAni;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTiAni;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRANI;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmULTACT;

    }
}