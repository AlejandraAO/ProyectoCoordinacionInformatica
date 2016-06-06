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
        public Boolean mInsertarMiembro(clConexion cone, clEntidadMiembro pEntidadMiembro)
        {
            strSentencia = "insert into tbMiembros(tipo,nombre, apellido1, apellido2, carrera) values('" + pEntidadMiembro.getSetTipo + "','" + pEntidadMiembro.getSetNombreMiembro+"', '"+pEntidadMiembro.getSetApellido1Miembro+"', '"+pEntidadMiembro.getSetApellido2Miembro+"',  '"+pEntidadMiembro.getSetCarreraMiembro+"')";
            return cone.mEjecutar(strSentencia, cone);
        }
        public Boolean mModificarMiembro(clConexion cone, clEntidadMiembro pEntidadMiembro)
        {
            strSentencia = "";
            return cone.mEjecutar(strSentencia, cone);
        }
        #endregion
    }
}
