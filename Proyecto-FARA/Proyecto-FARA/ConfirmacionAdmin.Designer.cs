namespace Proyecto_FARA
{
    partial class ConfirmacionAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmacionAdmin));
            this.txtConf = new System.Windows.Forms.TextBox();
            this.lblConf = new System.Windows.Forms.Label();
            this.btnConf = new System.Windows.Forms.Button();
            this.gpbConfirmacion = new System.Windows.Forms.GroupBox();
            this.gpbConfirmacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConf
            // 
            this.txtConf.Location = new System.Drawing.Point(65, 54);
            this.txtConf.Name = "txtConf";
            this.txtConf.PasswordChar = '*';
            this.txtConf.Size = new System.Drawing.Size(162, 20);
            this.txtConf.TabIndex = 0;
            // 
            // lblConf
            // 
            this.lblConf.AutoSize = true;
            this.lblConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConf.Location = new System.Drawing.Point(48, 16);
            this.lblConf.Name = "lblConf";
            this.lblConf.Size = new System.Drawing.Size(46, 17);
            this.lblConf.TabIndex = 1;
            this.lblConf.Text = "label1";
            // 
            // btnConf
            // 
            this.btnConf.Location = new System.Drawing.Point(104, 80);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(75, 23);
            this.btnConf.TabIndex = 2;
            this.btnConf.Text = "Confirmar";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // gpbConfirmacion
            // 
            this.gpbConfirmacion.Controls.Add(this.btnConf);
            this.gpbConfirmacion.Controls.Add(this.txtConf);
            this.gpbConfirmacion.Controls.Add(this.lblConf);
            this.gpbConfirmacion.Location = new System.Drawing.Point(12, 12);
            this.gpbConfirmacion.Name = "gpbConfirmacion";
            this.gpbConfirmacion.Size = new System.Drawing.Size(289, 131);
            this.gpbConfirmacion.TabIndex = 3;
            this.gpbConfirmacion.TabStop = false;
            // 
            // ConfirmacionAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 156);
            this.Controls.Add(this.gpbConfirmacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfirmacionAdmin";
            this.Text = "Confirmación Administrador";
            this.Load += new System.EventHandler(this.ConfirmacionAdmin_Load);
            this.gpbConfirmacion.ResumeLayout(false);
            this.gpbConfirmacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtConf;
        private System.Windows.Forms.Label lblConf;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.GroupBox gpbConfirmacion;
    }
}