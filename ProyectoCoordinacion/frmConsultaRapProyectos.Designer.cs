namespace Vista
{
    partial class frmConsultaRapProyectos
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
            this.lvProyecto = new System.Windows.Forms.ListView();
            this.idProyecto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombreProyecto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvProyecto
            // 
            this.lvProyecto.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvProyecto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idProyecto,
            this.nombreProyecto});
            this.lvProyecto.FullRowSelect = true;
            this.lvProyecto.GridLines = true;
            this.lvProyecto.Location = new System.Drawing.Point(30, 37);
            this.lvProyecto.Name = "lvProyecto";
            this.lvProyecto.Size = new System.Drawing.Size(310, 355);
            this.lvProyecto.TabIndex = 0;
            this.lvProyecto.UseCompatibleStateImageBehavior = false;
            this.lvProyecto.View = System.Windows.Forms.View.Details;
            this.lvProyecto.SelectedIndexChanged += new System.EventHandler(this.lvProyectos_SelectedIndexChanged);
            this.lvProyecto.DoubleClick += new System.EventHandler(this.btnSalir_Click);
            // 
            // idProyecto
            // 
            this.idProyecto.Text = "Codigo";
            this.idProyecto.Width = 135;
            // 
            // nombreProyecto
            // 
            this.nombreProyecto.Text = "Proyecto";
            this.nombreProyecto.Width = 169;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(220, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmConsultaRapProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 473);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvProyecto);
            this.Name = "frmConsultaRapProyectos";
            this.Text = "frmConsultaRapProyectos";
            this.Load += new System.EventHandler(this.frmConsultaRapProyectos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProyecto;
        private System.Windows.Forms.ColumnHeader idProyecto;
        private System.Windows.Forms.ColumnHeader nombreProyecto;
        private System.Windows.Forms.Button btnSalir;
    }
}