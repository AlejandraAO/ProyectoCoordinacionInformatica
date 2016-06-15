namespace ProyectoCoordinacion
{
    partial class fmrGestionCursosLibres
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrGestionCursosLibres));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbConsultarPor = new System.Windows.Forms.ComboBox();
            this.lbConsultarPor = new System.Windows.Forms.Label();
            this.txtDatoConsulta = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.GridLines = true;
            listViewItem2.Tag = "asdasdasd";
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(15, 75);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(761, 272);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 30;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "apellido";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 154;
            // 
            // cbConsultarPor
            // 
            this.cbConsultarPor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbConsultarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConsultarPor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConsultarPor.ForeColor = System.Drawing.Color.Black;
            this.cbConsultarPor.FormattingEnabled = true;
            this.cbConsultarPor.Items.AddRange(new object[] {
            "Nombre",
            "Sigla",
            "Ciclo"});
            this.cbConsultarPor.Location = new System.Drawing.Point(15, 30);
            this.cbConsultarPor.Name = "cbConsultarPor";
            this.cbConsultarPor.Size = new System.Drawing.Size(121, 25);
            this.cbConsultarPor.TabIndex = 32;
            // 
            // lbConsultarPor
            // 
            this.lbConsultarPor.AutoSize = true;
            this.lbConsultarPor.BackColor = System.Drawing.Color.Transparent;
            this.lbConsultarPor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultarPor.ForeColor = System.Drawing.Color.White;
            this.lbConsultarPor.Location = new System.Drawing.Point(12, 9);
            this.lbConsultarPor.Name = "lbConsultarPor";
            this.lbConsultarPor.Size = new System.Drawing.Size(105, 18);
            this.lbConsultarPor.TabIndex = 31;
            this.lbConsultarPor.Text = "Consultar por:";
            // 
            // txtDatoConsulta
            // 
            this.txtDatoConsulta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDatoConsulta.Enabled = false;
            this.txtDatoConsulta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatoConsulta.ForeColor = System.Drawing.Color.Black;
            this.txtDatoConsulta.Location = new System.Drawing.Point(190, 29);
            this.txtDatoConsulta.Name = "txtDatoConsulta";
            this.txtDatoConsulta.Size = new System.Drawing.Size(183, 26);
            this.txtDatoConsulta.TabIndex = 34;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "splash.png");
            // 
            // fmrGestionCursosLibres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 352);
            this.Controls.Add(this.txtDatoConsulta);
            this.Controls.Add(this.cbConsultarPor);
            this.Controls.Add(this.lbConsultarPor);
            this.Controls.Add(this.listView1);
            this.DoubleBuffered = true;
            this.Name = "fmrGestionCursosLibres";
            this.Text = "fmrGestionCursosLibres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cbConsultarPor;
        private System.Windows.Forms.Label lbConsultarPor;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtDatoConsulta;
    }
}