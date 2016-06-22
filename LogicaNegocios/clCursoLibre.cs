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
   
        private string sentencia="";
        public static string CONSULTA_NOMBRE = " C.nombre";
        public static string COSULTA_PROFESOR = "P.nombre";
        public static string CONSULTA_LUGAR = "C.lugar";
        public static string CONSULTA_ESTADO = "C.estado";

        public Boolean mInsertarCursoLibre(clConexion conexion, clEntidadCursoLibre pEntidadCursoLibre)
        {
            sentencia = "insert into tbCursosLibr(idProfesor, nombre, descripcion, estado, lugar, cupo, programa , nombrePrograma) values('" + pEntidadCursoLibre.mIdProfesor + "', '" + pEntidadCursoLibre.mNombre + "', '" + pEntidadCursoLibre.mDescripcion + "', '" + pEntidadCursoLibre.mEstado + "', '" + pEntidadCursoLibre.mLugar + "', '" + pEntidadCursoLibre.mCupo + "' ,(SELECT * FROM OPENROWSET(BULK N'" + pEntidadCursoLibre.mPrograma + "', SINGLE_BLOB) as Pdf) ,'" + pEntidadCursoLibre.mNombrePrograma + "' ); ";

            return conexion.mEjecutar(sentencia,conexion);
        }

       public SqlDataReader mConsultaPorID(clConexion conexion, clEntidadCursoLibre pEntidadCursoLibre)
        {
            sentencia = "select idProfesor, nombre, descripcion, estado, lugar, cupo,nombrePrograma, programa from tbCursosLibr where idCursosLibres='" + pEntidadCursoLibre.mIdCursoLibre+"'";
            return conexion.mSeleccionar(sentencia, conexion);
        }       

        public Boolean mModificarCurso(clConexion conexion, clEntidadCursoLibre pEntidadCursoLibre)
        {
            Console.WriteLine(pEntidadCursoLibre.mPrograma);
            if (pEntidadCursoLibre.mPrograma != "")
            {
                sentencia = "update tbCursosLibr set idProfesor=" + pEntidadCursoLibre.mIdProfesor +
                            ",nombre='" + pEntidadCursoLibre.mNombre + "',descripcion='" + pEntidadCursoLibre.mDescripcion +
                            "',estado='" + pEntidadCursoLibre.mEstado + "',lugar='" + pEntidadCursoLibre.mLugar +
                            "',cupo=" + pEntidadCursoLibre.mCupo + ",programa= (SELECT * FROM OPENROWSET(BULK N'"
                            + pEntidadCursoLibre.mPrograma + "', SINGLE_BLOB) as Pdf), nombrePrograma='" +
                            pEntidadCursoLibre.mNombrePrograma + "' where idCursosLibres=" + pEntidadCursoLibre.mIdCursoLibre;
            }
            else
            {
                sentencia = "update tbCursosLibr set idProfesor=" + pEntidadCursoLibre.mIdProfesor +
                            ",nombre='" + pEntidadCursoLibre.mNombre + "',descripcion='" + pEntidadCursoLibre.mDescripcion +
                            "',estado='" + pEntidadCursoLibre.mEstado + "',lugar='" + pEntidadCursoLibre.mLugar +
                            "',cupo=" + pEntidadCursoLibre.mCupo + "where idCursosLibres=" + pEntidadCursoLibre.mIdCursoLibre;
            }      
            return conexion.mEjecutar(sentencia, conexion);
        }

        public SqlDataReader mConsultaGeneral(clConexion conexion)
        {
            sentencia = @"select idCursosLibres, P.nombre,C.nombre, descripcion, C.estado, lugar, cupo, nombrePrograma from tbCursosLibr C
                             inner join tbProfesores P
                             on P.idProfesor = C.idProfesor";
            return conexion.mSeleccionar(sentencia, conexion);
        }

        public SqlDataReader mConsultaFiltrada(clConexion conexion, String nombre)
        {
            sentencia =String.Format(@"select idCursosLibres, P.nombre,C.nombre, descripcion, C.estado, lugar, cupo, nombrePrograma from tbCursosLibr C
                             inner join tbProfesores P
                             on P.idProfesor = C.idProfesor
                             where C.nombre like '{0}%' or P.nombre like '{0}%' or lugar like '{0}%' or C.estado like '{0}%'", nombre);

            return conexion.mSeleccionar(sentencia, conexion);
        }

        public SqlDataReader mConsultadeCursos(clConexion conexion)
        {
            sentencia = "select idCursosLibres, nombre from tbCursosLibr";
            return conexion.mSeleccionar(sentencia, conexion);
        }

        public SqlDataReader mConsultadeProfesores(clConexion conexion)
        {
            sentencia = "select idProfesor,nombre from tbProfesores";
            return conexion.mSeleccionar(sentencia, conexion);
        }

      

        public SqlDataReader mConsultaEspecifica(clConexion conexion, string tipoConsuta, string busqueda)
        {

            sentencia =  String.Format(@"select idCursosLibres, P.nombre, C.nombre, descripcion, C.estado, lugar, cupo, nombrePrograma from tbCursosLibr C
                             inner join tbProfesores P
                             on P.idProfesor = C.idProfesor
                             where {0} like '{1}%'", tipoConsuta , busqueda );

            return conexion.mSeleccionar(sentencia, conexion);

        }

        public void mDescargarProgramaCurso(clConexion conexion, string ruta, clEntidadCursoLibre pEntidadCursoLibre)
        {
            sentencia = "select programa from tbCursosLibr where idCursosLibres= '" + pEntidadCursoLibre.mIdCursoLibre + "'";
            conexion.leer(conexion, ruta, sentencia);
        }
    }
}
