namespace Vista
{
    partial class frmConsultaRapidaMiembro
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
            this.lvConsultaMiembro = new System.Windows.Forms.ListView();
            this.carne = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvConsultaMiembro
            // 
            this.lvConsultaMiembro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvConsultaMiembro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.carne,
            this.nombre});
            this.lvConsultaMiembro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvConsultaMiembro.ForeColor = System.Drawing.Color.Black;
            this.lvConsultaMiembro.GridLines = true;
            listViewItem2.Tag = "asdasdasd";
            this.lvConsultaMiembro.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvConsultaMiembro.Location = new System.Drawing.Point(7, 12);
            this.lvConsultaMiembro.Name = "lvConsultaMiembro";
            this.lvConsultaMiembro.Size = new System.Drawing.Size(270, 274);
            this.lvConsultaMiembro.TabIndex = 30;
            this.lvConsultaMiembro.UseCompatibleStateImageBehavior = false;
            this.lvConsultaMiembro.View = System.Windows.Forms.View.Details;
            this.lvConsultaMiembro.SelectedIndexChanged += new System.EventHandler(this.lvConsultaMiembro_SelectedIndexChanged);
            this.lvConsultaMiembro.DoubleClick += new System.EventHandler(this.lvConsultaMiembro_DoubleClick);
            // 
            // carne
            // 
            this.carne.Text = "Carné";
            this.carne.Width = 72;
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
            this.btnSalir.Location = new System.Drawing.Point(195, 292);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 37);
            this.btnSalir.TabIndex = 31;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmConsultaRapidaMiembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(284, 335);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvConsultaMiembro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaRapidaMiembro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Miembro";
            this.Load += new System.EventHandler(this.frmConsultaRapidaMiembro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvConsultaMiembro;
        private System.Windows.Forms.ColumnHeader carne;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.Button btnSalir;
    }
}