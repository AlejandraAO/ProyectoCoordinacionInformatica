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
            strSentencia = "insert into tbCursosLibr(idProfesor, nombre, descripcion, estado, lugar, cupo,nombrePrograma, programa) values('" + pEntidadCursoLibre.IdProfesor+"', '"+ pEntidadCursoLibre.Nombre+ "', '"+ pEntidadCursoLibre.Descripcion+ "', '"+ pEntidadCursoLibre.Estado+ "', '"+ pEntidadCursoLibre.Lugar+ "', '" + pEntidadCursoLibre.Cupo + "' , '"+pEntidadCursoLibre.Nombre_Programa+"' ,(SELECT * FROM OPENROWSET(BULK N'" + pEntidadCursoLibre.Programa + "', SINGLE_BLOB) as Pdf)  ";
            return conexion.mEjecutar(strSentencia,conexion);
        }

       public SqlDataReader mConsultaPorID(clConexion conexion, clEntidadCursoLibre pEntidadCursoLibre)
        {
            strSentencia = "select idProfesor, nombre, descripcion, estado, lugar, cupo,nombrePrograma, programa from tbCursosLibr where idCursosLibres='" + pEntidadCursoLibre.IdCursoLibre+"'";
            return conexion.mSeleccionar(strSentencia, conexion);
        }       

        public Boolean mModificarCurso(clConexion conexion, clEntidadCursoLibre pEntidadCursoLibre)
        {
            strSentencia = "update tbCursos set estado = '" + pEntidadCursoLibre.Estado+
                                "', lugar = '" + pEntidadCursoLibre.Lugar + 
                                "', cupo ='" + pEntidadCursoLibre.Cupo+ 
                                "', nombrePrograma='"+pEntidadCursoLibre.Nombre_Programa+
                                "', programa= (SELECT * FROM OPENROWSET(BULK N'" + pEntidadCursoLibre.Programa + "', SINGLE_BLOB) as Pdf) where sigla='" + pEntidadCursoLibre.IdCursoLibre + "'";
            return conexion.mEjecutar(strSentencia, conexion);
        }

        public SqlDataReader mConsultaGeneral(clConexion conexion)
        {
            strSentencia = "select idProfesor, nombre, descripcion, estado, lugar, cupo,nombrePrograma, programa from tbCursosLibr";
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
