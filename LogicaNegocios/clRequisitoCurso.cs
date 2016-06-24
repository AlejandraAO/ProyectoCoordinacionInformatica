using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data.SqlClient;
using Entidades;

namespace LogicaNegocios
{
   public class clRequisitoCurso
    {
        private string sentencia;

        public Boolean mInsertarRequisitoCurso(clConexion conexion, clEntidadRequisitoCurso pEntidadRequisitoCurso)
        {
            sentencia = "insert into tbRequisitosCurs(idCurso, idCursoRequ) values ("+ pEntidadRequisitoCurso .mIdCurso+ ", "+ pEntidadRequisitoCurso.mIdCursoRequerido+ ")";
            return conexion.mEjecutar(sentencia,conexion);
        }

        public Boolean mModificarRequisitoCurso(clConexion conexion, clEntidadRequisitoCurso pEntidadRequisitoCurso)
        {

            sentencia = "update tbRequisitosCurs set idCurso = '" + pEntidadRequisitoCurso.mIdCurso + "', idCursoRequ = '" + pEntidadRequisitoCurso.mIdCursoRequerido + "' ";
            return conexion.mEjecutar(sentencia, conexion);
        }

        public SqlDataReader mConsultarRequisitoCurso(clConexion conexion, clEntidadRequisitoCurso pEntidad)
        {
            sentencia = "select idCurso,idCursoRequ from tbRrequisitosCurs where idCurso='" + pEntidad.mIdCurso + "' ";
            return conexion.mSeleccionar(sentencia, conexion);
        }
    }
}
