namespace Vista
{
    partial class frmEspecialidaProfesorTitulo
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtCodigoProfesor = new System.Windows.Forms.TextBox();
            this.lbTipoIdentificacion = new System.Windows.Forms.Label();
            this.txtCodEsp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInstitucion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnSalirEspecialidaTitulo = new System.Windows.Forms.Button();
            this.btnModificarEsp = new System.Windows.Forms.Button();
            this.btnAgregarEsp = new System.Windows.Forms.Button();
            this.dgEspecialidadTitulo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEspecialidadAgregar = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEspecialidadTitulo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.txtCodigoProfesor);
            this.groupBox.Controls.Add(this.lbTipoIdentificacion);
            this.groupBox.Controls.Add(this.txtCodEsp);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.txtInstitucion);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.txtDescripcion);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.txtNombre);
            this.groupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Location = new System.Drawing.Point(67, 15);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(717, 350);
            this.groupBox.TabIndex = 30;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Especialidad por titulo Profesor";
            // 
            // txtCodigoProfesor
            // 
            this.txtCodigoProfesor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigoProfesor.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCodigoProfesor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProfesor.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoProfesor.Location = new System.Drawing.Point(313, 107);
            this.txtCodigoProfesor.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoProfesor.Name = "txtCodigoProfesor";
            this.txtCodigoProfesor.Size = new System.Drawing.Size(231, 30);
            this.txtCodigoProfesor.TabIndex = 1;
            this.txtCodigoProfesor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoProfesor_KeyPress);
            // 
            // lbTipoIdentificacion
            // 
            this.lbTipoIdentificacion.AutoSize = true;
            this.lbTipoIdentificacion.BackColor = System.Drawing.Color.Transparent;
            this.lbTipoIdentificacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoIdentificacion.ForeColor = System.Drawing.Color.White;
            this.lbTipoIdentificacion.Location = new System.Drawing.Point(77, 107);
            this.lbTipoIdentificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTipoIdentificacion.Name = "lbTipoIdentificacion";
            this.lbTipoIdentificacion.Size = new System.Drawing.Size(212, 23);
            this.lbTipoIdentificacion.TabIndex = 90;
            this.lbTipoIdentificacion.Text = "Identificacion Profesor:";
            // 
            // txtCodEsp
            // 
            this.txtCodEsp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodEsp.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCodEsp.Enabled = false;
            this.txtCodEsp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodEsp.ForeColor = System.Drawing.Color.Black;
            this.txtCodEsp.Location = new System.Drawing.Point(313, 41);
            this.txtCodEsp.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodEsp.Name = "txtCodEsp";
            this.txtCodEsp.Size = new System.Drawing.Size(231, 30);
            this.txtCodEsp.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(77, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 23);
            this.label5.TabIndex = 88;
            this.label5.Text = "Codigo Especilidad: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(77, 299);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Institucion:";
            // 
            // txtInstitucion
            // 
            this.txtInstitucion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtInstitucion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstitucion.ForeColor = System.Drawing.Color.Black;
            this.txtInstitucion.Location = new System.Drawing.Point(313, 299);
            this.txtInstitucion.Margin = new System.Windows.Forms.Padding(4);
            this.txtInstitucion.Name = "txtInstitucion";
            this.txtInstitucion.Size = new System.Drawing.Size(231, 30);
            this.txtInstitucion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(77, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(313, 238);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(231, 30);
            this.txtDescripcion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre: ";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(313, 172);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(231, 30);
            this.txtNombre.TabIndex = 1;
            // 
            // btnSalirEspecialidaTitulo
            // 
            this.btnSalirEspecialidaTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalirEspecialidaTitulo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalirEspecialidaTitulo.FlatAppearance.BorderSize = 2;
            this.btnSalirEspecialidaTitulo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnSalirEspecialidaTitulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalirEspecialidaTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirEspecialidaTitulo.ForeColor = System.Drawing.Color.Black;
            this.btnSalirEspecialidaTitulo.Location = new System.Drawing.Point(516, 47);
            this.btnSalirEspecialidaTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalirEspecialidaTitulo.Name = "btnSalirEspecialidaTitulo";
            this.btnSalirEspecialidaTitulo.Size = new System.Drawing.Size(113, 44);
            this.btnSalirEspecialidaTitulo.TabIndex = 7;
            this.btnSalirEspecialidaTitulo.Text = "Salir";
            this.btnSalirEspecialidaTitulo.UseVisualStyleBackColor = false;
            this.btnSalirEspecialidaTitulo.Click += new System.EventHandler(this.btnSalirEspecialidaTitulo_Click);
            // 
            // btnModificarEsp
            // 
            this.btnModificarEsp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarEsp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificarEsp.FlatAppearance.BorderSize = 2;
            this.btnModificarEsp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnModificarEsp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnModificarEsp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEsp.ForeColor = System.Drawing.Color.Black;
            this.btnModificarEsp.Location = new System.Drawing.Point(365, 47);
            this.btnModificarEsp.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarEsp.Name = "btnModificarEsp";
            this.btnModificarEsp.Size = new System.Drawing.Size(120, 44);
            this.btnModificarEsp.TabIndex = 6;
            this.btnModificarEsp.Text = "Modificar";
            this.btnModificarEsp.UseVisualStyleBackColor = false;
            this.btnModificarEsp.Click += new System.EventHandler(this.btnModificarEsp_Click);
            // 
            // btnAgregarEsp
            // 
            this.btnAgregarEsp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarEsp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarEsp.FlatAppearance.BorderSize = 2;
            this.btnAgregarEsp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnAgregarEsp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarEsp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEsp.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarEsp.Location = new System.Drawing.Point(242, 47);
            this.btnAgregarEsp.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarEsp.Name = "btnAgregarEsp";
            this.btnAgregarEsp.Size = new System.Drawing.Size(103, 44);
            this.btnAgregarEsp.TabIndex = 4;
            this.btnAgregarEsp.Text = "Agregar";
            this.btnAgregarEsp.UseVisualStyleBackColor = false;
            this.btnAgregarEsp.Click += new System.EventHandler(this.btnAgregarEsp_Click);
            // 
            // dgEspecialidadTitulo
            // 
            this.dgEspecialidadTitulo.AllowUserToOrderColumns = true;
            this.dgEspecialidadTitulo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgEspecialidadTitulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEspecialidadTitulo.Location = new System.Drawing.Point(55, 35);
            this.dgEspecialidadTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.dgEspecialidadTitulo.Name = "dgEspecialidadTitulo";
            this.dgEspecialidadTitulo.Size = new System.Drawing.Size(633, 225);
            this.dgEspecialidadTitulo.TabIndex = 32;
            this.dgEspecialidadTitulo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgEspecialidadTitulo_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgEspecialidadTitulo);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(59, 498);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(717, 283);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de especialidad por titulos";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnSalirEspecialidaTitulo);
            this.groupBox2.Controls.Add(this.btnModificarEsp);
            this.groupBox2.Controls.Add(this.btnEspecialidadAgregar);
            this.groupBox2.Controls.Add(this.btnAgregarEsp);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(67, 372);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(709, 119);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controles";
            // 
            // btnEspecialidadAgregar
            // 
            this.btnEspecialidadAgregar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEspecialidadAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEspecialidadAgregar.FlatAppearance.BorderSize = 2;
            this.btnEspecialidadAgregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnEspecialidadAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEspecialidadAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspecialidadAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnEspecialidadAgregar.Location = new System.Drawing.Point(8, 47);
            this.btnEspecialidadAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEspecialidadAgregar.Name = "btnEspecialidadAgregar";
            this.btnEspecialidadAgregar.Size = new System.Drawing.Size(212, 44);
            this.btnEspecialidadAgregar.TabIndex = 5;
            this.btnEspecialidadAgregar.Text = "Agregar a profesor";
            this.btnEspecialidadAgregar.UseVisualStyleBackColor = false;
            this.btnEspecialidadAgregar.Click += new System.EventHandler(this.btnEliminarEsp_Click);
            // 
            // frmEspecialidaProfesorTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(857, 802);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEspecialidaProfesorTitulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEspecialidaProfesorTitulo";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEspecialidadTitulo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnSalirEspecialidaTitulo;
        private System.Windows.Forms.Button btnModificarEsp;
        private System.Windows.Forms.Button btnAgregarEsp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInstitucion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dgEspecialidadTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodEsp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtCodigoProfesor;
        private System.Windows.Forms.Label lbTipoIdentificacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEspecialidadAgregar;
    }
}