namespace Vista
{
    partial class frmConsultaRapProyecto
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.lvProyecto = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(278, 441);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lvProyecto
            // 
            this.lvProyecto.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvProyecto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.nombre});
            this.lvProyecto.FullRowSelect = true;
            this.lvProyecto.GridLines = true;
            this.lvProyecto.Location = new System.Drawing.Point(28, 44);
            this.lvProyecto.Name = "lvProyecto";
            this.lvProyecto.Size = new System.Drawing.Size(347, 363);
            this.lvProyecto.TabIndex = 3;
            this.lvProyecto.UseCompatibleStateImageBehavior = false;
            this.lvProyecto.View = System.Windows.Forms.View.Details;
            this.lvProyecto.SelectedIndexChanged += new System.EventHandler(this.lvProyecto_SelectedIndexChanged);
            this.lvProyecto.DoubleClick += new System.EventHandler(this.btnSalir_Click);
            // 
            // codigo
            // 
            this.codigo.Text = "Codigo";
            this.codigo.Width = 142;
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            this.nombre.Width = 201;
            // 
            // frmConsultaRapProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 502);
            this.Controls.Add(this.lvProyecto);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmConsultaRapProyecto";
            this.Text = "frmConsultaRapProyecto";
            this.Load += new System.EventHandler(this.frmConsultaRapProyecto_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListView lvProyecto;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader nombre;
    }
}