using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCoordinacion
{
    public partial class frmGestionCursoLibre : Form
    {
        private GroupBox groupBox;
        private Label lbNombre;
        private Label lbLugar;
        private TextBox txtLugar;
        private Label lbEstado;
        private ComboBox cbEstado;
        private NumericUpDown numCupo;
        private Label lbCupo;
        private Label lbDescripcion;
        private RichTextBox rtDescripcion;
        private ComboBox cbProfesor;
        private Label lbProfesor;
        private Label lbPrograma;
        private Button btnExaminar;
        private Label lbNombrePrograma;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnSalir;
        private TextBox txtNombre;

        public frmGestionCursoLibre()
        {
            InitializeComponent();
        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }
        // Este metodo se encargara de verificar que los TextBox no esten vacios en el momento de ingresar un Curso Libre
        #region Metodo verifica Espacios

        public Boolean mVerificarTextBox(Form interfaz)
        {
            Boolean exitoso = true;
            foreach (Control componente in interfaz.Controls)
            {
                // Verica el componente  es un TextBox, si es uno , entonces comprueba si esta vacio y si se cumple returna false
                if(componente is TextBox && componente.Text.Trim().Equals(""))
                {
                    return false;
                }// fin del if
                // Verifa si es un Group Box y lo recorre
               else if(componente is GroupBox)
                {
                    // Verica si el subComponente es un TextBox, si es uno , entonces comprueba si esta vacio y si se cumple returna false
                    foreach (Control subComponente in componente.Controls)
                    {
                        if(subComponente is TextBox && subComponente.Text.Trim().Equals("")) 
                        {
                            return false;
                        }
                    }// fin del foreach
                }    //fin del else        
            }// fin del foreach que recorre la ventana
            return exitoso;

        }
        #endregion

        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.lbLugar = new System.Windows.Forms.Label();
            this.numCupo = new System.Windows.Forms.NumericUpDown();
            this.lbCupo = new System.Windows.Forms.Label();
            this.rtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.lbPrograma = new System.Windows.Forms.Label();
            this.lbProfesor = new System.Windows.Forms.Label();
            this.cbProfesor = new System.Windows.Forms.ComboBox();
            this.lbNombrePrograma = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCupo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(120, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 26);
            this.txtNombre.TabIndex = 22;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.lbNombrePrograma);
            this.groupBox.Controls.Add(this.cbProfesor);
            this.groupBox.Controls.Add(this.lbProfesor);
            this.groupBox.Controls.Add(this.lbPrograma);
            this.groupBox.Controls.Add(this.btnExaminar);
            this.groupBox.Controls.Add(this.lbDescripcion);
            this.groupBox.Controls.Add(this.rtDescripcion);
            this.groupBox.Controls.Add(this.lbCupo);
            this.groupBox.Controls.Add(this.numCupo);
            this.groupBox.Controls.Add(this.lbLugar);
            this.groupBox.Controls.Add(this.txtLugar);
            this.groupBox.Controls.Add(this.lbEstado);
            this.groupBox.Controls.Add(this.cbEstado);
            this.groupBox.Controls.Add(this.lbNombre);
            this.groupBox.Controls.Add(this.txtNombre);
            this.groupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Location = new System.Drawing.Point(37, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(766, 268);
            this.groupBox.TabIndex = 27;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Gestion Cursos Libres";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.White;
            this.lbNombre.Location = new System.Drawing.Point(15, 44);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(64, 18);
            this.lbNombre.TabIndex = 28;
            this.lbNombre.Text = "Nombre";
            this.lbNombre.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEstado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.ForeColor = System.Drawing.Color.Black;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(478, 39);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(145, 25);
            this.cbEstado.TabIndex = 29;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.BackColor = System.Drawing.Color.Transparent;
            this.lbEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.ForeColor = System.Drawing.Color.White;
            this.lbEstado.Location = new System.Drawing.Point(375, 41);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(58, 18);
            this.lbEstado.TabIndex = 30;
            this.lbEstado.Text = "Estado";
            // 
            // txtLugar
            // 
            this.txtLugar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLugar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugar.ForeColor = System.Drawing.Color.Black;
            this.txtLugar.Location = new System.Drawing.Point(120, 174);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(155, 26);
            this.txtLugar.TabIndex = 31;
            // 
            // lbLugar
            // 
            this.lbLugar.AutoSize = true;
            this.lbLugar.BackColor = System.Drawing.Color.Transparent;
            this.lbLugar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLugar.ForeColor = System.Drawing.Color.White;
            this.lbLugar.Location = new System.Drawing.Point(15, 177);
            this.lbLugar.Name = "lbLugar";
            this.lbLugar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbLugar.Size = new System.Drawing.Size(48, 18);
            this.lbLugar.TabIndex = 32;
            this.lbLugar.Text = "Lugar";
            // 
            // numCupo
            // 
            this.numCupo.Location = new System.Drawing.Point(120, 238);
            this.numCupo.Name = "numCupo";
            this.numCupo.Size = new System.Drawing.Size(155, 26);
            this.numCupo.TabIndex = 33;
            // 
            // lbCupo
            // 
            this.lbCupo.AutoSize = true;
            this.lbCupo.BackColor = System.Drawing.Color.Transparent;
            this.lbCupo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCupo.ForeColor = System.Drawing.Color.White;
            this.lbCupo.Location = new System.Drawing.Point(15, 240);
            this.lbCupo.Name = "lbCupo";
            this.lbCupo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbCupo.Size = new System.Drawing.Size(46, 18);
            this.lbCupo.TabIndex = 34;
            this.lbCupo.Text = "Cupo";
            // 
            // rtDescripcion
            // 
            this.rtDescripcion.Location = new System.Drawing.Point(473, 171);
            this.rtDescripcion.Name = "rtDescripcion";
            this.rtDescripcion.Size = new System.Drawing.Size(150, 60);
            this.rtDescripcion.TabIndex = 35;
            this.rtDescripcion.Text = "";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.ForeColor = System.Drawing.Color.White;
            this.lbDescripcion.Location = new System.Drawing.Point(375, 174);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbDescripcion.Size = new System.Drawing.Size(92, 18);
            this.lbDescripcion.TabIndex = 36;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExaminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExaminar.FlatAppearance.BorderSize = 2;
            this.btnExaminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnExaminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExaminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.ForeColor = System.Drawing.Color.Black;
            this.btnExaminar.Location = new System.Drawing.Point(473, 100);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(145, 27);
            this.btnExaminar.TabIndex = 37;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = false;
            // 
            // lbPrograma
            // 
            this.lbPrograma.AutoSize = true;
            this.lbPrograma.BackColor = System.Drawing.Color.Transparent;
            this.lbPrograma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrograma.ForeColor = System.Drawing.Color.White;
            this.lbPrograma.Location = new System.Drawing.Point(375, 104);
            this.lbPrograma.Name = "lbPrograma";
            this.lbPrograma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPrograma.Size = new System.Drawing.Size(78, 18);
            this.lbPrograma.TabIndex = 38;
            this.lbPrograma.Text = "Programa";
            // 
            // lbProfesor
            // 
            this.lbProfesor.AutoSize = true;
            this.lbProfesor.BackColor = System.Drawing.Color.Transparent;
            this.lbProfesor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfesor.ForeColor = System.Drawing.Color.White;
            this.lbProfesor.Location = new System.Drawing.Point(15, 114);
            this.lbProfesor.Name = "lbProfesor";
            this.lbProfesor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbProfesor.Size = new System.Drawing.Size(68, 18);
            this.lbProfesor.TabIndex = 39;
            this.lbProfesor.Text = "Profesor";
            // 
            // cbProfesor
            // 
            this.cbProfesor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbProfesor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProfesor.ForeColor = System.Drawing.Color.Black;
            this.cbProfesor.FormattingEnabled = true;
            this.cbProfesor.Location = new System.Drawing.Point(120, 107);
            this.cbProfesor.Name = "cbProfesor";
            this.cbProfesor.Size = new System.Drawing.Size(155, 25);
            this.cbProfesor.TabIndex = 40;
            // 
            // lbNombrePrograma
            // 
            this.lbNombrePrograma.AutoSize = true;
            this.lbNombrePrograma.BackColor = System.Drawing.Color.Transparent;
            this.lbNombrePrograma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePrograma.ForeColor = System.Drawing.Color.White;
            this.lbNombrePrograma.Location = new System.Drawing.Point(623, 104);
            this.lbNombrePrograma.Name = "lbNombrePrograma";
            this.lbNombrePrograma.Size = new System.Drawing.Size(143, 18);
            this.lbNombrePrograma.TabIndex = 52;
            this.lbNombrePrograma.Text = "Nombre del archivo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(12, 297);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 37);
            this.btnAgregar.TabIndex = 60;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificar.FlatAppearance.BorderSize = 2;
            this.btnModificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnModificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(137, 297);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(124, 37);
            this.btnModificar.TabIndex = 61;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
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
            this.btnSalir.Location = new System.Drawing.Point(706, 297);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 37);
            this.btnSalir.TabIndex = 62;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmGestionCursoLibre
            // 
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 384);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionCursoLibre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmGestionCursoLibre_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCupo)).EndInit();
            this.ResumeLayout(false);

        }

        private void frmGestionCursoLibre_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
