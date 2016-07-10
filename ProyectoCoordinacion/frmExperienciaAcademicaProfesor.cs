using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LogicaNegocios;
using AccesoDatos;
using System.Data.SqlClient;

namespace Vista
{
    public partial class frmExperienciaAcademicaProfesor : Form
    {
        clConexion conexion;
        SqlDataReader dtrProfesor, dtrExperienciaAcademicaProfesor;

        clProfesor logicaProfesor;
        clExperienciaAcademicaProfesor logicaExperienciaAcademicaProfesor;
        clEntidadExperienciaAcademica  entidadExperienciaAcademica;
        clEntidadExperienciasProfesor entidadExperienciasProfesor;

        public frmExperienciaAcademicaProfesor(clConexion conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
            logicaProfesor = new clProfesor();
            logicaExperienciaAcademicaProfesor = new clExperienciaAcademicaProfesor();
            
        }

        private void frmExperienciaAcademicaProfesor_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            this.cargarCombo();
        }

        public void cargarCombo()
        {
            dtrProfesor = logicaProfesor.mLlenarCombo(this.conexion);
            if (dtrProfesor != null)
            {
                while (dtrProfesor.Read())
                {
                    String indentificacion = dtrProfesor.GetString(0).Trim();
                    cbIndentifica.Items.Add(indentificacion);
                }
            }
        }

        private void btnSalirEspecialidaTitulo_Click(object sender, EventArgs e)
        {
            this.limpiarVentana();
            this.Hide();
        }

        private void txtCodigoProfesor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
                mensajeAviso("Este campo solo admite valores numericos");
            }
        }

        public void mensajeAviso(String mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void mensajeError(String mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAgregarEsp_Click(object sender, EventArgs e)
        {
            if (this.cbIndentifica.Text == "")
            {
                this.mensajeAviso("Debe seleccionar la Identificación");
            }
            else if (this.txtCodigoExperiencia.Text == "")
            {
                this.mensajeAviso("Debe ingresar el Código de la Experiencia");
            }
            else if (this.nudTiempoExperiencia.Value == 0)
            {
                this.mensajeAviso("El tiempo de la experiencia no puede ser 0");
            }
            else if (this.txtTipoCargo.Text == "")
            {
                this.mensajeAviso("El tipo de cargo no puede estar vacío");
            }
            else
            {
                if (logicaExperienciaAcademicaProfesor.mConsultarID(conexion, Convert.ToInt32(this.txtCodigoExperiencia.Text), cbIndentifica.Text))
                {
                    this.mensajeAviso("No se puede usar el código para la experiencia, es posible que ya esta en uso");
                }
                else
                {
                    entidadExperienciaAcademica = new clEntidadExperienciaAcademica(Convert.ToInt32(this.txtCodigoExperiencia.Text), Convert.ToInt32(this.nudTiempoExperiencia.Value),this.txtTipoCargo.Text);
                    entidadExperienciasProfesor = new clEntidadExperienciasProfesor(logicaProfesor.mDevolverId(conexion,cbIndentifica.Text), Convert.ToInt32(this.txtCodigoExperiencia.Text));
                    if (logicaExperienciaAcademicaProfesor.mInsertar(conexion, entidadExperienciaAcademica, entidadExperienciasProfesor))
                    {
                        this.mensajeAviso("Experiencia Agregada");
                        this.limpiarVentana();
                    }
                    else
                    {
                        this.mensajeError("Problemas al agregar la experiencia");
                        this.limpiarVentana();
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.cbIndentifica.Text == "")
            {
                this.mensajeAviso("Debe seleccionar la Identificación");
            }
            else if (this.txtCodigoExperiencia.Text == "")
            {
                this.mensajeAviso("Debe ingresar el Código de la Experiencia");
            }
            else if (logicaExperienciaAcademicaProfesor.mConsultarID(conexion, Convert.ToInt32(this.txtCodigoExperiencia.Text), cbIndentifica.Text) == false)
            {
                this.mensajeAviso("No se encuentran resultados para la busqueda");
                this.limpiarVentana();
            }
            else
            {
                dtrExperienciaAcademicaProfesor = logicaExperienciaAcademicaProfesor.mDevolverUnRegistro(conexion,Convert.ToInt32(this.txtCodigoExperiencia.Text), cbIndentifica.Text);
                if (dtrExperienciaAcademicaProfesor != null)
                {
                    while (dtrExperienciaAcademicaProfesor.Read())
                    {
                        this.nudTiempoExperiencia.Value = dtrExperienciaAcademicaProfesor.GetInt32(0);
                        this.txtTipoCargo.Text = dtrExperienciaAcademicaProfesor.GetString(1);
                    }
                }
            }
        }

        private void cbIndentifica_SelectedValueChanged(object sender, EventArgs e)
        {
            this.cargarLvExperiencia();
        }

        public void cargarLvExperiencia()
        {
            this.lvExperiencia.Items.Clear();
            if (this.cbIndentifica.Text != "")
            {
                dtrExperienciaAcademicaProfesor = logicaExperienciaAcademicaProfesor.mConsultarGeneral(conexion);
                if (dtrExperienciaAcademicaProfesor != null)
                {
                    while (dtrExperienciaAcademicaProfesor.Read())
                    {
                        ListViewItem lista;
                        lista = lvExperiencia.Items.Add(Convert.ToString(dtrExperienciaAcademicaProfesor.GetInt32(0)));
                        lista.SubItems.Add(Convert.ToString(dtrExperienciaAcademicaProfesor.GetInt32(1)));
                        lista.SubItems.Add(dtrExperienciaAcademicaProfesor.GetString(2));
                    }
                }

            }
        }

        private void btnModificarEsp_Click(object sender, EventArgs e)
        {
            if (this.cbIndentifica.Text == "")
            {
                this.mensajeAviso("Debe seleccionar la Identificación");
            }
            else if (this.txtCodigoExperiencia.Text == "")
            {
                this.mensajeAviso("Debe ingresar el Código de la Experiencia");
            }
            else if (this.nudTiempoExperiencia.Value == 0)
            {
                this.mensajeAviso("El tiempo de la experiencia no puede ser 0");
            }
            else if (this.txtTipoCargo.Text == "")
            {
                this.mensajeAviso("El tipo de cargo no puede estar vacío");
            }
            else
            {
                if (logicaExperienciaAcademicaProfesor.mConsultarID(conexion, Convert.ToInt32(this.txtCodigoExperiencia.Text), cbIndentifica.Text)== false)
                {
                    this.mensajeAviso("El registro no existe, No se puede modificar.");
                    this.limpiarVentana();
                }
                else
                {
                    entidadExperienciaAcademica = new clEntidadExperienciaAcademica(Convert.ToInt32(this.txtCodigoExperiencia.Text), Convert.ToInt32(this.nudTiempoExperiencia.Value), this.txtTipoCargo.Text);
                    if (logicaExperienciaAcademicaProfesor.mModificar(conexion, entidadExperienciaAcademica))
                    {
                        this.mensajeAviso("Experiencia Modificada");
                        this.limpiarVentana();
                    }
                    else
                    {
                        this.mensajeError("Problemas al Modificar la Experiencia");
                        this.limpiarVentana();
                    }
                }
            }
        }

        private void btnEliminarEsp_Click(object sender, EventArgs e)
        {
            if (this.cbIndentifica.Text == "")
            {
                this.mensajeAviso("Debe seleccionar la Identificación");
            }
            else if (this.txtCodigoExperiencia.Text == "")
            {
                this.mensajeAviso("Debe ingresar el Código de la Experiencia");
            }
            else if (this.nudTiempoExperiencia.Value == 0)
            {
                this.mensajeAviso("El tiempo de la experiencia no puede ser 0");
            }
            else if (this.txtTipoCargo.Text == "")
            {
                this.mensajeAviso("El tipo de cargo no puede estar vacío");
            }
            else
            {
                if (logicaExperienciaAcademicaProfesor.mConsultarID(conexion, Convert.ToInt32(this.txtCodigoExperiencia.Text), cbIndentifica.Text) == false)
                {
                    this.mensajeAviso("El registro no existe, No se puede eliminar.");
                    this.limpiarVentana();
                }
                else
                {
                    entidadExperienciasProfesor = new clEntidadExperienciasProfesor(logicaProfesor.mDevolverId(conexion, cbIndentifica.Text), Convert.ToInt32(this.txtCodigoExperiencia.Text));
                    entidadExperienciaAcademica = new clEntidadExperienciaAcademica(Convert.ToInt32(this.txtCodigoExperiencia.Text), Convert.ToInt32(this.nudTiempoExperiencia.Value), this.txtTipoCargo.Text);
                    if ( logicaExperienciaAcademicaProfesor.mEliminarTbExperienciasProf(conexion, entidadExperienciasProfesor) && logicaExperienciaAcademicaProfesor.mEliminarEnTabla(conexion, entidadExperienciaAcademica))
                    {
                       this.mensajeAviso("Experiencia Eliminada");
                        this.limpiarVentana();
                    }
                    else
                    {
                       this.mensajeError("Problemas al Elimina la Experiencia");
                        this.limpiarVentana();
                    }
                }
            }
        }

        public void limpiarVentana()
        {
            this.lvExperiencia.Items.Clear();
           
            this.txtCodigoExperiencia.Text = "";
            this.nudTiempoExperiencia.Value = 0;
            this.txtTipoCargo.Text = "";
        }

    }
}
