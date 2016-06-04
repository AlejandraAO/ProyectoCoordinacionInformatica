using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

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
    }
}
