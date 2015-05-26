namespace Proyecto_FARA
{
    partial class UCModUsr
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbActivo = new System.Windows.Forms.CheckBox();
            this.cbbTusr = new System.Windows.Forms.ComboBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUsr = new System.Windows.Forms.TextBox();
            this.btnMod = new System.Windows.Forms.Button();
            this.lblactivo = new System.Windows.Forms.Label();
            this.lblTusr = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblUsr = new System.Windows.Forms.Label();
            this.gpbAfil = new System.Windows.Forms.GroupBox();
            this.txtTAfil = new System.Windows.Forms.TextBox();
            this.btnCamAfil = new System.Windows.Forms.Button();
            this.txtDirec = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblTAfil = new System.Windows.Forms.Label();
            this.lblEmailA = new System.Windows.Forms.Label();
            this.lblIDAR = new System.Windows.Forms.Label();
            this.lblDirecA = new System.Windows.Forms.Label();
            this.lblTelA = new System.Windows.Forms.Label();
            this.lblEdadA = new System.Windows.Forms.Label();
            this.lblNombreA = new System.Windows.Forms.Label();
            this.btnBuscarA = new System.Windows.Forms.Button();
            this.pROYECTO_FARADataSet = new Proyecto_FARA.PROYECTO_FARADataSet();
            this.tUSRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tUSRTableAdapter = new Proyecto_FARA.PROYECTO_FARADataSetTableAdapters.TUSRTableAdapter();
            this.tAFILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAFILTableAdapter = new Proyecto_FARA.PROYECTO_FARADataSetTableAdapters.TAFILTableAdapter();
            this.groupBox1.SuspendLayout();
            this.gpbAfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROYECTO_FARADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUSRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAFILBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbActivo);
            this.groupBox1.Controls.Add(this.cbbTusr);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.txtUsr);
            this.groupBox1.Controls.Add(this.btnMod);
            this.groupBox1.Controls.Add(this.lblactivo);
            this.groupBox1.Controls.Add(this.lblTusr);
            this.groupBox1.Controls.Add(this.lblPwd);
            this.groupBox1.Controls.Add(this.lblUsr);
            this.groupBox1.Controls.Add(this.gpbAfil);
            this.groupBox1.Controls.Add(this.btnBuscarA);
            this.groupBox1.Location = new System.Drawing.Point(286, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 406);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // ckbActivo
            // 
            this.ckbActivo.AutoSize = true;
            this.ckbActivo.Location = new System.Drawing.Point(115, 104);
            this.ckbActivo.Name = "ckbActivo";
            this.ckbActivo.Size = new System.Drawing.Size(15, 14);
            this.ckbActivo.TabIndex = 18;
            this.ckbActivo.UseVisualStyleBackColor = true;
            // 
            // cbbTusr
            // 
            this.cbbTusr.FormattingEnabled = true;
            this.cbbTusr.Location = new System.Drawing.Point(115, 77);
            this.cbbTusr.Name = "cbbTusr";
            this.cbbTusr.Size = new System.Drawing.Size(157, 21);
            this.cbbTusr.TabIndex = 17;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(115, 51);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(157, 20);
            this.txtPwd.TabIndex = 16;
            // 
            // txtUsr
            // 
            this.txtUsr.Enabled = false;
            this.txtUsr.Location = new System.Drawing.Point(115, 27);
            this.txtUsr.Name = "txtUsr";
            this.txtUsr.Size = new System.Drawing.Size(157, 20);
            this.txtUsr.TabIndex = 15;
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(366, 68);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(83, 37);
            this.btnMod.TabIndex = 14;
            this.btnMod.Text = "Modificar Usuario";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // lblactivo
            // 
            this.lblactivo.AutoSize = true;
            this.lblactivo.Location = new System.Drawing.Point(29, 103);
            this.lblactivo.Name = "lblactivo";
            this.lblactivo.Size = new System.Drawing.Size(40, 13);
            this.lblactivo.TabIndex = 12;
            this.lblactivo.Text = "Activo:";
            // 
            // lblTusr
            // 
            this.lblTusr.AutoSize = true;
            this.lblTusr.Location = new System.Drawing.Point(26, 80);
            this.lblTusr.Name = "lblTusr";
            this.lblTusr.Size = new System.Drawing.Size(83, 13);
            this.lblTusr.TabIndex = 8;
            this.lblTusr.Text = "Tipo de usuario:";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(29, 57);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(64, 13);
            this.lblPwd.TabIndex = 4;
            this.lblPwd.Text = "Contraseña:";
            // 
            // lblUsr
            // 
            this.lblUsr.AutoSize = true;
            this.lblUsr.Location = new System.Drawing.Point(29, 34);
            this.lblUsr.Name = "lblUsr";
            this.lblUsr.Size = new System.Drawing.Size(46, 13);
            this.lblUsr.TabIndex = 3;
            this.lblUsr.Text = "Usuario:";
            // 
            // gpbAfil
            // 
            this.gpbAfil.Controls.Add(this.txtTAfil);
            this.gpbAfil.Controls.Add(this.btnCamAfil);
            this.gpbAfil.Controls.Add(this.txtDirec);
            this.gpbAfil.Controls.Add(this.txtEmail);
            this.gpbAfil.Controls.Add(this.txtTel);
            this.gpbAfil.Controls.Add(this.txtEdad);
            this.gpbAfil.Controls.Add(this.txtNom);
            this.gpbAfil.Controls.Add(this.lblTAfil);
            this.gpbAfil.Controls.Add(this.lblEmailA);
            this.gpbAfil.Controls.Add(this.lblIDAR);
            this.gpbAfil.Controls.Add(this.lblDirecA);
            this.gpbAfil.Controls.Add(this.lblTelA);
            this.gpbAfil.Controls.Add(this.lblEdadA);
            this.gpbAfil.Controls.Add(this.lblNombreA);
            this.gpbAfil.Location = new System.Drawing.Point(6, 129);
            this.gpbAfil.Name = "gpbAfil";
            this.gpbAfil.Size = new System.Drawing.Size(455, 176);
            this.gpbAfil.TabIndex = 2;
            this.gpbAfil.TabStop = false;
            this.gpbAfil.Text = "Afiliado";
            this.gpbAfil.Enter += new System.EventHandler(this.gpbAfil_Enter);
            // 
            // txtTAfil
            // 
            this.txtTAfil.Enabled = false;
            this.txtTAfil.Location = new System.Drawing.Point(120, 121);
            this.txtTAfil.Name = "txtTAfil";
            this.txtTAfil.Size = new System.Drawing.Size(231, 20);
            this.txtTAfil.TabIndex = 27;
            // 
            // btnCamAfil
            // 
            this.btnCamAfil.Location = new System.Drawing.Point(360, 19);
            this.btnCamAfil.Name = "btnCamAfil";
            this.btnCamAfil.Size = new System.Drawing.Size(83, 37);
            this.btnCamAfil.TabIndex = 26;
            this.btnCamAfil.Text = "Cambiar Afiliado";
            this.btnCamAfil.UseVisualStyleBackColor = true;
            this.btnCamAfil.Click += new System.EventHandler(this.btnCamAfil_Click);
            // 
            // txtDirec
            // 
            this.txtDirec.Enabled = false;
            this.txtDirec.Location = new System.Drawing.Point(120, 147);
            this.txtDirec.Name = "txtDirec";
            this.txtDirec.Size = new System.Drawing.Size(231, 20);
            this.txtDirec.TabIndex = 25;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(120, 94);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 20);
            this.txtEmail.TabIndex = 23;
            // 
            // txtTel
            // 
            this.txtTel.Enabled = false;
            this.txtTel.Location = new System.Drawing.Point(120, 68);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(146, 20);
            this.txtTel.TabIndex = 22;
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(120, 46);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(146, 20);
            this.txtEdad.TabIndex = 21;
            // 
            // txtNom
            // 
            this.txtNom.Enabled = false;
            this.txtNom.Location = new System.Drawing.Point(120, 22);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(146, 20);
            this.txtNom.TabIndex = 20;
            // 
            // lblTAfil
            // 
            this.lblTAfil.AutoSize = true;
            this.lblTAfil.Location = new System.Drawing.Point(24, 123);
            this.lblTAfil.Name = "lblTAfil";
            this.lblTAfil.Size = new System.Drawing.Size(83, 13);
            this.lblTAfil.TabIndex = 19;
            this.lblTAfil.Text = "Tipo de Afiliado:";
            // 
            // lblEmailA
            // 
            this.lblEmailA.AutoSize = true;
            this.lblEmailA.Location = new System.Drawing.Point(23, 97);
            this.lblEmailA.Name = "lblEmailA";
            this.lblEmailA.Size = new System.Drawing.Size(35, 13);
            this.lblEmailA.TabIndex = 3;
            this.lblEmailA.Text = "Email:";
            // 
            // lblIDAR
            // 
            this.lblIDAR.AutoSize = true;
            this.lblIDAR.Location = new System.Drawing.Point(357, 120);
            this.lblIDAR.Name = "lblIDAR";
            this.lblIDAR.Size = new System.Drawing.Size(18, 13);
            this.lblIDAR.TabIndex = 13;
            this.lblIDAR.Text = "ID";
            this.lblIDAR.Visible = false;
            // 
            // lblDirecA
            // 
            this.lblDirecA.AutoSize = true;
            this.lblDirecA.Location = new System.Drawing.Point(26, 153);
            this.lblDirecA.Name = "lblDirecA";
            this.lblDirecA.Size = new System.Drawing.Size(55, 13);
            this.lblDirecA.TabIndex = 12;
            this.lblDirecA.Text = "Dirección:";
            // 
            // lblTelA
            // 
            this.lblTelA.AutoSize = true;
            this.lblTelA.Location = new System.Drawing.Point(20, 69);
            this.lblTelA.Name = "lblTelA";
            this.lblTelA.Size = new System.Drawing.Size(52, 13);
            this.lblTelA.TabIndex = 11;
            this.lblTelA.Text = "Telefono:";
            // 
            // lblEdadA
            // 
            this.lblEdadA.AutoSize = true;
            this.lblEdadA.Location = new System.Drawing.Point(20, 46);
            this.lblEdadA.Name = "lblEdadA";
            this.lblEdadA.Size = new System.Drawing.Size(35, 13);
            this.lblEdadA.TabIndex = 10;
            this.lblEdadA.Text = "Edad:";
            // 
            // lblNombreA
            // 
            this.lblNombreA.AutoSize = true;
            this.lblNombreA.Location = new System.Drawing.Point(20, 22);
            this.lblNombreA.Name = "lblNombreA";
            this.lblNombreA.Size = new System.Drawing.Size(93, 13);
            this.lblNombreA.TabIndex = 9;
            this.lblNombreA.Text = "Nombre completo:";
            // 
            // btnBuscarA
            // 
            this.btnBuscarA.Location = new System.Drawing.Point(366, 22);
            this.btnBuscarA.Name = "btnBuscarA";
            this.btnBuscarA.Size = new System.Drawing.Size(83, 37);
            this.btnBuscarA.TabIndex = 8;
            this.btnBuscarA.Text = "Buscar Usuario";
            this.btnBuscarA.UseVisualStyleBackColor = true;
            this.btnBuscarA.Click += new System.EventHandler(this.btnBuscarA_Click);
            // 
            // pROYECTO_FARADataSet
            // 
            this.pROYECTO_FARADataSet.DataSetName = "PROYECTO_FARADataSet";
            this.pROYECTO_FARADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tUSRBindingSource
            // 
            this.tUSRBindingSource.DataMember = "TUSR";
            this.tUSRBindingSource.DataSource = this.pROYECTO_FARADataSet;
            // 
            // tUSRTableAdapter
            // 
            this.tUSRTableAdapter.ClearBeforeFill = true;
            // 
            // tAFILBindingSource
            // 
            this.tAFILBindingSource.DataMember = "TAFIL";
            this.tAFILBindingSource.DataSource = this.pROYECTO_FARADataSet;
            // 
            // tAFILTableAdapter
            // 
            this.tAFILTableAdapter.ClearBeforeFill = true;
            // 
            // UCModUsr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCModUsr";
            this.Size = new System.Drawing.Size(1043, 453);
            this.Load += new System.EventHandler(this.UCModUsr_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbAfil.ResumeLayout(false);
            this.gpbAfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROYECTO_FARADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUSRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAFILBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbActivo;
        private System.Windows.Forms.ComboBox cbbTusr;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUsr;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Label lblactivo;
        private System.Windows.Forms.Label lblTusr;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblUsr;
        private System.Windows.Forms.GroupBox gpbAfil;
        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblTAfil;
        private System.Windows.Forms.Label lblEmailA;
        private System.Windows.Forms.Label lblIDAR;
        private System.Windows.Forms.Label lblDirecA;
        private System.Windows.Forms.Label lblTelA;
        private System.Windows.Forms.Label lblEdadA;
        private System.Windows.Forms.Label lblNombreA;
        private System.Windows.Forms.Button btnBuscarA;
        private System.Windows.Forms.Button btnCamAfil;
        private System.Windows.Forms.BindingSource tUSRBindingSource;
        private PROYECTO_FARADataSet pROYECTO_FARADataSet;
        private System.Windows.Forms.BindingSource tAFILBindingSource;
        private PROYECTO_FARADataSetTableAdapters.TUSRTableAdapter tUSRTableAdapter;
        private PROYECTO_FARADataSetTableAdapters.TAFILTableAdapter tAFILTableAdapter;
        private System.Windows.Forms.TextBox txtTAfil;
    }
}
