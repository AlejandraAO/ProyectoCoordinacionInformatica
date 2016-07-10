namespace Vista
{
    partial class frmTituloProfesor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgListaTitulos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAgregarTitulo = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtCodTitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTipoTitulo = new System.Windows.Forms.TextBox();
            this.txtInstitucion = new System.Windows.Forms.TextBox();
            this.txtNombreTitulo = new System.Windows.Forms.TextBox();
            this.txtCodigoProfesor = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTipoIdentificacion = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaTitulos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgListaTitulos);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(47, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(705, 722);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            // 
            // dgListaTitulos
            // 
            this.dgListaTitulos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgListaTitulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgListaTitulos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgListaTitulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgListaTitulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaTitulos.Location = new System.Drawing.Point(28, 548);
            this.dgListaTitulos.Margin = new System.Windows.Forms.Padding(4);
            this.dgListaTitulos.Name = "dgListaTitulos";
            this.dgListaTitulos.Size = new System.Drawing.Size(644, 150);
            this.dgListaTitulos.TabIndex = 70;
            this.dgListaTitulos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgListaTitulos_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.btnAgregarTitulo);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(27, 439);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(644, 78);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
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
            this.btnSalir.Location = new System.Drawing.Point(516, 20);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 46);
            this.btnSalir.TabIndex = 69;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificar.FlatAppearance.BorderSize = 2;
            this.btnModificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnModificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(375, 21);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(121, 46);
            this.btnModificar.TabIndex = 68;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.btnAgregar.Location = new System.Drawing.Point(268, 21);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 46);
            this.btnAgregar.TabIndex = 66;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAgregarTitulo
            // 
            this.btnAgregarTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarTitulo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarTitulo.FlatAppearance.BorderSize = 2;
            this.btnAgregarTitulo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnAgregarTitulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTitulo.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarTitulo.Location = new System.Drawing.Point(8, 20);
            this.btnAgregarTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarTitulo.Name = "btnAgregarTitulo";
            this.btnAgregarTitulo.Size = new System.Drawing.Size(240, 46);
            this.btnAgregarTitulo.TabIndex = 65;
            this.btnAgregarTitulo.Text = "Agregar a Profesor";
            this.btnAgregarTitulo.UseVisualStyleBackColor = false;
            this.btnAgregarTitulo.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.txtCodTitulo);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.txtTipoTitulo);
            this.groupBox.Controls.Add(this.txtInstitucion);
            this.groupBox.Controls.Add(this.txtNombreTitulo);
            this.groupBox.Controls.Add(this.txtCodigoProfesor);
            this.groupBox.Controls.Add(this.dtFecha);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.lbTipoIdentificacion);
            this.groupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Location = new System.Drawing.Point(27, 18);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(644, 414);
            this.groupBox.TabIndex = 69;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Datos Titulo";
            // 
            // txtCodTitulo
            // 
            this.txtCodTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCodTitulo.Enabled = false;
            this.txtCodTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodTitulo.ForeColor = System.Drawing.Color.Black;
            this.txtCodTitulo.Location = new System.Drawing.Point(224, 28);
            this.txtCodTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodTitulo.Name = "txtCodTitulo";
            this.txtCodTitulo.Size = new System.Drawing.Size(269, 30);
            this.txtCodTitulo.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(43, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 23);
            this.label5.TabIndex = 86;
            this.label5.Text = "Codigo Titulo";
            // 
            // txtTipoTitulo
            // 
            this.txtTipoTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTipoTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTipoTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoTitulo.ForeColor = System.Drawing.Color.Black;
            this.txtTipoTitulo.Location = new System.Drawing.Point(224, 351);
            this.txtTipoTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoTitulo.Name = "txtTipoTitulo";
            this.txtTipoTitulo.Size = new System.Drawing.Size(272, 30);
            this.txtTipoTitulo.TabIndex = 85;
            // 
            // txtInstitucion
            // 
            this.txtInstitucion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtInstitucion.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtInstitucion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstitucion.ForeColor = System.Drawing.Color.Black;
            this.txtInstitucion.Location = new System.Drawing.Point(224, 222);
            this.txtInstitucion.Margin = new System.Windows.Forms.Padding(4);
            this.txtInstitucion.Name = "txtInstitucion";
            this.txtInstitucion.Size = new System.Drawing.Size(272, 30);
            this.txtInstitucion.TabIndex = 84;
            // 
            // txtNombreTitulo
            // 
            this.txtNombreTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombreTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNombreTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTitulo.ForeColor = System.Drawing.Color.Black;
            this.txtNombreTitulo.Location = new System.Drawing.Point(224, 155);
            this.txtNombreTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreTitulo.Name = "txtNombreTitulo";
            this.txtNombreTitulo.Size = new System.Drawing.Size(272, 30);
            this.txtNombreTitulo.TabIndex = 83;
            // 
            // txtCodigoProfesor
            // 
            this.txtCodigoProfesor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigoProfesor.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCodigoProfesor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProfesor.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoProfesor.Location = new System.Drawing.Point(280, 91);
            this.txtCodigoProfesor.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoProfesor.Name = "txtCodigoProfesor";
            this.txtCodigoProfesor.Size = new System.Drawing.Size(216, 30);
            this.txtCodigoProfesor.TabIndex = 82;
            this.txtCodigoProfesor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoTitulo_KeyPress);
            // 
            // dtFecha
            // 
            this.dtFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(224, 286);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(269, 30);
            this.dtFecha.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(43, 361);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 80;
            this.label4.Text = "Tipo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 293);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 23);
            this.label3.TabIndex = 79;
            this.label3.Text = "Fecha Del Titulo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 78;
            this.label2.Text = "Institucion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 77;
            this.label1.Text = "Nombre:";
            // 
            // lbTipoIdentificacion
            // 
            this.lbTipoIdentificacion.AutoSize = true;
            this.lbTipoIdentificacion.BackColor = System.Drawing.Color.Transparent;
            this.lbTipoIdentificacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoIdentificacion.ForeColor = System.Drawing.Color.White;
            this.lbTipoIdentificacion.Location = new System.Drawing.Point(43, 98);
            this.lbTipoIdentificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTipoIdentificacion.Name = "lbTipoIdentificacion";
            this.lbTipoIdentificacion.Size = new System.Drawing.Size(212, 23);
            this.lbTipoIdentificacion.TabIndex = 76;
            this.lbTipoIdentificacion.Text = "Identificacion Profesor:";
            this.lbTipoIdentificacion.Click += new System.EventHandler(this.lbTipoIdentificacion_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // frmTituloProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(795, 761);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTituloProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTituloProfesor";
            this.Load += new System.EventHandler(this.frmTituloProfesor_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaTitulos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAgregarTitulo;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txtTipoTitulo;
        private System.Windows.Forms.TextBox txtInstitucion;
        private System.Windows.Forms.TextBox txtNombreTitulo;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTipoIdentificacion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgListaTitulos;
        private System.Windows.Forms.TextBox txtCodTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox txtCodigoProfesor;
    }
}