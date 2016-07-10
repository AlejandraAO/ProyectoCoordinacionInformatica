namespace Vista
{
    partial class frmBusquedaTelefonoCorreo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaTelefonoCorreo));
            this.dgListaInformacionProfesor = new System.Windows.Forms.DataGridView();
            this.asd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.cbIdentificacion = new System.Windows.Forms.ComboBox();
            this.btnBuscarPorIdentificacion = new System.Windows.Forms.Button();
            this.lbIdentificacion = new System.Windows.Forms.Label();
            this.btnSalirBuscarInformacion = new System.Windows.Forms.Button();
            this.rbtTelefonos = new System.Windows.Forms.RadioButton();
            this.rbtCorreos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Consultar = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaInformacionProfesor)).BeginInit();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Consultar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgListaInformacionProfesor
            // 
            this.dgListaInformacionProfesor.AllowUserToAddRows = false;
            this.dgListaInformacionProfesor.AllowUserToDeleteRows = false;
            this.dgListaInformacionProfesor.AllowUserToResizeColumns = false;
            this.dgListaInformacionProfesor.AllowUserToResizeRows = false;
            this.dgListaInformacionProfesor.BackgroundColor = System.Drawing.Color.Silver;
            this.dgListaInformacionProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaInformacionProfesor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asd});
            resources.ApplyResources(this.dgListaInformacionProfesor, "dgListaInformacionProfesor");
            this.dgListaInformacionProfesor.Name = "dgListaInformacionProfesor";
            this.dgListaInformacionProfesor.ReadOnly = true;
            this.dgListaInformacionProfesor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // asd
            // 
            this.asd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.asd.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.asd, "asd");
            this.asd.Name = "asd";
            this.asd.ReadOnly = true;
            this.asd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.cbIdentificacion);
            this.groupBox.Controls.Add(this.btnBuscarPorIdentificacion);
            this.groupBox.Controls.Add(this.lbIdentificacion);
            resources.ApplyResources(this.groupBox, "groupBox");
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Name = "groupBox";
            this.groupBox.TabStop = false;
            // 
            // cbIdentificacion
            // 
            this.cbIdentificacion.FormattingEnabled = true;
            resources.ApplyResources(this.cbIdentificacion, "cbIdentificacion");
            this.cbIdentificacion.Name = "cbIdentificacion";
            // 
            // btnBuscarPorIdentificacion
            // 
            this.btnBuscarPorIdentificacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarPorIdentificacion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarPorIdentificacion.FlatAppearance.BorderSize = 2;
            this.btnBuscarPorIdentificacion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnBuscarPorIdentificacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnBuscarPorIdentificacion, "btnBuscarPorIdentificacion");
            this.btnBuscarPorIdentificacion.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarPorIdentificacion.Name = "btnBuscarPorIdentificacion";
            this.btnBuscarPorIdentificacion.UseVisualStyleBackColor = false;
            this.btnBuscarPorIdentificacion.Click += new System.EventHandler(this.btnBuscarPorIdentificacion_Click_1);
            // 
            // lbIdentificacion
            // 
            resources.ApplyResources(this.lbIdentificacion, "lbIdentificacion");
            this.lbIdentificacion.BackColor = System.Drawing.Color.Transparent;
            this.lbIdentificacion.ForeColor = System.Drawing.Color.White;
            this.lbIdentificacion.Name = "lbIdentificacion";
            // 
            // btnSalirBuscarInformacion
            // 
            this.btnSalirBuscarInformacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalirBuscarInformacion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalirBuscarInformacion.FlatAppearance.BorderSize = 2;
            this.btnSalirBuscarInformacion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnSalirBuscarInformacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnSalirBuscarInformacion, "btnSalirBuscarInformacion");
            this.btnSalirBuscarInformacion.ForeColor = System.Drawing.Color.Black;
            this.btnSalirBuscarInformacion.Name = "btnSalirBuscarInformacion";
            this.btnSalirBuscarInformacion.UseVisualStyleBackColor = false;
            this.btnSalirBuscarInformacion.Click += new System.EventHandler(this.btnSalirBuscarInformacion_Click);
            // 
            // rbtTelefonos
            // 
            resources.ApplyResources(this.rbtTelefonos, "rbtTelefonos");
            this.rbtTelefonos.BackColor = System.Drawing.Color.Transparent;
            this.rbtTelefonos.ForeColor = System.Drawing.Color.White;
            this.rbtTelefonos.Name = "rbtTelefonos";
            this.rbtTelefonos.TabStop = true;
            this.rbtTelefonos.UseVisualStyleBackColor = false;
            // 
            // rbtCorreos
            // 
            resources.ApplyResources(this.rbtCorreos, "rbtCorreos");
            this.rbtCorreos.BackColor = System.Drawing.Color.Transparent;
            this.rbtCorreos.ForeColor = System.Drawing.Color.White;
            this.rbtCorreos.Name = "rbtCorreos";
            this.rbtCorreos.TabStop = true;
            this.rbtCorreos.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgListaInformacionProfesor);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // Consultar
            // 
            this.Consultar.BackColor = System.Drawing.Color.Transparent;
            this.Consultar.Controls.Add(this.btnSalirBuscarInformacion);
            this.Consultar.Controls.Add(this.groupBox2);
            this.Consultar.Controls.Add(this.groupBox);
            this.Consultar.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.Consultar, "Consultar");
            this.Consultar.ForeColor = System.Drawing.Color.White;
            this.Consultar.Name = "Consultar";
            this.Consultar.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rbtTelefonos);
            this.groupBox2.Controls.Add(this.rbtCorreos);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // frmBusquedaTelefonoCorreo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.ControlBox = false;
            this.Controls.Add(this.Consultar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBusquedaTelefonoCorreo";
            this.Load += new System.EventHandler(this.frmBuscarInformacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaInformacionProfesor)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.Consultar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListaInformacionProfesor;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnSalirBuscarInformacion;
        private System.Windows.Forms.RadioButton rbtTelefonos;
        private System.Windows.Forms.RadioButton rbtCorreos;
        private System.Windows.Forms.Button btnBuscarPorIdentificacion;
        private System.Windows.Forms.Label lbIdentificacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Consultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn asd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbIdentificacion;
    }
}