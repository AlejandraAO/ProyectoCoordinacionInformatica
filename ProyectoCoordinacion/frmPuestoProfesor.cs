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
    public partial class frmPuestoProfesor : Form
    {
        clConexion conexion;
        SqlDataReader dtrProfesor, dtrPuestoProfesor;
        clPuestoProfesor logicaPuestoProfesor;
        clProfesor logicaProfesor;

        clEntidadPuestoProfesor entidadPuestoProfesor;

        

        public frmPuestoProfesor(clConexion conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
            logicaProfesor = new clProfesor();
            logicaPuestoProfesor = new clPuestoProfesor();
        }
        #region metodos Botones
        private void frmPuestoProfesor_Load(object sender, EventArgs e)
        {
            this.cargarCombos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codProfesor = 0;

            if (cbIndentifica.Text.Trim()!=""){
             
                if (verifarExistenciaProfe(cbIndentifica.Text.Trim()))
                {
                    codProfesor = buscarCodigo(cbIndentifica.Text.Trim());
                    if (buscarPuestoProfesor(codProfesor))
                    {
                        cargarDatos(codProfesor);
                    }
                    else {
                        mensajeAviso("El profesor no posee puesto");
                    }
                }
                else
                {
                    MessageBox.Show("El prodesor no existe");
                }
                        }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int codProfesor = 0;
            if (verificarBlancos())
            {
                if (verifarExistenciaempresa(Convert.ToInt32(cbCodigoEmpresa.Text.Trim())))
                {

                    if (verifarExistenciaProfe(cbIndentifica.Text.Trim()))
                    {
                        codProfesor = buscarCodigo(cbIndentifica.Text.Trim());
                        entidadPuestoProfesor = new clEntidadPuestoProfesor(codProfesor, Convert.ToInt32(cbCodigoEmpresa.Text.Trim()), Convert.ToInt32(nudTiempoExperiencia.Value), txtPuesto.Text.Trim());

                        if (logicaPuestoProfesor.mInsertar(conexion, entidadPuestoProfesor))
                        {
                            MessageBox.Show("datos guardados");
                            limpiarVentana();
                            cargarCombos();
                        }
                        else
                        {
                            MessageBox.Show("error al guardar");
                        }
                    }
                    else
                    {
                        mensajeAviso("el profesor no existe");
                    }
                }
                else {

                    mensajeAviso("El codigo de empesa no existe");
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codProfesor = 0;

            if (cbIndentifica.Text.Trim() != "")
            {
                if (verifarExistenciaProfe(cbIndentifica.Text.Trim()))
                {
                    codProfesor = buscarCodigo(cbIndentifica.Text.Trim());
                    if (buscarPuestoProfesor(codProfesor))
                    {
                        if (logicaPuestoProfesor.mEliminar(conexion, codProfesor))
                        {

                            MessageBox.Show("El puesto del profesro se ha eliminado");
                            limpiarVentana();
                            cargarCombos();

                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar los datos");
                        }
                    }
                    else {

                        mensajeAviso("El profesor no posee puesto");
                            }
                }
                else
                {
                    MessageBox.Show("El prodesor no existe");
                }
                          
            }

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int codProfesor = 0;
            if (verificarBlancos())
            {
                if (verifarExistenciaempresa(Convert.ToInt32(cbCodigoEmpresa.Text.Trim())))
                {

                    if (verifarExistenciaProfe(cbIndentifica.Text.Trim()))
                    {
                        codProfesor = buscarCodigo(cbIndentifica.Text.Trim());
                        entidadPuestoProfesor = new clEntidadPuestoProfesor(codProfesor, Convert.ToInt32(cbCodigoEmpresa.Text.Trim()), Convert.ToInt32(nudTiempoExperiencia.Value), txtPuesto.Text.Trim());
                        if (buscarPuestoProfesor(codProfesor))
                        {
                            if (logicaPuestoProfesor.mModificar(conexion, entidadPuestoProfesor))
                            {
                                mensajeAviso("EL puesto ha sido modificado");
                                limpiarVentana();
                                cargarCombos();
                            }
                            else
                            {
                                mensajeError("Erro al modificar");
                            }
                        }
                        else {
                            mensajeError("El profesor no posee puesto");

                        }
                    }else
                    {
                        mensajeError("NO existe el profesor");
                    }

                }
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion
        #region metodos aplicados
        public void cargarCombos()
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
            dtrPuestoProfesor = logicaPuestoProfesor.mLlenarCombo(this.conexion);
            if (dtrPuestoProfesor != null)
            {
                while(dtrPuestoProfesor.Read())
                {
                    string idEmpresa = Convert.ToString(dtrPuestoProfesor.GetInt32(0));
                    cbCodigoEmpresa.Items.Add(idEmpresa);
                }
            }
        }

       

        public void limpiarVentana()
        {
           
            for (int i = 0; i < this.cbIndentifica.Items.Count; i++)
            {
                cbIndentifica.Items.Clear();
            }

            for (int i = 0; i < this.cbCodigoEmpresa.Items.Count; i++)
            {
                cbCodigoEmpresa.Items.Clear();
            }
     
            this.txtPuesto.Text = "";
            this.nudTiempoExperiencia.Value=0;

        }

        public Boolean verificarBlancos()
        {
            Boolean veri = true;
            if (cbIndentifica .Text.Trim() == "")
            {
                errorProvider1.SetError(cbIndentifica, "Debe ingresar la identificacion de profesor");
                veri = false;
                MessageBox.Show("Debe ingresar la identificacion de profesor");
            }
            else if (cbCodigoEmpresa.Text.Trim() == "")
            {
                errorProvider1.SetError(cbCodigoEmpresa, "Debe ingresar el codigo de la empresa");
                veri = false;
                MessageBox.Show("Debe ingresar el codigo de la empresa");
            }else if (nudTiempoExperiencia.Text.Trim() == "")
            {
                errorProvider1.SetError(nudTiempoExperiencia, "Debe ingresar la cantidad de meses laborados en la empresa");
                veri = false;
                MessageBox.Show("Debe ingresar la cantidad de meses laborados en la empresa");
            }else if (txtPuesto.Text.Trim() == "")
            {
                errorProvider1.SetError(txtPuesto, "Debe ingresar el puesto ejecudado en la empresa");
                veri = false;
                MessageBox.Show("Debe ingresar el puesto ejecudado en la empresa");
            }
            return veri;
        }
        public void mensajeAviso(String mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void mensajeError(String mensaje)
        {

            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private Boolean verifarExistenciaempresa(int codigo)
        {
            Boolean veri = false;
            dtrProfesor = logicaPuestoProfesor.mLlenarCombo(conexion);
            if (dtrProfesor != null)
            {
                while (dtrProfesor.Read())
                {
                    if (dtrProfesor.GetInt32(0) == codigo)
                    {
                        veri = true;
                    }
                }
            }
            return veri;
        }
        private Boolean verifarExistenciaProfe(string codigo)
        {
            Boolean veri = false;
            dtrProfesor = logicaProfesor.mConsultaGeneral(conexion);
            if (dtrProfesor != null)
            {
                while (dtrProfesor.Read())
                {
                    if (dtrProfesor.GetString(8).Equals( codigo))
                    {
                        veri = true;
                    }
                }
            }
            return veri;
        }

        private int buscarCodigo(string codigo)
        {
            int idProfesor = 0;
            dtrProfesor = logicaProfesor.mConsultaGeneral(conexion);
            if (dtrProfesor != null)
            {
                while (dtrProfesor.Read())
                {
                    if (dtrProfesor.GetString(8).Equals(codigo))
                    {

                        idProfesor = dtrProfesor.GetInt32(0);
                    }
                }
            }
            return idProfesor;
        }
        private void cargarDatos(int codigo)
        {
          
            dtrProfesor = logicaPuestoProfesor.mConsultaGeneralcodigo(conexion,codigo);
            if (dtrProfesor != null)
            {
                while (dtrProfesor.Read())
                {
                    cbCodigoEmpresa.Text = Convert.ToString( dtrProfesor.GetInt32(1));
                    nudTiempoExperiencia.Value= dtrProfesor.GetInt32(1);
                    txtPuesto.Text = dtrProfesor.GetString(2);
                    
                }
               
            }
          
        }

    

        private Boolean buscarPuestoProfesor(int codigo)
        {
            Boolean veri = false;
            dtrProfesor = logicaPuestoProfesor.mConsultaGeneralcodigo(conexion, codigo);
            if (dtrProfesor != null)
            {
                while (dtrProfesor.Read())
                {
                    if (dtrProfesor.GetInt32(0)==codigo)
                    {
                        veri = true;
                       
                    }
                }
            }
            return veri;
        }



        #endregion 
    }

}
