using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;
using System.Data.SqlClient;

namespace LogicaNegocios
{
    public class clPuestoProfesor
    {
        #region Atributos
        private string strSentencia;
        clEntidadPuestoProfesor logicaPuestoProfesor;
        #endregion

        #region Metodos

        public SqlDataReader mLlenarCombo(clConexion cone)
        {
            strSentencia = "Select idEmpresa from tbEmpresas";
            return cone.mSeleccionar(strSentencia, cone);
        }

      
        /**
      Este metodo inserta en la tabla tbPuestosProfesor de la base de datos.
      **/

        public Boolean mInsertar(clConexion conexion, clEntidadPuestoProfesor pEntidadEstudioProfesor)
        {
            strSentencia = "Insert into tbPuestosProf (idProfesor, idEmpresa,puesto,tiempoLabo) values('" +
            pEntidadEstudioProfesor.getIdProfesor() + "','" +
            pEntidadEstudioProfesor.getIdEmpresa() + "','" +
             pEntidadEstudioProfesor.getPuesto() + "','" +
             pEntidadEstudioProfesor.getTiempoLaboral()+"')";
            return conexion.mEjecutar(strSentencia, conexion);
        }

        public SqlDataReader mConsultaGeneral(clConexion conexion)
        {
            strSentencia = "Select * from tbPuestosProf";
            return conexion.mSeleccionar(strSentencia, conexion);
        }
        public SqlDataReader mConsultaGeneralcodigo(clConexion conexion, int codigo)
        {
            strSentencia = "Select * from tbPuestosProf where idProfesor='"+codigo+"'";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        public Boolean mEliminar(clConexion conexion, int codigo)
        {
            strSentencia = "Delete from tbPuestosProf where idProfesor = '" + codigo+ "'";
            return conexion.mEjecutar(strSentencia, conexion);
        }

        public Boolean mModificar(clConexion conexion, clEntidadPuestoProfesor pEntidadEstudioProfesor)
        {
            strSentencia = "update tbPuestosProf set puesto = '" + pEntidadEstudioProfesor.getPuesto() + "', tiempoLabo = " + pEntidadEstudioProfesor.getTiempoLaboral() + " where idProfesor = " + pEntidadEstudioProfesor.getIdProfesor() + " and idEmpresa = "+ pEntidadEstudioProfesor.getIdEmpresa() + " ";
            return conexion.mEjecutar(strSentencia, conexion);
        }
        #endregion
    }
}
