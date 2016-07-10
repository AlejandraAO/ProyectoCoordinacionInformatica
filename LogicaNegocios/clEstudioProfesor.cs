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
    public class clEstudioProfesor
    {
        #region Atributos
        private string strSentencia;
        #endregion

        #region Metodos

        /**
        Este metodo devuelve todo lo que se encuentre en la tabla tbEstudiosProf de la base de datos en ese momento.
        **/

        public SqlDataReader mConsultaGeneral(clConexion conexion)
        {
            strSentencia = "Select * from tbEstudiosProf";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        /**
        Este metodo inserta en la tabla tbEstudiosProf de la base de datos.
        **/

        public Boolean mInsertar(clConexion conexion, clEntidadPuestoProfesor pEntidadEstudioProfesor)
        {
            strSentencia = "Insert into tbEstudiosProf (idProfesor, idTitulo) values(" +
            pEntidadEstudioProfesor.getIdProfesor() + "," +
            pEntidadEstudioProfesor.getIdEmpresa() + ")";
            return conexion.mEjecutar(strSentencia, conexion);
        }

        /**
        Este metodo elimina un registro mediante idProfesor y idTitulo en la tabla tbEstudiosProf de la base de datos.
        **/

        public Boolean mEliminar(clConexion conexion, clEntidadPuestoProfesor pEntidadEstudioProfesor)
        {
            strSentencia = "Delete * from tbEstudiosProf where idProfesor = " +
            pEntidadEstudioProfesor.getIdProfesor() + " and idTitulo = " +
            pEntidadEstudioProfesor.getIdEmpresa() + "";
            return conexion.mEjecutar(strSentencia, conexion);
        }

        #endregion
    }
}
