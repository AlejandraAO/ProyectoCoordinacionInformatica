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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCupoActual = new System.Windows.Forms.TextBox();
            this.txtCupoMinimo = new System.Windows.Forms.TextBox();
            this.txtCupoMaximo = new System.Windows.Forms.TextBox();
            this.txtNumeroGrupo = new System.Windows.Forms.TextBox();
            this.txtIdGrupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCupoMinimo = new System.Windows.Forms.Label();
            this.lbCupoMaximo = new System.Windows.Forms.Label();
            this.lbNumeroGrup = new System.Windows.Forms.Label();
            this.lbIdGrupo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(264, 7);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 25;
            this.btnConsultar.Text = "Consultar ";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(89, 140);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(8, 140);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCupoActual
            // 
            this.txtCupoActual.Location = new System.Drawing.Point(474, 41);
            this.txtCupoActual.Name = "txtCupoActual";
            this.txtCupoActual.Size = new System.Drawing.Size(146, 20);
            this.txtCupoActual.TabIndex = 22;
            // 
            // txtCupoMinimo
            // 
            this.txtCupoMinimo.Location = new System.Drawing.Point(474, 12);
            this.txtCupoMinimo.Name = "txtCupoMinimo";
            this.txtCupoMinimo.Size = new System.Drawing.Size(146, 20);
            this.txtCupoMinimo.TabIndex = 21;
            // 
            // txtCupoMaximo
            // 
            this.txtCupoMaximo.Location = new System.Drawing.Point(102, 81);
            this.txtCupoMaximo.Name = "txtCupoMaximo";
            this.txtCupoMaximo.Size = new System.Drawing.Size(146, 20);
            this.txtCupoMaximo.TabIndex = 20;
            // 
            // txtNumeroGrupo
            // 
            this.txtNumeroGrupo.Location = new System.Drawing.Point(102, 45);
            this.txtNumeroGrupo.Name = "txtNumeroGrupo";
            this.txtNumeroGrupo.Size = new System.Drawing.Size(146, 20);
            this.txtNumeroGrupo.TabIndex = 19;
            // 
            // txtIdGrupo
            // 
            this.txtIdGrupo.Location = new System.Drawing.Point(102, 9);
            this.txtIdGrupo.Name = "txtIdGrupo";
            this.txtIdGrupo.Size = new System.Drawing.Size(146, 20);
            this.txtIdGrupo.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AccessibleName = "lbCupoActual";
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cupo Actual";
            // 
            // lbCupoMinimo
            // 
            this.lbCupoMinimo.AutoSize = true;
            this.lbCupoMinimo.Location = new System.Drawing.Point(384, 12);
            this.lbCupoMinimo.Name = "lbCupoMinimo";
            this.lbCupoMinimo.Size = new System.Drawing.Size(68, 13);
            this.lbCupoMinimo.TabIndex = 16;
            this.lbCupoMinimo.Text = "Cupo Minimo";
            // 
            // lbCupoMaximo
            // 
            this.lbCupoMaximo.AutoSize = true;
            this.lbCupoMaximo.Location = new System.Drawing.Point(12, 84);
            this.lbCupoMaximo.Name = "lbCupoMaximo";
            this.lbCupoMaximo.Size = new System.Drawing.Size(71, 13);
            this.lbCupoMaximo.TabIndex = 15;
            this.lbCupoMaximo.Text = "Cupo Maximo";
            // 
            // lbNumeroGrup
            // 
            this.lbNumeroGrup.AutoSize = true;
            this.lbNumeroGrup.Location = new System.Drawing.Point(12, 45);
            this.lbNumeroGrup.Name = "lbNumeroGrup";
            this.lbNumeroGrup.Size = new System.Drawing.Size(76, 13);
            this.lbNumeroGrup.TabIndex = 14;
            this.lbNumeroGrup.Text = "Numero Grupo";
            // 
            // lbIdGrupo
            // 
            this.lbIdGrupo.AutoSize = true;
            this.lbIdGrupo.Location = new System.Drawing.Point(12, 9);
            this.lbIdGrupo.Name = "lbIdGrupo";
            this.lbIdGrupo.Size = new System.Drawing.Size(44, 13);
            this.lbIdGrupo.TabIndex = 13;
            this.lbIdGrupo.Text = "idGrupo";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(639, 130);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmGrupoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 190);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCupoActual);
            this.Controls.Add(this.txtCupoMinimo);
            this.Controls.Add(this.txtCupoMaximo);
            this.Controls.Add(this.txtNumeroGrupo);
            this.Controls.Add(this.txtIdGrupo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCupoMinimo);
            this.Controls.Add(this.lbCupoMaximo);
            this.Controls.Add(this.lbNumeroGrup);
            this.Controls.Add(this.lbIdGrupo);
            this.Name = "frmGrupoCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGrupoCurso";
            this.Load += new System.EventHandler(this.frmGrupoCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCupoActual;
        private System.Windows.Forms.TextBox txtCupoMinimo;
        private System.Windows.Forms.TextBox txtCupoMaximo;
        private System.Windows.Forms.TextBox txtNumeroGrupo;
        private System.Windows.Forms.TextBox txtIdGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCupoMinimo;
        private System.Windows.Forms.Label lbCupoMaximo;
        private System.Windows.Forms.Label lbNumeroGrup;
        private System.Windows.Forms.Label lbIdGrupo;
        private System.Windows.Forms.Button btnSalir;
    }
}