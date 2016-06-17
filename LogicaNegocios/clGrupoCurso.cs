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
   public class clGrupoCurso
    {

        private string strSentencia = "";

        public Boolean mInsertarGrupo(clConexion conexion, clEntidadGrupoCurso pEntidadGrupoCurso)
        {
            strSentencia = "insert into tbGrupoCurs(idGrupo, numeroGrup, cupoMaximo, cupoMinimo, cupoActual) values('" + pEntidadGrupoCurso.getSetIdCurso + "', '" + pEntidadGrupoCurso.getSetNumeroGrup + "', '" + pEntidadGrupoCurso.getSetCupoMaximo + "', '" + pEntidadGrupoCurso.getSetCupoMinimo + "', '" + pEntidadGrupoCurso.getSetCupoActual + "') ";
            return conexion.mEjecutar(strSentencia, conexion);
        }


        public Boolean mModificarGrupoCurso(clConexion conexion, clEntidadGrupoCurso pEntidadGrupoCurso)
        {
         
                strSentencia = "update tbGrupoCurs set idGrupo = '" + pEntidadGrupoCurso.getsetIdGrupo + "', numeroGrup = '" + pEntidadGrupoCurso.getSetNumeroGrup + "', cupoMaximo ='" + pEntidadGrupoCurso.getSetCupoMaximo + "', cupoMinimo='" + pEntidadGrupoCurso.getSetCupoMinimo + "', cupoActual='" + pEntidadGrupoCurso.getSetCupoActual + "' where idGrupo='" + pEntidadGrupoCurso.getsetIdGrupo + "'";
            return conexion.mEjecutar(strSentencia, conexion);
        }

        public SqlDataReader mConsultaGeneral(clConexion conexion)
        {
            strSentencia = "select idGrupo, numeroGrup, cupoMaximo, cupoMinimo, cupoActual from tbGrupoCurs";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

      

    }
}
