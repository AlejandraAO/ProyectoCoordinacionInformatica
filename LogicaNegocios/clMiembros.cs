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
   public class clMiembros
    {
        #region Atributos
        private string strSentencia;
        #endregion

        #region Metodos
        public SqlDataReader mConsultarMiembros(clConexion cone)
        {
            strSentencia = "select * from tbMiembros";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public SqlDataReader mConsultarIdMiembro(clConexion cone)
        {
            strSentencia = "SELECT IDENT_CURRENT('tbMiembros')"; 
            return cone.mSeleccionar(strSentencia, cone);

        }

        public SqlDataReader mConsultarMiembrosDeProyectos(clConexion cone, clEntidadMiembroProyecto pEntidadMiembroProyecto)
        {
            strSentencia = "select * from tbMiembros where idMiembro= (select idMiembro from tbMiembrosProy where idProyecto= " + pEntidadMiembroProyecto.mIdProyecto + " )";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public SqlDataReader mConsultarMiembroId(clConexion conexion, clEntidadMiembro pEntidadMiembro)
        {
            strSentencia = "select idMiembro from tbMiembros where carnet='" + pEntidadMiembro.getSetCarnetMiembro + "'";
            return conexion.mSeleccionar(strSentencia, conexion);
        }
        public Boolean mInsertarMiembro(clConexion cone, clEntidadMiembro pEntidadMiembro)
        {
            strSentencia = "insert into tbMiembros(carnet, nombre, apellido1, apellido2, carrera, tipo) values('" + pEntidadMiembro.getSetCarnetMiembro + "','" + pEntidadMiembro.getSetNombreMiembro+"', '"+pEntidadMiembro.getSetApellido1Miembro+"', '"+pEntidadMiembro.getSetApellido2Miembro+"',  '"+pEntidadMiembro.getSetCarreraMiembro+ "', '" + pEntidadMiembro.getSetTipo + "')";
            return cone.mEjecutar(strSentencia, cone);
        }
        public Boolean mModificarMiembro(clConexion cone, clEntidadMiembro pEntidadMiembro)
        {
            strSentencia = "update tbMiembros set nombre='"+pEntidadMiembro.getSetNombreMiembro+"', apellido1='"+pEntidadMiembro.getSetApellido1Miembro+ "', apellido2='" + pEntidadMiembro.getSetApellido2Miembro + "' , carrera='" + pEntidadMiembro.getSetCarreraMiembro + "' , tipo='" + pEntidadMiembro.getSetTipo+ "' where carnet='"+pEntidadMiembro.getSetCarnetMiembro+"'";
            return cone.mEjecutar(strSentencia, cone);
        }
        
        public SqlDataReader mConsultarMiembroCarnee(clConexion conexion, clEntidadMiembro pEntidadMiembro)
        {
            strSentencia = "select * from tbMiembros where carnet='"+pEntidadMiembro.getSetCarnetMiembro+"'";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        #endregion
    }
}
