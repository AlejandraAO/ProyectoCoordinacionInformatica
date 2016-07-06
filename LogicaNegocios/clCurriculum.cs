using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AccesoDatos;
using EntidadNegocios;

namespace LogicaNegocios
{
   public class clCurriculum
    {
        #region Atributos
        private string strSentencia;
        #endregion

        #region Metodos
        public Boolean mInsertarCurriculum(clConexion cone, clEntidadCurriculum pEntidadCurriculum)
        {
            strSentencia = "Insert into tbCurriculums(idEstudiante,curriculum) values(" + pEntidadCurriculum.getIdEstudiante()
                + ", (Select * from OPENROWSET(BULK N'" + pEntidadCurriculum.getCurriculum() + "',SINGLE_BLOB)as Pdf))";
            return cone.mEjecutar(strSentencia, cone);
        }


        #endregion
    }
}
