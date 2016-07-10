using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios;
using AccesoDatos;
using System.Data.SqlClient;

namespace Vista
{
    public partial class frmObservacionesPeriodoLaboral: Form
    {
        clConexion conexion;
        SqlDataReader dtrProfesor, dtrObservacion, dtrPeriodoLaboral;
        clProfesor logicaProfesor;
        clObservavionesPeriodoLaboral observacionesPeriodoLaboral;

        public frmObservacionesPeriodoLaboral(clConexion conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
            logicaProfesor = new clProfesor();
            observacionesPeriodoLaboral = new clObservavionesPeriodoLaboral();
        }

        private void frmObservacionesPeriodoLaboral_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            this.cargarCombo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.limpiarFrame();
            this.Hide();
        }
        
        public void cargarCombo()
        {
            dtrProfesor = logicaProfesor.mLlenarCombo(this.conexion);
            if (dtrProfesor != null)
            {
                while (dtrProfesor.Read())
                {
                    String indentificacion = dtrProfesor.GetString(0).Trim();
                    cbIndentificacion.Items.Add(indentificacion);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.limpiarFrame();
            if (cbIndentificacion.Text == "")
            {
                this.mensajeAdvertencia("Dede Seleccionar la Identificación");
            }
            else
            {
                this.llenarLvObervaciones();
                this.llenarFechaIngresoSalida();
            }
        }

        public void llenarLvObervaciones()
        {
            dtrObservacion = observacionesPeriodoLaboral.getObservaciones(conexion, this.cbIndentificacion.Text.Trim());
            if (dtrObservacion != null)
            {
                while (dtrObservacion.Read())
                {
                    ListViewItem lista;
                    lista = lvObervacion.Items.Add(dtrObservacion.GetString(0));
                    lista.SubItems.Add(dtrObservacion.GetString(1));
                    string fecha = string.Format(dtrObservacion.GetDateTime(2).ToString("yyyy/MM/dd"));
                    lista.SubItems.Add(fecha);
                }
            }
        
        }//fin del metodo.

        public void llenarFechaIngresoSalida()
        {
            dtrPeriodoLaboral = observacionesPeriodoLaboral.getPeriodoLaboral(conexion, this.cbIndentificacion.Text.Trim());
            if (dtrPeriodoLaboral != null)
            {
                while(dtrPeriodoLaboral.Read())
                { 
                    this.txtFechaIngreso.Text = dtrPeriodoLaboral.GetDateTime(0).ToString("yyyy/MM/dd");
                    this.txtFechaSalida.Text = dtrPeriodoLaboral.GetDateTime(1).ToString("yyyy/MM/dd");
                }
            }
        }


        public void limpiarFrame()
        {
            this.lvObervacion.Items.Clear();
            this.txtFechaIngreso.Text = "";
            this.txtFechaSalida.Text = "";
            

        }
        public void mensajeAdvertencia(String mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }// fin del metodo de advertencia
    }
}
