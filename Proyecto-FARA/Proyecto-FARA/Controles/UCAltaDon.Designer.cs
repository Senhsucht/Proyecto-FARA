namespace Proyecto_FARA.Controles
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
            this.lblDirecDR = new System.Windows.Forms.Label();
            this.lblTelDR = new System.Windows.Forms.Label();
            this.lblRFCDR = new System.Windows.Forms.Label();
            this.lblNombreDR = new System.Windows.Forms.Label();
            this.btnBuscarD = new System.Windows.Forms.Button();
            this.gpbDonante.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDonante
            // 
            this.gpbDonante.Controls.Add(this.lblDirecDR);
            this.gpbDonante.Controls.Add(this.lblTelDR);
            this.gpbDonante.Controls.Add(this.lblRFCDR);
            this.gpbDonante.Controls.Add(this.lblNombreDR);
            this.gpbDonante.Controls.Add(this.btnBuscarD);
            this.gpbDonante.Location = new System.Drawing.Point(18, 13);
            this.gpbDonante.Name = "gpbDonante";
            this.gpbDonante.Size = new System.Drawing.Size(603, 147);
            this.gpbDonante.TabIndex = 1;
            this.gpbDonante.TabStop = false;
            this.gpbDonante.Text = "Donante";
            // 
            // lblDirecDR
            // 
            this.lblDirecDR.AutoSize = true;
            this.lblDirecDR.Location = new System.Drawing.Point(20, 112);
            this.lblDirecDR.Name = "lblDirecDR";
            this.lblDirecDR.Size = new System.Drawing.Size(55, 13);
            this.lblDirecDR.TabIndex = 12;
            this.lblDirecDR.Text = "Dirección:";
            // 
            // lblTelDR
            // 
            this.lblTelDR.AutoSize = true;
            this.lblTelDR.Location = new System.Drawing.Point(20, 87);
            this.lblTelDR.Name = "lblTelDR";
            this.lblTelDR.Size = new System.Drawing.Size(52, 13);
            this.lblTelDR.TabIndex = 11;
            this.lblTelDR.Text = "Telefono:";
            // 
            // lblRFCDR
            // 
            this.lblRFCDR.AutoSize = true;
            this.lblRFCDR.Location = new System.Drawing.Point(20, 59);
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
            this.lblNombreDR.Size = new System.Drawing.Size(47, 13);
            this.lblNombreDR.TabIndex = 9;
            this.lblNombreDR.Text = "Nombre:";
            // 
            // btnBuscarD
            // 
            this.btnBuscarD.Location = new System.Drawing.Point(514, 19);
            this.btnBuscarD.Name = "btnBuscarD";
            this.btnBuscarD.Size = new System.Drawing.Size(83, 37);
            this.btnBuscarD.TabIndex = 8;
            this.btnBuscarD.Text = "Buscar donante";
            this.btnBuscarD.UseVisualStyleBackColor = true;
            this.btnBuscarD.Click += new System.EventHandler(this.btnBuscarD_Click);
            // 
            // UCAltaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbDonante);
            this.Name = "UCAltaDon";
            this.Size = new System.Drawing.Size(1245, 470);
            this.gpbDonante.ResumeLayout(false);
            this.gpbDonante.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDonante;
        private System.Windows.Forms.Button btnBuscarD;
        private System.Windows.Forms.Label lblRFCDR;
        private System.Windows.Forms.Label lblNombreDR;
        private System.Windows.Forms.Label lblDirecDR;
        private System.Windows.Forms.Label lblTelDR;
    }
}
