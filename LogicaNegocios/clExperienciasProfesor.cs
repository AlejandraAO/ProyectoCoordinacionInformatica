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
    public class clExperienciasProfesor
    {
        #region Atributos
        private string strSentencia;
        #endregion

        #region Metodos

        /**
        Este metodo devuelve todo lo que se encuentre en la tabla tbExperienciasProf de la base de datos en ese momento.
        **/

        public SqlDataReader mConsultaGeneral(clConexion conexion)
        {
            strSentencia = "Select * from tbExperienciasProf";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        /**
        Este metodo inserta en la tabla tbExperienciasProf de la base de datos.
        **/

        public Boolean mInsertar(clConexion conexion, clEntidadExperienciasProfesor pEntidadExperienciasProfesor)
        {
            strSentencia = "Insert into tbExperienciasProf (idProfesor, idExperienciaLabo) values(" +
            pEntidadExperienciasProfesor.getIdProfesor() + "," +
            pEntidadExperienciasProfesor.getIdExperienciaLabo() + ")";
            return conexion.mEjecutar(strSentencia, conexion);
        }

        /**
        Este metodo elimina un registro mediante idProfesor y idExperienciaLabo en la tabla tbExperienciasProf de la base de datos.
        **/

        public Boolean mEliminar(clConexion conexion, clEntidadExperienciasProfesor pEntidadExperienciasProfesor)
        {
            strSentencia = "Delete * from tbExperienciasProf where idProfesor = " +
            pEntidadExperienciasProfesor.getIdProfesor() + " and idExperienciaLabo = " +
            pEntidadExperienciasProfesor.getIdExperienciaLabo() + "";
            return conexion.mEjecutar(strSentencia, conexion);
        }

    
        #endregion
    }
}
