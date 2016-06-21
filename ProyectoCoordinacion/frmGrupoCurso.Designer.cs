namespace Vista
{
    partial class frmGrupoCurso
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
            this.txtCupoActual = new System.Windows.Forms.TextBox();
            this.txtCupoMinimo = new System.Windows.Forms.TextBox();
            this.txtCupoMaximo = new System.Windows.Forms.TextBox();
            this.txtNumeroGrupo = new System.Windows.Forms.TextBox();
            this.txtIdGrupo = new System.Windows.Forms.TextBox();
            this.lbIdGrupo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbIdCurso = new System.Windows.Forms.Label();
            this.lbNumeroGrupo = new System.Windows.Forms.Label();
            this.lbCupoMaximo = new System.Windows.Forms.Label();
            this.lbCupoMinimo = new System.Windows.Forms.Label();
            this.lbCupoActual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCupoActual
            // 
            this.txtCupoActual.Location = new System.Drawing.Point(537, 61);
            this.txtCupoActual.Name = "txtCupoActual";
            this.txtCupoActual.Size = new System.Drawing.Size(146, 20);
            this.txtCupoActual.TabIndex = 22;
            // 
            // txtCupoMinimo
            // 
            this.txtCupoMinimo.Location = new System.Drawing.Point(537, 32);
            this.txtCupoMinimo.Name = "txtCupoMinimo";
            this.txtCupoMinimo.Size = new System.Drawing.Size(146, 20);
            this.txtCupoMinimo.TabIndex = 21;
            // 
            // txtCupoMaximo
            // 
            this.txtCupoMaximo.Location = new System.Drawing.Point(139, 109);
            this.txtCupoMaximo.Name = "txtCupoMaximo";
            this.txtCupoMaximo.Size = new System.Drawing.Size(146, 20);
            this.txtCupoMaximo.TabIndex = 20;
            // 
            // txtNumeroGrupo
            // 
            this.txtNumeroGrupo.Location = new System.Drawing.Point(139, 74);
            this.txtNumeroGrupo.Name = "txtNumeroGrupo";
            this.txtNumeroGrupo.Size = new System.Drawing.Size(146, 20);
            this.txtNumeroGrupo.TabIndex = 19;
            // 
            // txtIdGrupo
            // 
            this.txtIdGrupo.Location = new System.Drawing.Point(139, 36);
            this.txtIdGrupo.Name = "txtIdGrupo";
            this.txtIdGrupo.Size = new System.Drawing.Size(146, 20);
            this.txtIdGrupo.TabIndex = 18;
            // 
            // lbIdGrupo
            // 
            this.lbIdGrupo.AutoSize = true;
            this.lbIdGrupo.Location = new System.Drawing.Point(10, 34);
            this.lbIdGrupo.Name = "lbIdGrupo";
            this.lbIdGrupo.Size = new System.Drawing.Size(0, 13);
            this.lbIdGrupo.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(55, 436);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(77, 37);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
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
            this.btnModificar.Location = new System.Drawing.Point(158, 436);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(82, 37);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConsultar.FlatAppearance.BorderSize = 2;
            this.btnConsultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultar.Location = new System.Drawing.Point(321, 31);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(82, 37);
            this.btnConsultar.TabIndex = 29;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click_1);
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
            this.btnSalir.Location = new System.Drawing.Point(601, 447);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 37);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // lbIdCurso
            // 
            this.lbIdCurso.AutoSize = true;
            this.lbIdCurso.BackColor = System.Drawing.Color.Transparent;
            this.lbIdCurso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdCurso.ForeColor = System.Drawing.Color.White;
            this.lbIdCurso.Location = new System.Drawing.Point(16, 36);
            this.lbIdCurso.Name = "lbIdCurso";
            this.lbIdCurso.Size = new System.Drawing.Size(63, 18);
            this.lbIdCurso.TabIndex = 31;
            this.lbIdCurso.Text = "idCurso";
            // 
            // lbNumeroGrupo
            // 
            this.lbNumeroGrupo.AutoSize = true;
            this.lbNumeroGrupo.BackColor = System.Drawing.Color.Transparent;
            this.lbNumeroGrupo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroGrupo.ForeColor = System.Drawing.Color.White;
            this.lbNumeroGrupo.Location = new System.Drawing.Point(10, 76);
            this.lbNumeroGrupo.Name = "lbNumeroGrupo";
            this.lbNumeroGrupo.Size = new System.Drawing.Size(110, 18);
            this.lbNumeroGrupo.TabIndex = 32;
            this.lbNumeroGrupo.Text = "Numero Grupo";
            // 
            // lbCupoMaximo
            // 
            this.lbCupoMaximo.AutoSize = true;
            this.lbCupoMaximo.BackColor = System.Drawing.Color.Transparent;
            this.lbCupoMaximo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCupoMaximo.ForeColor = System.Drawing.Color.White;
            this.lbCupoMaximo.Location = new System.Drawing.Point(16, 108);
            this.lbCupoMaximo.Name = "lbCupoMaximo";
            this.lbCupoMaximo.Size = new System.Drawing.Size(105, 18);
            this.lbCupoMaximo.TabIndex = 33;
            this.lbCupoMaximo.Text = "Cupo Máximo";
            // 
            // lbCupoMinimo
            // 
            this.lbCupoMinimo.AutoSize = true;
            this.lbCupoMinimo.BackColor = System.Drawing.Color.Transparent;
            this.lbCupoMinimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCupoMinimo.ForeColor = System.Drawing.Color.White;
            this.lbCupoMinimo.Location = new System.Drawing.Point(426, 32);
            this.lbCupoMinimo.Name = "lbCupoMinimo";
            this.lbCupoMinimo.Size = new System.Drawing.Size(101, 18);
            this.lbCupoMinimo.TabIndex = 34;
            this.lbCupoMinimo.Text = "Cupo Minimo";
            // 
            // lbCupoActual
            // 
            this.lbCupoActual.AutoSize = true;
            this.lbCupoActual.BackColor = System.Drawing.Color.Transparent;
            this.lbCupoActual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCupoActual.ForeColor = System.Drawing.Color.White;
            this.lbCupoActual.Location = new System.Drawing.Point(426, 67);
            this.lbCupoActual.Name = "lbCupoActual";
            this.lbCupoActual.Size = new System.Drawing.Size(92, 18);
            this.lbCupoActual.TabIndex = 35;
            this.lbCupoActual.Text = "Cupo Actual";
            // 
            // frmGrupoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 477);
            this.ControlBox = false;
            this.Controls.Add(this.lbCupoActual);
            this.Controls.Add(this.lbCupoMinimo);
            this.Controls.Add(this.lbCupoMaximo);
            this.Controls.Add(this.lbNumeroGrupo);
            this.Controls.Add(this.lbIdCurso);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCupoActual);
            this.Controls.Add(this.txtCupoMinimo);
            this.Controls.Add(this.txtCupoMaximo);
            this.Controls.Add(this.txtNumeroGrupo);
            this.Controls.Add(this.txtIdGrupo);
            this.Controls.Add(this.lbIdGrupo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGrupoCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGrupoCurso";
            this.Load += new System.EventHandler(this.frmGrupoCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCupoActual;
        private System.Windows.Forms.TextBox txtCupoMinimo;
        private System.Windows.Forms.TextBox txtCupoMaximo;
        private System.Windows.Forms.TextBox txtNumeroGrupo;
        private System.Windows.Forms.TextBox txtIdGrupo;
        private System.Windows.Forms.Label lbIdGrupo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lbIdCurso;
        private System.Windows.Forms.Label lbNumeroGrupo;
        private System.Windows.Forms.Label lbCupoMaximo;
        private System.Windows.Forms.Label lbCupoMinimo;
        private System.Windows.Forms.Label lbCupoActual;
    }
}