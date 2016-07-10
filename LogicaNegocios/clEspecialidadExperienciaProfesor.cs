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
    public class clEspecialidadExperienciaProfesor
    {
        #region Atributos
       // clEntidadEspecialidadProfesor pEntidadEspecialidadProfesor;
        private string strSentencia;
        #endregion

        #region Metodos

        /**
        Este metodo devuelve todo lo que se encuentre en la tabla tbEspecialidadesProf de la base de datos en ese momento.
        **/

        public SqlDataReader mConsultaGeneral(clConexion conexion)
        {
            strSentencia = "Select * from tbEspecialidadExperienciaProfesor";
            return conexion.mSeleccionar(strSentencia, conexion);
        }


        /**
        Este metodo inserta en la tabla tbEspecialidadesProf de la base de datos.
        **/

        public Boolean mInsertar(clConexion conexion, clEntidadEspecialidadProfesor pEntidadEspecialidadProfesor)
        {
            strSentencia = "Insert into tbEspecialidadExperienciaProfesor ( idEspecialidadExperiencia,idProfesor) values('" +
            pEntidadEspecialidadProfesor.getIdEspecialidad() + "','"+
            pEntidadEspecialidadProfesor.getIdProfesor() + "')";
            return conexion.mEjecutar(strSentencia, conexion);
        }

        /**
        Este metodo elimina un registro mediante idProfesor y idEspecialidad en la tabla tbEspecialidadesProf de la base de datos.
        **/

        public Boolean mEliminar(clConexion conexion, clEntidadEspecialidadProfesor pEntidadEspecialidadProfesor)
        {
            strSentencia = "Delete * from tbEspecialidadExperienciaProfesor where idProfesor = " +
            pEntidadEspecialidadProfesor.getIdProfesor() + " and idEspecialidad = " +
            pEntidadEspecialidadProfesor.getIdEspecialidad() + "";
            return conexion.mEjecutar(strSentencia, conexion);
        }


        #endregion
    }
}
