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
        public SqlDataReader mSeleccionarProyAsigAMiemb(clConexion conexion, clEntidadMiembroProyecto pEntidadMiembroProyecto)
        {
            strSentencia = "select * from tbProyectos where idProyecto in (select idProyecto from tbMiembrosProy where idMiembro=" + pEntidadMiembroProyecto.mIdMiembro+ ")";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        public Boolean mEliminar(clConexion cone, clEntidadMiembroProyecto pEntidadMiembroProyecto)
        {
            strSentencia = "delete from tbMiembrosProy where idMiembro=" + pEntidadMiembroProyecto.mIdMiembro + " and idProyecto=" + pEntidadMiembroProyecto.mIdProyecto + "";
            return cone.mEjecutar(strSentencia, cone);
        }

    }
}
