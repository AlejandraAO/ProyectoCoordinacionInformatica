using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using EntidadNegocios;
using System.Data.SqlClient;

namespace LogicaNegocios
{
    public class clProfesoresGrupoCurso
    {
        #region Atributos
        private string strSentencia;
        #endregion

        #region Metodos

        public SqlDataReader getCursos(clConexion conexion, String identificacion)
        {
            strSentencia = "select cu.sigla, cu.nombre, cu.lugar, cu.ciclo, cu.creditos, cu.estado, cu.totalHoras, cu.modalidad from tbProfesores pf, tbProfesoresGrupCurs pgc, tbGruposCurs gc, tbCursos cu where pf.identificacion = '"+identificacion+"'and pf.idProfesor = pgc.idProfesor and pgc.idGrupo = gc.idGrupo and gc.idCurso = cu.idCurso";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        public SqlDataReader getGrupos(clConexion conexion, String identificacion)
        {
            strSentencia = "select gc.numeroGrup, gc.cupoMaximo, gc.cupoMinimo, cupoActual from tbProfesores pf, tbProfesoresGrupCurs pgc, tbGruposCurs gc where pf.identificacion = '" + identificacion + "' and pf.idProfesor = pgc.idProfesor and pgc.idGrupo = gc.idGrupo";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        public SqlDataReader getCursosLibres(clConexion conexion, String identificacion)
        {
            strSentencia = "select cl.nombre, cl.descripcion, cl.estado, cl.lugar, cl.cupo from tbProfesores pf, tbCursosLibr cl where pf.identificacion = '" + identificacion + "' and pf.idProfesor = cl.idProfesor ";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        public SqlDataAdapter adaptarDataCurso(clConexion conexion, String identificacion)
        {
            strSentencia = "select cu.sigla as Sigla, cu.nombre as Nombre, cu.lugar as Lugar, cu.ciclo as Ciclo, cu.creditos as Créditos, cu.estado as Estado, cu.totalHoras as Total_Horas, cu.modalidad as Modalidad from tbProfesores pf, tbProfesoresGrupCurs pgc, tbGruposCurs gc, tbCursos cu where pf.identificacion = '" + identificacion + "'and pf.idProfesor = pgc.idProfesor and pgc.idGrupo = gc.idGrupo and gc.idCurso = cu.idCurso";
            return conexion.mAdaptar(strSentencia, conexion);
        }

        public SqlDataAdapter adaptarDataGrupo(clConexion conexion, String identificacion)
        {
            strSentencia=  "select gc.numeroGrup as Numero_Grupo, gc.cupoMaximo as Cupo_Maximo, gc.cupoMinimo as Cupo_Mínimo, gc.cupoActual as Cupo_Actual from tbProfesores pf, tbProfesoresGrupCurs pgc, tbGruposCurs gc where pf.identificacion = '" + identificacion + "' and pf.idProfesor = pgc.idProfesor and pgc.idGrupo = gc.idGrupo";
            return conexion.mAdaptar(strSentencia, conexion);
        }

        public SqlDataAdapter adaptarDataCursoLlibre(clConexion conexion, String identificacion)
        {
            strSentencia = "select cl.nombre as Nombre, cl.descripcion as Descripción, cl.estado as Estado, cl.lugar as Lugar, cl.cupo as Cupo from tbProfesores pf, tbCursosLibr cl where pf.identificacion = '" + identificacion + "' and pf.idProfesor = cl.idProfesor ";
            return conexion.mAdaptar(strSentencia, conexion);
        }
        #endregion
    }
}
