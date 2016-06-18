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
    public class clCurso
    {
   
        private string strSentencia="";

        public Boolean mInsertarCurso(clConexion conexion, clEntidadCurso pEntidadCurso)
        {
            strSentencia = "insert into tbCursos(sigla, nombre, lugar, ciclo, creditos, programa, estado, totalHoras, modalidad, nombrePrograma) values('"+pEntidadCurso.mSiglaCurso+"', '"+ pEntidadCurso.mNombreCurso+ "', '"+ pEntidadCurso.mLugarCurso+ "', '"+ pEntidadCurso.mCicloCurso+ "', '"+ pEntidadCurso.mCreditosCurso+ "', (SELECT * FROM OPENROWSET(BULK N'" + pEntidadCurso.mProgramaCurso + "', SINGLE_BLOB) as Pdf), '" + pEntidadCurso.mEstadoCurso+ "', '"+ pEntidadCurso.mTotalDeHorasCurso+ "', '"+ pEntidadCurso.mModalidadCurso+ "', '"+pEntidadCurso.mNombrePrograma+"') ";
            return conexion.mEjecutar(strSentencia,conexion);
        }

        public SqlDataReader mConsultaPorSigla(clConexion conexion, clEntidadCurso pEntidadCurso)
        {
            strSentencia = "select idCurso, sigla, nombre, lugar, ciclo, creditos, programa, estado, totalHoras, modalidad, nombrePrograma from tbCursos where sigla='"+pEntidadCurso.mSiglaCurso+"'";
            return conexion.mSeleccionar(strSentencia, conexion);
        }       

        public Boolean mModificarCurso(clConexion conexion, clEntidadCurso pEntidadCurso)
        {
            Console.WriteLine(pEntidadCurso.mProgramaCurso);
            if (pEntidadCurso.mProgramaCurso != "")
            {
                strSentencia = "update tbCursos set lugar = '" + pEntidadCurso.mLugarCurso + "', ciclo = '" + pEntidadCurso.mCicloCurso + "', creditos ='" + pEntidadCurso.mCreditosCurso + "', programa= (SELECT * FROM OPENROWSET(BULK N'" + pEntidadCurso.mProgramaCurso + "', SINGLE_BLOB) as Pdf), estado='" + pEntidadCurso.mEstadoCurso + "', totalHoras='" + pEntidadCurso.mTotalDeHorasCurso + "', modalidad='" + pEntidadCurso.mModalidadCurso + "' where sigla='" + pEntidadCurso.mSiglaCurso + "'";
            }
            else
            {
                strSentencia = "update tbCursos set lugar = '" + pEntidadCurso.mLugarCurso + "', ciclo = '" + pEntidadCurso.mCicloCurso + "', creditos ='" + pEntidadCurso.mCreditosCurso + "', estado='" + pEntidadCurso.mEstadoCurso + "', totalHoras='" + pEntidadCurso.mTotalDeHorasCurso + "', modalidad='" + pEntidadCurso.mModalidadCurso + "' where sigla='" + pEntidadCurso.mSiglaCurso + "'";
            }
            
            return conexion.mEjecutar(strSentencia, conexion);
        }

        public SqlDataReader mConsultaGeneral(clConexion conexion)
        {
            strSentencia = "select idCurso,sigla,nombre,lugar,ciclo,creditos,programa,estado,totalHoras,modalidad, nombrePrograma from tbCursos";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        public SqlDataReader mConsultaEspecifica(clConexion conexion, clEntidadCurso pEntidadCurso, string tipo)
        {
            if (tipo == "Ciclo")
            {
                strSentencia = "select idCurso,sigla,nombre,lugar,ciclo,creditos,programa,estado,totalHoras,modalidad, nombrePrograma from tbCursos where ciclo='" + pEntidadCurso.mCicloCurso + "'  ";
                return conexion.mSeleccionar(strSentencia, conexion);
            }
            else
            {
                if (tipo == "Nombre")
                {
                    strSentencia = "select idCurso,sigla,nombre,lugar,ciclo,creditos,programa,estado,totalHoras,modalidad, nombrePrograma from tbCursos where nombre='" + pEntidadCurso.mNombreCurso + "'  ";
                    return conexion.mSeleccionar(strSentencia, conexion);
                }
                else
                {
                    
                        strSentencia = "select idCurso,sigla,nombre,lugar,ciclo,creditos,programa,estado,totalHoras,modalidad, nombrePrograma from tbCursos where sigla='" + pEntidadCurso.mSiglaCurso + "'  ";
                        return conexion.mSeleccionar(strSentencia, conexion);
                    
                }
            }
            
        }

        public void mDescargarProgramaCurso(clConexion conexion, string ruta, clEntidadCurso pEntidadCurso)
        {
            strSentencia = "select programa from tbCursos where idCurso= '"+pEntidadCurso.mIdCurso+"'";
            conexion.leer(conexion,ruta,strSentencia);
        }

        public SqlDataReader mConsultarModalidadCurso(clConexion conexion,clEntidadCurso pEntidadCurso)
        {
            strSentencia = "select modalidad from tbCursos where idCurso='" + pEntidadCurso.mIdCurso + "' ";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

    }
}
