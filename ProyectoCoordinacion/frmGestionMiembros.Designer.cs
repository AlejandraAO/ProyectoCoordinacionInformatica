namespace Vista
{
    partial class frmGestionMiembros
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lblNumProyAsignados = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.btnBuscarProyecto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.lblNumProyAsignados);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.txtCarnet);
            this.groupBox.Controls.Add(this.btnBuscarProyecto);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.lbTipo);
            this.groupBox.Controls.Add(this.txtTipo);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.txtCarrera);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.txtApellido2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.txtApellido1);
            this.groupBox.Controls.Add(this.txt);
            this.groupBox.Controls.Add(this.txtNombre);
            this.groupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Location = new System.Drawing.Point(49, 37);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(622, 270);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Información Miembros ";
            // 
            // lblNumProyAsignados
            // 
            this.lblNumProyAsignados.AutoSize = true;
            this.lblNumProyAsignados.Location = new System.Drawing.Point(369, 239);
            this.lblNumProyAsignados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumProyAsignados.MaximumSize = new System.Drawing.Size(300, 24);
            this.lblNumProyAsignados.Name = "lblNumProyAsignados";
            this.lblNumProyAsignados.Size = new System.Drawing.Size(0, 18);
            this.lblNumProyAsignados.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 45;
            this.label5.Text = "Carnet:";
            // 
            // txtCarnet
            // 
            this.txtCarnet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCarnet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnet.ForeColor = System.Drawing.Color.Black;
            this.txtCarnet.Location = new System.Drawing.Point(108, 42);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(128, 26);
            this.txtCarnet.TabIndex = 0;
            this.txtCarnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarnet_KeyPress);
            // 
            // btnBuscarProyecto
            // 
            this.btnBuscarProyecto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarProyecto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarProyecto.FlatAppearance.BorderSize = 2;
            this.btnBuscarProyecto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnBuscarProyecto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBuscarProyecto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProyecto.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProyecto.Location = new System.Drawing.Point(388, 180);
            this.btnBuscarProyecto.Name = "btnBuscarProyecto";
            this.btnBuscarProyecto.Size = new System.Drawing.Size(161, 38);
            this.btnBuscarProyecto.TabIndex = 7;
            this.btnBuscarProyecto.Text = "Asignar a Proyectos";
            this.btnBuscarProyecto.UseVisualStyleBackColor = false;
            this.btnBuscarProyecto.Click += new System.EventHandler(this.btnBuscarProyecto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(298, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Proyecto:";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.BackColor = System.Drawing.Color.Transparent;
            this.lbTipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.ForeColor = System.Drawing.Color.White;
            this.lbTipo.Location = new System.Drawing.Point(306, 104);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(42, 18);
            this.lbTipo.TabIndex = 36;
            this.lbTipo.Text = "Tipo:";
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.ForeColor = System.Drawing.Color.Black;
            this.txtTipo.Location = new System.Drawing.Point(396, 101);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(128, 26);
            this.txtTipo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(306, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "Carrera:";
            // 
            // txtCarrera
            // 
            this.txtCarrera.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCarrera.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarrera.ForeColor = System.Drawing.Color.Black;
            this.txtCarrera.Location = new System.Drawing.Point(396, 37);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(128, 26);
            this.txtCarrera.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Apellido 2:";
            // 
            // txtApellido2
            // 
            this.txtApellido2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellido2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.ForeColor = System.Drawing.Color.Black;
            this.txtApellido2.Location = new System.Drawing.Point(108, 219);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(128, 26);
            this.txtApellido2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Apellido 1:";
            // 
            // txtApellido1
            // 
            this.txtApellido1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellido1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.ForeColor = System.Drawing.Color.Black;
            this.txtApellido1.Location = new System.Drawing.Point(108, 158);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(128, 26);
            this.txtApellido1.TabIndex = 2;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.BackColor = System.Drawing.Color.Transparent;
            this.txt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.Color.White;
            this.txt.Location = new System.Drawing.Point(18, 106);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(68, 18);
            this.txt.TabIndex = 28;
            this.txt.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(108, 99);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 26);
            this.txtNombre.TabIndex = 1;
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
            this.btnAgregar.Location = new System.Drawing.Point(105, 344);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(77, 37);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.btnSalir.Location = new System.Drawing.Point(539, 344);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 37);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(395, 344);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(77, 37);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(249, 344);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(82, 37);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmGestionMiembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnAgregar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGestionMiembros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Miembros";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarProyecto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.Label lblNumProyAsignados;
    }
}