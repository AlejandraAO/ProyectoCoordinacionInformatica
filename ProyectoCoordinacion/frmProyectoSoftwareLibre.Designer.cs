namespace Vista
{
    partial class frmProyectoSoftwareLibre
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
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lbInformacion = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtDescripcion = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEstado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.ForeColor = System.Drawing.Color.Black;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Habilitado",
            "Inhabilitado"});
            this.cbEstado.Location = new System.Drawing.Point(422, 73);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(173, 25);
            this.cbEstado.TabIndex = 32;
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExaminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExaminar.FlatAppearance.BorderSize = 2;
            this.btnExaminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnExaminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExaminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.ForeColor = System.Drawing.Color.Black;
            this.btnExaminar.Location = new System.Drawing.Point(483, 118);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(84, 37);
            this.btnExaminar.TabIndex = 31;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = false;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(76, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(233, 26);
            this.txtNombre.TabIndex = 29;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.lbInformacion);
            this.groupBox.Controls.Add(this.btnBuscar);
            this.groupBox.Controls.Add(this.txtIdentificador);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.cbTipo);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.rtDescripcion);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.txtNombre);
            this.groupBox.Controls.Add(this.cbEstado);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.btnExaminar);
            this.groupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Location = new System.Drawing.Point(35, 21);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(622, 247);
            this.groupBox.TabIndex = 33;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Gestion de Proyecto";
            // 
            // lbInformacion
            // 
            this.lbInformacion.AutoSize = true;
            this.lbInformacion.BackColor = System.Drawing.Color.Transparent;
            this.lbInformacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformacion.ForeColor = System.Drawing.Color.White;
            this.lbInformacion.Location = new System.Drawing.Point(377, 158);
            this.lbInformacion.Name = "lbInformacion";
            this.lbInformacion.Size = new System.Drawing.Size(173, 18);
            this.lbInformacion.TabIndex = 43;
            this.lbInformacion.Text = "Nombre del Documento";
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
            this.btnBuscar.Location = new System.Drawing.Point(227, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(82, 37);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Text = "Consultar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIdentificador.Enabled = false;
            this.txtIdentificador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificador.ForeColor = System.Drawing.Color.Black;
            this.txtIdentificador.Location = new System.Drawing.Point(105, 30);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(116, 26);
            this.txtIdentificador.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "Identificador";
            // 
            // cbTipo
            // 
            this.cbTipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTipo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.ForeColor = System.Drawing.Color.Black;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Software Libre",
            "Curso Libre"});
            this.cbTipo.Location = new System.Drawing.Point(402, 33);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(194, 25);
            this.cbTipo.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(358, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(358, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Informacion";
            // 
            // rtDescripcion
            // 
            this.rtDescripcion.Location = new System.Drawing.Point(9, 127);
            this.rtDescripcion.Name = "rtDescripcion";
            this.rtDescripcion.Size = new System.Drawing.Size(297, 96);
            this.rtDescripcion.TabIndex = 37;
            this.rtDescripcion.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(358, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Descripcion";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(35, 299);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 37);
            this.btnAgregar.TabIndex = 34;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificar.FlatAppearance.BorderSize = 2;
            this.btnModificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnModificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(144, 299);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(84, 37);
            this.btnModificar.TabIndex = 35;
            this.btnModificar.Text = "Modificar ";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.btnSalir.Location = new System.Drawing.Point(573, 299);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 37);
            this.btnSalir.TabIndex = 41;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmProyectoSoftwareLibre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(689, 358);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProyectoSoftwareLibre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion de Proyectos de Software Libre";
            this.Load += new System.EventHandler(this.frmProyectoSoftwareLibre_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtDescripcion;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbInformacion;
    }
}