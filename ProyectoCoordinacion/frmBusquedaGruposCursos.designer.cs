namespace Vista
{
    partial class frmBusquedaGruposCursos
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
            this.Proyectos = new System.Windows.Forms.GroupBox();
            this.dgCursos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbIndentificacion = new System.Windows.Forms.ComboBox();
            this.lbIdentificacion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCursosLibres = new System.Windows.Forms.RadioButton();
            this.rbGrupos = new System.Windows.Forms.RadioButton();
            this.rbCursos = new System.Windows.Forms.RadioButton();
            this.Proyectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCursos)).BeginInit();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Proyectos
            // 
            this.Proyectos.BackColor = System.Drawing.Color.Transparent;
            this.Proyectos.Controls.Add(this.dgCursos);
            this.Proyectos.Controls.Add(this.btnSalir);
            this.Proyectos.Controls.Add(this.groupBox);
            this.Proyectos.Controls.Add(this.groupBox1);
            this.Proyectos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proyectos.ForeColor = System.Drawing.Color.White;
            this.Proyectos.Location = new System.Drawing.Point(64, 34);
            this.Proyectos.Name = "Proyectos";
            this.Proyectos.Size = new System.Drawing.Size(680, 564);
            this.Proyectos.TabIndex = 34;
            this.Proyectos.TabStop = false;
            this.Proyectos.Text = "Busqueda De Cursos";
            // 
            // dgCursos
            // 
            this.dgCursos.AllowUserToOrderColumns = true;
            this.dgCursos.BackgroundColor = System.Drawing.Color.White;
            this.dgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCursos.Location = new System.Drawing.Point(29, 238);
            this.dgCursos.Name = "dgCursos";
            this.dgCursos.ReadOnly = true;
            this.dgCursos.RowHeadersVisible = false;
            this.dgCursos.Size = new System.Drawing.Size(617, 264);
            this.dgCursos.TabIndex = 33;
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
            this.btnSalir.Location = new System.Drawing.Point(569, 521);
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
            this.groupBox.Location = new System.Drawing.Point(29, 46);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(617, 71);
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
            // cbIndentificacion
            // 
            this.cbIndentificacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbIndentificacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIndentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIndentificacion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIndentificacion.ForeColor = System.Drawing.Color.Black;
            this.cbIndentificacion.FormattingEnabled = true;
            this.cbIndentificacion.Location = new System.Drawing.Point(227, 24);
            this.cbIndentificacion.Name = "cbIndentificacion";
            this.cbIndentificacion.Size = new System.Drawing.Size(121, 26);
            this.cbIndentificacion.TabIndex = 29;
            // 
            // lbIdentificacion
            // 
            this.lbIdentificacion.AutoSize = true;
            this.lbIdentificacion.BackColor = System.Drawing.Color.Transparent;
            this.lbIdentificacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdentificacion.ForeColor = System.Drawing.Color.White;
            this.lbIdentificacion.Location = new System.Drawing.Point(59, 28);
            this.lbIdentificacion.Name = "lbIdentificacion";
            this.lbIdentificacion.Size = new System.Drawing.Size(167, 18);
            this.lbIdentificacion.TabIndex = 28;
            this.lbIdentificacion.Text = "Identificación Profesor:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbCursosLibres);
            this.groupBox1.Controls.Add(this.rbGrupos);
            this.groupBox1.Controls.Add(this.rbCursos);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(29, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 77);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rbCursosLibres
            // 
            this.rbCursosLibres.AutoSize = true;
            this.rbCursosLibres.BackColor = System.Drawing.Color.Transparent;
            this.rbCursosLibres.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCursosLibres.ForeColor = System.Drawing.Color.White;
            this.rbCursosLibres.Location = new System.Drawing.Point(450, 25);
            this.rbCursosLibres.Name = "rbCursosLibres";
            this.rbCursosLibres.Size = new System.Drawing.Size(122, 21);
            this.rbCursosLibres.TabIndex = 34;
            this.rbCursosLibres.TabStop = true;
            this.rbCursosLibres.Text = "Cursos Libres.";
            this.rbCursosLibres.UseVisualStyleBackColor = false;
            // 
            // rbGrupos
            // 
            this.rbGrupos.AutoSize = true;
            this.rbGrupos.BackColor = System.Drawing.Color.Transparent;
            this.rbGrupos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGrupos.ForeColor = System.Drawing.Color.White;
            this.rbGrupos.Location = new System.Drawing.Point(240, 25);
            this.rbGrupos.Name = "rbGrupos";
            this.rbGrupos.Size = new System.Drawing.Size(78, 21);
            this.rbGrupos.TabIndex = 33;
            this.rbGrupos.TabStop = true;
            this.rbGrupos.Text = "Grupos.";
            this.rbGrupos.UseVisualStyleBackColor = false;
            // 
            // rbCursos
            // 
            this.rbCursos.AutoSize = true;
            this.rbCursos.BackColor = System.Drawing.Color.Transparent;
            this.rbCursos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCursos.ForeColor = System.Drawing.Color.White;
            this.rbCursos.Location = new System.Drawing.Point(40, 25);
            this.rbCursos.Name = "rbCursos";
            this.rbCursos.Size = new System.Drawing.Size(78, 21);
            this.rbCursos.TabIndex = 32;
            this.rbCursos.TabStop = true;
            this.rbCursos.Text = "Cursos.";
            this.rbCursos.UseVisualStyleBackColor = false;
            // 
            // frmBusquedaGruposCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 630);
            this.ControlBox = false;
            this.Controls.Add(this.Proyectos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBusquedaGruposCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBusquedaGruposCursos";
            this.Load += new System.EventHandler(this.frmBusquedaGruposCursos_Load);
            this.Proyectos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCursos)).EndInit();
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
        private System.Windows.Forms.RadioButton rbCursosLibres;
        private System.Windows.Forms.RadioButton rbGrupos;
        private System.Windows.Forms.RadioButton rbCursos;
        private System.Windows.Forms.DataGridView dgCursos;
    }
}