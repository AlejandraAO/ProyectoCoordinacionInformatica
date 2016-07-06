namespace Vista
{
    partial class frmConsultaCorreo
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
            this.lvCorreos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvCorreos
            // 
            this.lvCorreos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvCorreos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvCorreos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCorreos.ForeColor = System.Drawing.Color.Black;
            this.lvCorreos.GridLines = true;
            listViewItem4.Tag = "asdasdasd";
            this.lvCorreos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.lvCorreos.Location = new System.Drawing.Point(12, 12);
            this.lvCorreos.Name = "lvCorreos";
            this.lvCorreos.Size = new System.Drawing.Size(260, 164);
            this.lvCorreos.TabIndex = 31;
            this.lvCorreos.UseCompatibleStateImageBehavior = false;
            this.lvCorreos.View = System.Windows.Forms.View.Details;
            this.lvCorreos.SelectedIndexChanged += new System.EventHandler(this.lvCorreos_SelectedIndexChanged);
            this.lvCorreos.DoubleClick += new System.EventHandler(this.lvCorreos_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Correos";
            this.columnHeader2.Width = 154;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCerrar.FlatAppearance.BorderSize = 2;
            this.btnCerrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Location = new System.Drawing.Point(195, 212);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(77, 37);
            this.btnCerrar.TabIndex = 32;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmConsultaCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lvCorreos);
            this.DoubleBuffered = true;
            this.Name = "frmConsultaCorreo";
            this.Text = "frmConsultaCorreo";
            this.Load += new System.EventHandler(this.frmConsultaCorreo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvCorreos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnCerrar;
    }
}