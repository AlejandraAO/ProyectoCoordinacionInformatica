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
    public class clCoRequisitoCurso
    {
        #region Atributos
        private string sentencia;
        #endregion

        #region Metodos
        public Boolean mInsertarCoRequisitoCurso(clConexion conexion,clEntidadCoRequisitoCurso pEntidadCoRequisitoCurso)
        {
            sentencia = "insert into tbCorrequisitosCurs(idCurso, idCursoCorr) values (" + pEntidadCoRequisitoCurso.mIdCurso + ", " + pEntidadCoRequisitoCurso.mIdCursoCoRequisito + ")";
            return conexion.mEjecutar(sentencia, conexion);
        }

        public Boolean mModificarCoRequisitoCurso(clConexion conexion, clEntidadCoRequisitoCurso pEntidadCoRequisitoCurso)
        {

            sentencia = "update tbCorrequisitosCurs set idCurso = '" + pEntidadCoRequisitoCurso.mIdCurso + "', idCursoCorr = '" + pEntidadCoRequisitoCurso.mIdCursoCoRequisito + "' ";
            return conexion.mEjecutar(sentencia, conexion);
        }

        public SqlDataReader mConsultarCoRequisitoCurso(clConexion conexion, clEntidadCoRequisitoCurso pEntidad)
        {
            sentencia = "select idCurso,idCursoCorr from tbCorrequisitosCurs where idCurso='" + pEntidad.mIdCurso + "' ";
            return conexion.mSeleccionar(sentencia, conexion);
        }

        public SqlDataReader mConsultarCoRequisitoCursoPorId(clConexion conexion, clEntidadCoRequisitoCurso pEntidad)
        {
            sentencia = "select idCurso from tbCorrequisitosCurs where idCurso='" + pEntidad.mIdCurso + "'  ";
            return conexion.mSeleccionar(sentencia, conexion);
        }
        

        #endregion
    }
}
