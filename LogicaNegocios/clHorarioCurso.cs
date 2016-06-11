using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using AccesoDatos;
using System.Data.SqlClient;

namespace LogicaNegocios
{
   public  class clHorarioCurso
    {
        private string strSentencia = "";

        public Boolean mInsertarHorarioCurso(clConexion conexion, clEntidadHorarioCurso pEntidadHorarioCurso)
        {
            strSentencia = "insert into tbGruposCurs(idCurso, numeroGrup, cupoMaximo, cupoMinimo, cupoActual) values('" +pEntidadHorarioCurso.mIdCurso + "', '" + pEntidadHorarioCurso.mNumeroGrupo + "', '" + pEntidadHorarioCurso.mCupoMaximo + "', '" + pEntidadHorarioCurso.mCupoMinimo + "', '" + pEntidadHorarioCurso.mCupoActual + "') ";
            return conexion.mEjecutar(strSentencia, conexion);
        }

        public Boolean mModificarHorarioCurso(clConexion conexion, clEntidadHorarioCurso pEntidadHorarioCurso)
        {
            strSentencia = "update tbGruposCurs set idCurso = '" + pEntidadHorarioCurso.mIdCurso + "', numeroGrup = '" + pEntidadHorarioCurso.mNumeroGrupo + "', cupoMaximo ='" + pEntidadHorarioCurso.mCupoMaximo + "', cupoMinimo = '"+ pEntidadHorarioCurso.mCupoMinimo + "', cupoActual='" + pEntidadHorarioCurso.mCupoActual + "'";
            return conexion.mEjecutar(strSentencia, conexion);
        }

        public SqlDataReader mConsultaGeneralHorarioCurso(clConexion conexion)
        {
            strSentencia = "select idCurso,numeroGrup,cupoMaximo,cupoMinimo,cupoActual from tbGruposCurs";
            return conexion.mSeleccionar(strSentencia, conexion);
        }


    }
}
