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
            strSentencia = "insert into tbCursos(sigla, nombre, lugar, ciclo, creditos, programa, estado, totalHoras, modalidad) values('"+pEntidadCurso.mSiglaCurso+"', '"+ pEntidadCurso.mNombreCurso+ "', '"+ pEntidadCurso.mLugarCurso+ "', '"+ pEntidadCurso.mCicloCurso+ "', '"+ pEntidadCurso.mCreditosCurso+ "', (SELECT * FROM OPENROWSET(BULK N'" + pEntidadCurso.mProgramaCurso + "', SINGLE_BLOB) as Pdf), '" + pEntidadCurso.mEstadoCurso+ "', '"+ pEntidadCurso.mTotalDeHorasCurso+ "', '"+ pEntidadCurso.mModalidadCurso+ "')      ";
            return conexion.mEjecutar(strSentencia,conexion);
        }

        public SqlDataReader mConsultaPorSigla(clConexion conexion, clEntidadCurso pEntidadCurso)
        {
            strSentencia = "select idCurso, sigla, nombre, lugar, ciclo, creditos, programa, estado, totalHoras, modalidad from tbCursos where sigla='"+pEntidadCurso.mSiglaCurso+"'";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        public SqlDataReader mConsultarPorNombre(clConexion conexion,clEntidadCurso pEntidadCurso)
        {
            strSentencia = "select idCurso,sigla,nombre,lugar,ciclo,creditos,programa,estado,totalHoras,modalidad from tbCursos where nombre='" + pEntidadCurso.mNombreCurso + "'  ";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        public SqlDataReader mConsultarPorCiclo(clConexion conexion, clEntidadCurso pEntidadCurso)
        {
            strSentencia = "select idCurso,sigla,nombre,lugar,ciclo,creditos,programa,estado,totalHoras,modalidad from tbCursos where ciclo='" + pEntidadCurso.mCicloCurso + "'  ";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        public Boolean mModificarCurso(clConexion conexion, clEntidadCurso pEntidadCurso)
        {
            strSentencia = "update tbCursos set lugar = '" + pEntidadCurso.mLugarCurso + "', ciclo = '" + pEntidadCurso.mCicloCurso + "', creditos ='"+pEntidadCurso.mCreditosCurso+ "', programa= (SELECT * FROM OPENROWSET(BULK N'" + pEntidadCurso.mProgramaCurso + "', SINGLE_BLOB) as Pdf), estado='"+pEntidadCurso.mEstadoCurso+"', totalHoras='"+pEntidadCurso.mTotalDeHorasCurso+"', modalidad='"+pEntidadCurso.mModalidadCurso+"' where sigla='" + pEntidadCurso.mSiglaCurso + "'";
            return conexion.mEjecutar(strSentencia, conexion);
        }
    }
}
