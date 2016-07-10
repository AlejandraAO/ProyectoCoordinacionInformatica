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
    public class clTitulos
    {
        #region Atributos
        private string strSentencia;
        #endregion

        #region Metodos

        /**
        Este metodo devuelve todo lo que se encuentre en la tabla tbTitulosProf de la base de datos en ese momento.
        **/

        public SqlDataReader mConsultaGeneral(clConexion conexion)
        {
            strSentencia = "Select * from tbTitulos";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        /**
        Este metodo inserta en la tabla tbTitulosProf de la base de datos.
        **/

        public Boolean mInsertar(clConexion conexion, clEntidadTitulos pEntidadTitulosProfesor)
        {
            strSentencia = "Insert into tbTitulos (idProfesor, idTitulo) values(" +
            pEntidadTitulosProfesor.getIdProfesor() + "," +
            pEntidadTitulosProfesor.getIdTitulo() + ")";
            return conexion.mEjecutar(strSentencia, conexion);
        }

        /**
        Este metodo elimina un registro mediante idProfesor y idTitulo en la tabla tbTitulosProf de la base de datos.
        **/

        public Boolean mEliminar(clConexion conexion, clEntidadTitulos pEntidadTitulosProfesor)
        {
            strSentencia = "Delete * from tbTitulos where idProfesor = " +
            pEntidadTitulosProfesor.getIdProfesor() + " and idTitulo = " +
            pEntidadTitulosProfesor.getIdTitulo() + "";
            return conexion.mEjecutar(strSentencia, conexion);
        }

        #endregion
    }
}
