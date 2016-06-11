using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AccesoDatos;
using Entidades;

namespace LogicaNegocios
{
   public  class clMiembroProyecto
    {
        #region Atributos
        private string strSentencia;
        #endregion

        public Boolean mInsertarMiembroProyecto(clConexion cone, clEntidadMiembroProyecto pEntidadMiembroProyecto)
        {
            strSentencia = "Insert into tbMiembrosProy(idMiembro, idProyecto)values('" + pEntidadMiembroProyecto.mIdMiembro + "', '" + pEntidadMiembroProyecto.mIdProyecto + "')";
            return cone.mEjecutar(strSentencia, cone);
        }
    }
}
