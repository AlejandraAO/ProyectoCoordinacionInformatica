namespace Vista
{
    partial class frmBusquedaProyectos
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.lbIdentificacion = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbIndentifica = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTrabajador = new System.Windows.Forms.RadioButton();
            this.rbGestionEstudiante = new System.Windows.Forms.RadioButton();
            this.rbResponsable = new System.Windows.Forms.RadioButton();
            this.rbCoordinador = new System.Windows.Forms.RadioButton();
            this.lvProyecto = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.Proyectos = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Proyectos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIdentificacion
            // 
            this.lbIdentificacion.AutoSize = true;
            this.lbIdentificacion.BackColor = System.Drawing.Color.Transparent;
            this.lbIdentificacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdentificacion.ForeColor = System.Drawing.Color.White;
            this.lbIdentificacion.Location = new System.Drawing.Point(62, 28);
            this.lbIdentificacion.Name = "lbIdentificacion";
            this.lbIdentificacion.Size = new System.Drawing.Size(163, 18);
            this.lbIdentificacion.TabIndex = 28;
            this.lbIdentificacion.Text = "Identificación Profesor";
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.btnBuscar);
            this.groupBox.Controls.Add(this.cbIndentifica);
            this.groupBox.Controls.Add(this.lbIdentificacion);
            this.groupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Location = new System.Drawing.Point(29, 46);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(594, 71);
            this.groupBox.TabIndex = 29;
            this.groupBox.TabStop = false;
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
            this.btnBuscar.Location = new System.Drawing.Point(405, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(77, 37);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbIndentifica
            // 
            this.cbIndentifica.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbIndentifica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIndentifica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIndentifica.ForeColor = System.Drawing.Color.Black;
            this.cbIndentifica.FormattingEnabled = true;
            this.cbIndentifica.Location = new System.Drawing.Point(227, 24);
            this.cbIndentifica.Name = "cbIndentifica";
            this.cbIndentifica.Size = new System.Drawing.Size(121, 25);
            this.cbIndentifica.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbTrabajador);
            this.groupBox1.Controls.Add(this.rbGestionEstudiante);
            this.groupBox1.Controls.Add(this.rbResponsable);
            this.groupBox1.Controls.Add(this.rbCoordinador);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(29, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 114);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rbTrabajador
            // 
            this.rbTrabajador.AutoSize = true;
            this.rbTrabajador.BackColor = System.Drawing.Color.Transparent;
            this.rbTrabajador.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTrabajador.ForeColor = System.Drawing.Color.White;
            this.rbTrabajador.Location = new System.Drawing.Point(299, 63);
            this.rbTrabajador.Name = "rbTrabajador";
            this.rbTrabajador.Size = new System.Drawing.Size(212, 21);
            this.rbTrabajador.TabIndex = 35;
            this.rbTrabajador.TabStop = true;
            this.rbTrabajador.Text = "Proyectos Como Trabajador.";
            this.rbTrabajador.UseVisualStyleBackColor = false;
            // 
            // rbGestionEstudiante
            // 
            this.rbGestionEstudiante.AutoSize = true;
            this.rbGestionEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.rbGestionEstudiante.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGestionEstudiante.ForeColor = System.Drawing.Color.White;
            this.rbGestionEstudiante.Location = new System.Drawing.Point(299, 25);
            this.rbGestionEstudiante.Name = "rbGestionEstudiante";
            this.rbGestionEstudiante.Size = new System.Drawing.Size(290, 21);
            this.rbGestionEstudiante.TabIndex = 34;
            this.rbGestionEstudiante.TabStop = true;
            this.rbGestionEstudiante.Text = "Proyectos Gestionados Por Estudiantes.";
            this.rbGestionEstudiante.UseVisualStyleBackColor = false;
            // 
            // rbResponsable
            // 
            this.rbResponsable.AutoSize = true;
            this.rbResponsable.BackColor = System.Drawing.Color.Transparent;
            this.rbResponsable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbResponsable.ForeColor = System.Drawing.Color.White;
            this.rbResponsable.Location = new System.Drawing.Point(40, 63);
            this.rbResponsable.Name = "rbResponsable";
            this.rbResponsable.Size = new System.Drawing.Size(230, 21);
            this.rbResponsable.TabIndex = 33;
            this.rbResponsable.TabStop = true;
            this.rbResponsable.Text = "Proyectos Como Responsable.";
            this.rbResponsable.UseVisualStyleBackColor = false;
            // 
            // rbCoordinador
            // 
            this.rbCoordinador.AutoSize = true;
            this.rbCoordinador.BackColor = System.Drawing.Color.Transparent;
            this.rbCoordinador.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCoordinador.ForeColor = System.Drawing.Color.White;
            this.rbCoordinador.Location = new System.Drawing.Point(40, 25);
            this.rbCoordinador.Name = "rbCoordinador";
            this.rbCoordinador.Size = new System.Drawing.Size(223, 21);
            this.rbCoordinador.TabIndex = 32;
            this.rbCoordinador.TabStop = true;
            this.rbCoordinador.Text = "Proyectos Como Coordinador.";
            this.rbCoordinador.UseVisualStyleBackColor = false;
            // 
            // lvProyecto
            // 
            this.lvProyecto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvProyecto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvProyecto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProyecto.ForeColor = System.Drawing.Color.Black;
            this.lvProyecto.GridLines = true;
            listViewItem2.Tag = "asdasdasd";
            this.lvProyecto.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvProyecto.Location = new System.Drawing.Point(6, 281);
            this.lvProyecto.Name = "lvProyecto";
            this.lvProyecto.Size = new System.Drawing.Size(636, 164);
            this.lvProyecto.TabIndex = 31;
            this.lvProyecto.UseCompatibleStateImageBehavior = false;
            this.lvProyecto.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 113;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descripción";
            this.columnHeader2.Width = 164;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Estado";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tipo";
            this.columnHeader4.Width = 116;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Horas Trabajadas";
            this.columnHeader5.Width = 115;
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
            this.btnSalir.Location = new System.Drawing.Point(566, 462);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 37);
            this.btnSalir.TabIndex = 32;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Proyectos
            // 
            this.Proyectos.BackColor = System.Drawing.Color.Transparent;
            this.Proyectos.Controls.Add(this.btnSalir);
            this.Proyectos.Controls.Add(this.groupBox);
            this.Proyectos.Controls.Add(this.groupBox1);
            this.Proyectos.Controls.Add(this.lvProyecto);
            this.Proyectos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proyectos.ForeColor = System.Drawing.Color.White;
            this.Proyectos.Location = new System.Drawing.Point(84, 36);
            this.Proyectos.Name = "Proyectos";
            this.Proyectos.Size = new System.Drawing.Size(649, 515);
            this.Proyectos.TabIndex = 33;
            this.Proyectos.TabStop = false;
            this.Proyectos.Text = "Busqueda De Proyectos";
            // 
            // frmBusquedaProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 586);
            this.ControlBox = false;
            this.Controls.Add(this.Proyectos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBusquedaProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBusquedaProyectos";
            this.Load += new System.EventHandler(this.frmBusquedaProyectos_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Proyectos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbIdentificacion;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox cbIndentifica;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTrabajador;
        private System.Windows.Forms.RadioButton rbGestionEstudiante;
        private System.Windows.Forms.RadioButton rbResponsable;
        private System.Windows.Forms.RadioButton rbCoordinador;
        private System.Windows.Forms.ListView lvProyecto;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox Proyectos;
    }
}