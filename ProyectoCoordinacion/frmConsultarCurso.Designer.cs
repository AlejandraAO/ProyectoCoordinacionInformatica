namespace Vista
{
    partial class frmConsultarCurso
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.lbConsultarPor = new System.Windows.Forms.Label();
            this.cbConsultarPor = new System.Windows.Forms.ComboBox();
            this.lvDetalleCursos = new System.Windows.Forms.ListView();
            this.sigla = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lugar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ciclo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.creditos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalHoras = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modalidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtDatoConsulta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbConsultarPor
            // 
            this.lbConsultarPor.AutoSize = true;
            this.lbConsultarPor.BackColor = System.Drawing.Color.Transparent;
            this.lbConsultarPor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultarPor.ForeColor = System.Drawing.Color.White;
            this.lbConsultarPor.Location = new System.Drawing.Point(29, 19);
            this.lbConsultarPor.Name = "lbConsultarPor";
            this.lbConsultarPor.Size = new System.Drawing.Size(105, 18);
            this.lbConsultarPor.TabIndex = 23;
            this.lbConsultarPor.Text = "Consultar por:";
            // 
            // cbConsultarPor
            // 
            this.cbConsultarPor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbConsultarPor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConsultarPor.ForeColor = System.Drawing.Color.Black;
            this.cbConsultarPor.FormattingEnabled = true;
            this.cbConsultarPor.Items.AddRange(new object[] {
            "Nombre",
            "Sigla",
            "Ciclo"});
            this.cbConsultarPor.Location = new System.Drawing.Point(32, 40);
            this.cbConsultarPor.Name = "cbConsultarPor";
            this.cbConsultarPor.Size = new System.Drawing.Size(121, 25);
            this.cbConsultarPor.TabIndex = 29;
            // 
            // lvDetalleCursos
            // 
            this.lvDetalleCursos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvDetalleCursos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sigla,
            this.nombre,
            this.lugar,
            this.ciclo,
            this.creditos,
            this.estado,
            this.totalHoras,
            this.modalidad});
            this.lvDetalleCursos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDetalleCursos.ForeColor = System.Drawing.Color.Black;
            this.lvDetalleCursos.GridLines = true;
            listViewItem4.Tag = "asdasdasd";
            this.lvDetalleCursos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.lvDetalleCursos.Location = new System.Drawing.Point(12, 114);
            this.lvDetalleCursos.Name = "lvDetalleCursos";
            this.lvDetalleCursos.Size = new System.Drawing.Size(927, 433);
            this.lvDetalleCursos.TabIndex = 30;
            this.lvDetalleCursos.UseCompatibleStateImageBehavior = false;
            this.lvDetalleCursos.View = System.Windows.Forms.View.Details;
            // 
            // sigla
            // 
            this.sigla.Text = "Sigla";
            this.sigla.Width = 72;
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            this.nombre.Width = 285;
            // 
            // lugar
            // 
            this.lugar.Text = "Lugar";
            this.lugar.Width = 109;
            // 
            // ciclo
            // 
            this.ciclo.Text = "Ciclo";
            // 
            // creditos
            // 
            this.creditos.Text = "Créditos";
            this.creditos.Width = 63;
            // 
            // estado
            // 
            this.estado.Text = "Estado";
            this.estado.Width = 120;
            // 
            // totalHoras
            // 
            this.totalHoras.Text = "Total de Horas";
            this.totalHoras.Width = 99;
            // 
            // modalidad
            // 
            this.modalidad.Text = "Modalidad";
            this.modalidad.Width = 114;
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
            this.btnSalir.Location = new System.Drawing.Point(889, 553);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 37);
            this.btnSalir.TabIndex = 31;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.btnConsultar.Location = new System.Drawing.Point(862, 40);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(86, 37);
            this.btnConsultar.TabIndex = 32;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtDatoConsulta
            // 
            this.txtDatoConsulta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDatoConsulta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatoConsulta.ForeColor = System.Drawing.Color.Black;
            this.txtDatoConsulta.Location = new System.Drawing.Point(691, 46);
            this.txtDatoConsulta.Name = "txtDatoConsulta";
            this.txtDatoConsulta.Size = new System.Drawing.Size(128, 26);
            this.txtDatoConsulta.TabIndex = 33;
            // 
            // frmConsultarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 602);
            this.Controls.Add(this.txtDatoConsulta);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvDetalleCursos);
            this.Controls.Add(this.cbConsultarPor);
            this.Controls.Add(this.lbConsultarPor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultarCurso";
            this.Load += new System.EventHandler(this.frmConsultarCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbConsultarPor;
        private System.Windows.Forms.ComboBox cbConsultarPor;
        private System.Windows.Forms.ListView lvDetalleCursos;
        private System.Windows.Forms.ColumnHeader sigla;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ColumnHeader lugar;
        private System.Windows.Forms.ColumnHeader ciclo;
        private System.Windows.Forms.ColumnHeader creditos;
        private System.Windows.Forms.ColumnHeader estado;
        private System.Windows.Forms.ColumnHeader totalHoras;
        private System.Windows.Forms.ColumnHeader modalidad;
        private System.Windows.Forms.TextBox txtDatoConsulta;
    }
}