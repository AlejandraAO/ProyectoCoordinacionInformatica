namespace Vista
{
    partial class frmObservacionesPeriodoLaboral
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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            this.Proyectos = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvObervacion = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbIndentificacion = new System.Windows.Forms.ComboBox();
            this.lbIdentificacion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaSalida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.Proyectos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Proyectos
            // 
            this.Proyectos.BackColor = System.Drawing.Color.Transparent;
            this.Proyectos.Controls.Add(this.groupBox2);
            this.Proyectos.Controls.Add(this.btnSalir);
            this.Proyectos.Controls.Add(this.groupBox);
            this.Proyectos.Controls.Add(this.groupBox1);
            this.Proyectos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proyectos.ForeColor = System.Drawing.Color.White;
            this.Proyectos.Location = new System.Drawing.Point(60, 25);
            this.Proyectos.Name = "Proyectos";
            this.Proyectos.Size = new System.Drawing.Size(680, 578);
            this.Proyectos.TabIndex = 35;
            this.Proyectos.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lvObervacion);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(19, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 299);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Observaciones";
            // 
            // lvObervacion
            // 
            this.lvObervacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvObervacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvObervacion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvObervacion.ForeColor = System.Drawing.Color.Black;
            this.lvObervacion.GridLines = true;
            listViewItem6.Tag = "asdasdasd";
            this.lvObervacion.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6});
            this.lvObervacion.Location = new System.Drawing.Point(12, 35);
            this.lvObervacion.Name = "lvObervacion";
            this.lvObervacion.Size = new System.Drawing.Size(621, 236);
            this.lvObervacion.TabIndex = 33;
            this.lvObervacion.UseCompatibleStateImageBehavior = false;
            this.lvObervacion.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Descripción";
            this.columnHeader1.Width = 347;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Observador";
            this.columnHeader2.Width = 163;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha";
            this.columnHeader3.Width = 106;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(586, 535);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 37);
            this.btnSalir.TabIndex = 32;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.btnBuscar);
            this.groupBox.Controls.Add(this.cbIndentificacion);
            this.groupBox.Controls.Add(this.lbIdentificacion);
            this.groupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Location = new System.Drawing.Point(19, 36);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(644, 81);
            this.groupBox.TabIndex = 29;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Información Del Profesor ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(414, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(77, 37);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbIndentificacion
            // 
            this.cbIndentificacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbIndentificacion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIndentificacion.ForeColor = System.Drawing.Color.Black;
            this.cbIndentificacion.FormattingEnabled = true;
            this.cbIndentificacion.Location = new System.Drawing.Point(235, 28);
            this.cbIndentificacion.Name = "cbIndentificacion";
            this.cbIndentificacion.Size = new System.Drawing.Size(121, 25);
            this.cbIndentificacion.TabIndex = 29;
            // 
            // lbIdentificacion
            // 
            this.lbIdentificacion.AutoSize = true;
            this.lbIdentificacion.BackColor = System.Drawing.Color.Transparent;
            this.lbIdentificacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdentificacion.ForeColor = System.Drawing.Color.White;
            this.lbIdentificacion.Location = new System.Drawing.Point(83, 33);
            this.lbIdentificacion.Name = "lbIdentificacion";
            this.lbIdentificacion.Size = new System.Drawing.Size(103, 18);
            this.lbIdentificacion.TabIndex = 28;
            this.lbIdentificacion.Text = "Identificación:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFechaSalida);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFechaIngreso);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 81);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Periodo Laboral";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(338, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Fecha Salida";
            // 
            // txtFechaSalida
            // 
            this.txtFechaSalida.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFechaSalida.Enabled = false;
            this.txtFechaSalida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaSalida.ForeColor = System.Drawing.Color.Black;
            this.txtFechaSalida.Location = new System.Drawing.Point(463, 27);
            this.txtFechaSalida.Name = "txtFechaSalida";
            this.txtFechaSalida.ReadOnly = true;
            this.txtFechaSalida.Size = new System.Drawing.Size(128, 26);
            this.txtFechaSalida.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "Fecha Ingreso";
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFechaIngreso.Enabled = false;
            this.txtFechaIngreso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaIngreso.ForeColor = System.Drawing.Color.Black;
            this.txtFechaIngreso.Location = new System.Drawing.Point(162, 27);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.ReadOnly = true;
            this.txtFechaIngreso.Size = new System.Drawing.Size(128, 26);
            this.txtFechaIngreso.TabIndex = 35;
            // 
            // frmObservacionesPeriodoLaboral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.ControlBox = false;
            this.Controls.Add(this.Proyectos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmObservacionesPeriodoLaboral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmObservacionesPeriodoLaboral";
            this.Load += new System.EventHandler(this.frmObservacionesPeriodoLaboral_Load);
            this.Proyectos.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Proyectos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbIndentificacion;
        private System.Windows.Forms.Label lbIdentificacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFechaIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFechaSalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvObervacion;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}