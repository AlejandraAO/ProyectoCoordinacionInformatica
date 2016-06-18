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
    public class clCursoLibre
    {
   
        private string strSentencia="";
        public static string CONSULTA_NOMBRE = " C.nombre";
        public static string COSULTA_PROFESOR = "P.nombre";
        public static string CONSULTA_LUGAR = "C.lugar";
        public static string CONSULTA_ESTADO = "C.estado";

        public Boolean mInsertarCursoLibre(clConexion conexion, clEntidadCursoLibre pEntidadCursoLibre)
        {
            strSentencia = "insert into tbCursosLibr(idProfesor, nombre, descripcion, estado, lugar, cupo,programa,nombrePrograma) values('" + pEntidadCursoLibre.IdProfesor + "', '" + pEntidadCursoLibre.Nombre + "', '" + pEntidadCursoLibre.Descripcion + "', '" + pEntidadCursoLibre.Estado + "', '" + pEntidadCursoLibre.Lugar + "', '" + pEntidadCursoLibre.Cupo + "' ,(SELECT * FROM OPENROWSET(BULK N'" + pEntidadCursoLibre.Programa + "', SINGLE_BLOB) as Pdf) ,'" + pEntidadCursoLibre.Nombre_Programa + "' ); ";

            return conexion.mEjecutar(strSentencia,conexion);
        }

       public SqlDataReader mConsultaPorID(clConexion conexion, clEntidadCursoLibre pEntidadCursoLibre)
        {
            strSentencia = "select idProfesor, nombre, descripcion, estado, lugar, cupo,nombrePrograma, programa from tbCursosLibr where idCursosLibres='" + pEntidadCursoLibre.IdCursoLibre+"'";
            return conexion.mSeleccionar(strSentencia, conexion);
        }       

        public Boolean mModificarCurso(clConexion conexion, clEntidadCursoLibre pEntidadCursoLibre)
        {
            Console.WriteLine(pEntidadCursoLibre.Programa);
            if (pEntidadCursoLibre.Programa != "")
            {
                strSentencia = "update tbCursosLibr set idProfesor=" + pEntidadCursoLibre.IdProfesor +
                            ",nombre='" + pEntidadCursoLibre.Nombre + "',descripcion='" + pEntidadCursoLibre.Descripcion +
                            "',estado='" + pEntidadCursoLibre.Estado + "',lugar='" + pEntidadCursoLibre.Lugar +
                            "',cupo=" + pEntidadCursoLibre.Cupo + ",programa= (SELECT * FROM OPENROWSET(BULK N'"
                            + pEntidadCursoLibre.Programa + "', SINGLE_BLOB) as Pdf), nombrePrograma='" +
                            pEntidadCursoLibre.Nombre_Programa + "' where idCursosLibres=" + pEntidadCursoLibre.IdCursoLibre;
            }
            else
            {
                strSentencia = "update tbCursosLibr set idProfesor=" + pEntidadCursoLibre.IdProfesor +
                            ",nombre='" + pEntidadCursoLibre.Nombre + "',descripcion='" + pEntidadCursoLibre.Descripcion +
                            "',estado='" + pEntidadCursoLibre.Estado + "',lugar='" + pEntidadCursoLibre.Lugar +
                            "',cupo=" + pEntidadCursoLibre.Cupo + "where idCursosLibres=" + pEntidadCursoLibre.IdCursoLibre;
            }      
            return conexion.mEjecutar(strSentencia, conexion);
        }

        public SqlDataReader mConsultaGeneral(clConexion conexion)
        {
            strSentencia = @"select P.nombre,C.nombre, descripcion, C.estado, lugar, cupo, programa from tbCursosLibr C
                             inner join tbProfesores P
                             on P.idProfesor = C.idProfesor";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        public SqlDataReader mConsultaFiltrada(clConexion conexion, String nombre)
        {
            strSentencia =String.Format(@"select P.nombre,C.nombre, descripcion, C.estado, lugar, cupo, programa from tbCursosLibr C
                             inner join tbProfesores P
                             on P.idProfesor = C.idProfesor
                             where C.nombre like '{0}%' or P.nombre like '{0}%' or lugar like '{0}%' or C.estado like '{0}%'", nombre);

            return conexion.mSeleccionar(strSentencia, conexion);
        }

        public SqlDataReader mConsultadeCursos(clConexion conexion)
        {
            strSentencia = "select idCursosLibres, nombre from tbCursosLibr";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        public SqlDataReader mConsultadeProfesores(clConexion conexion)
        {
            strSentencia = "select idProfesor,nombre from tbProfesores";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

      

        public SqlDataReader mConsultaEspecifica(clConexion conexion, string tipoConsuta, string busqueda)
        {

            strSentencia =  String.Format(@"select P.nombre as profesor, C.nombre, descripcion, C.estado, lugar, cupo, programa from tbCursosLibr C
                             inner join tbProfesores P
                             on P.idProfesor = C.idProfesor
                             where {0} like '{1}%'", tipoConsuta , busqueda );

            return conexion.mSeleccionar(strSentencia, conexion);

        }
    }
}
