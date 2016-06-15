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

      

        /*public SqlDataReader mConsultaEspecifica(clConexion conexion, clEntidadCurso pEntidadCurso, string tipo)
        {
            if (tipo == "Ciclo")
            {
                strSentencia = "select idCurso,sigla,nombre,lugar,ciclo,creditos,programa,estado,totalHoras,modalidad from tbCursos where ciclo='" + pEntidadCurso.mCicloCurso + "'  ";
                return conexion.mSeleccionar(strSentencia, conexion);
            }
            else
            {
                if (tipo == "Nombre")
                {
                    strSentencia = "select idCurso,sigla,nombre,lugar,ciclo,creditos,programa,estado,totalHoras,modalidad from tbCursos where nombre='" + pEntidadCurso.mNombreCurso + "'  ";
                    return conexion.mSeleccionar(strSentencia, conexion);
                }
                else
                {
                    
                        strSentencia = "select idCurso,sigla,nombre,lugar,ciclo,creditos,programa,estado,totalHoras,modalidad from tbCursos where sigla='" + pEntidadCurso.mSiglaCurso + "'  ";
                        return conexion.mSeleccionar(strSentencia, conexion);
                    
                }
            }
            
        }*/
    }
}
