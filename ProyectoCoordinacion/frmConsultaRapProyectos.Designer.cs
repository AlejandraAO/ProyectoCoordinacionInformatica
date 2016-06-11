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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.lvProyecto = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvProyecto
            // 
            this.lvProyecto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvProyecto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nombre});
            this.lvProyecto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProyecto.ForeColor = System.Drawing.Color.Black;
            this.lvProyecto.GridLines = true;
            listViewItem2.Tag = "asdasdasd";
            this.lvProyecto.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvProyecto.Location = new System.Drawing.Point(7, 12);
            this.lvProyecto.Name = "lvProyecto";
            this.lvProyecto.Size = new System.Drawing.Size(270, 247);
            this.lvProyecto.TabIndex = 30;
            this.lvProyecto.UseCompatibleStateImageBehavior = false;
            this.lvProyecto.View = System.Windows.Forms.View.Details;
            this.lvProyecto.SelectedIndexChanged += new System.EventHandler(this.lvProyecto_SelectedIndexChanged);
            this.lvProyecto.DoubleClick += new System.EventHandler(this.lvProyecto_DoubleClick);
            // 
            // id
            // 
            this.id.Text = "IdProyecto";
            this.id.Width = 102;
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            this.nombre.Width = 154;
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
            this.btnSalir.Location = new System.Drawing.Point(195, 276);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 37);
            this.btnSalir.TabIndex = 32;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmConsultaRapProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(284, 325);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvProyecto);
            this.Name = "frmConsultaRapProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Proyecto";
            this.Load += new System.EventHandler(this.frmConsultaRapProyectos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProyecto;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.Button btnSalir;
    }
}