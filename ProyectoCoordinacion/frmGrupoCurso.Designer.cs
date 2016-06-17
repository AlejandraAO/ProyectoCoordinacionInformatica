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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(474, 41);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(146, 20);
            this.textBox5.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(474, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(146, 20);
            this.textBox4.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(102, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 20);
            this.textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 18;
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
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCupoMinimo;
        private System.Windows.Forms.Label lbCupoMaximo;
        private System.Windows.Forms.Label lbNumeroGrup;
        private System.Windows.Forms.Label lbIdGrupo;
        private System.Windows.Forms.Button btnSalir;
    }
}