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
            strSentencia = "insert into tbGruposCurs(idCurso, numeroGrup, cupoMaximo, cupoMinimo, cupoActual) values('" + pEntidadGrupoCurso.getSetIdCurso + "', '" + pEntidadGrupoCurso.getSetNumeroGrup + "', '" + pEntidadGrupoCurso.getSetCupoMaximo + "', '" + pEntidadGrupoCurso.getSetCupoMinimo + "', '" + pEntidadGrupoCurso.getSetCupoActual + "') ";
            return conexion.mEjecutar(strSentencia, conexion);
        }

        public Boolean mInsertHorarioGruposCurs(clConexion conexion, clEntidadHorario pEntidadHorario,clEntidadGrupoCurso pEntidadGrupoCurso)
        {
            strSentencia = "insert into tbHorariosGrupCurs(idHorario,idGrupo) values ("+pEntidadHorario.mIdHorario+","+pEntidadGrupoCurso.getsetIdGrupo+" )";
            return conexion.mEjecutar(strSentencia, conexion);
        }

        public Boolean mModificarGrupoCurso(clConexion conexion, clEntidadGrupoCurso pEntidadGrupoCurso)
        {

            strSentencia = "update tbGruposCurs set numeroGrup = '" + pEntidadGrupoCurso.getSetNumeroGrup + "', cupoMaximo ='" + pEntidadGrupoCurso.getSetCupoMaximo + "', cupoMinimo='" + pEntidadGrupoCurso.getSetCupoMinimo + "', cupoActual='" + pEntidadGrupoCurso.getSetCupoActual + "' where idGrupo='" + pEntidadGrupoCurso.getsetIdGrupo + "'";
            return conexion.mEjecutar(strSentencia, conexion);
        }

        public SqlDataReader mConsultaGeneral(clConexion conexion, clEntidadGrupoCurso pEntidadGrupoCurso)
        {
            strSentencia = "select idGrupo, cupoMaximo, cupoMinimo, cupoActual from tbGruposCurs where idCurso='"+ pEntidadGrupoCurso.getSetIdCurso+"'";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        public SqlDataReader mConsultaNumeroGrupo(clConexion conexion, clEntidadGrupoCurso pEntidadGrupoCurso)
        {
            strSentencia = "select numeroGrup from tbGruposCurs where idCurso='"+pEntidadGrupoCurso.getSetIdCurso + "'";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

    

        public SqlDataReader mConsultaCodigo(clConexion conexion, clEntidadGrupoCurso pEntidadGrupoCurso)
        {
            strSentencia = "select idCurso tbGruposCurs  where idCurso= '" + pEntidadGrupoCurso.getSetIdCurso + "'";
            return conexion.mSeleccionar(strSentencia, conexion);
        }



    }
}