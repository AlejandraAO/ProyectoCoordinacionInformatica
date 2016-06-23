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
        #endregion


    }
}
