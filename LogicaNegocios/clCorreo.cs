using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;
using System.Data.SqlClient;

namespace LogicaNegocios
{
    public class clCorreo
    {
        #region Atributos
        private string strSentencia;
        private SqlDataReader dtrCorreo;
        #endregion
        #region Metodos
        public Boolean mInsertar(clConexion conexion, clEntidadCorreos pEntidadCorreo)
        {
            strSentencia = "Insert into tbCorreos (idCorreo, idPersona, tipoPersona, correo ) values(" +
            pEntidadCorreo.getIdCorreo() + " , " +
            pEntidadCorreo.getIdPersona() + " , '" +
            pEntidadCorreo.getTipoPers() + "' , '" +
            pEntidadCorreo.getCorreo() + "')";
            return conexion.mEjecutar(strSentencia, conexion);
        }

        public int idConsecutivo(clConexion conexion)
        {
            strSentencia = "Select count(*) from tbCorreos";
            dtrCorreo = conexion.mSeleccionar(strSentencia, conexion);
            int cantidad = 0;
            if (dtrCorreo != null)
            {
                if (dtrCorreo.Read())
                {
                    cantidad = dtrCorreo.GetInt32(0) + 1;
                }
            }
            return cantidad;
        }//Fin del metodo idConsecutivo.

        public SqlDataReader getCorreos(clConexion conexion, int idPersona)
        {
            strSentencia = "select correo from tbCorreos where idPersona ='" + idPersona + "' and tipoPersona = 'profesor'";
            return conexion.mSeleccionar(strSentencia, conexion);
        }
        #endregion
    }
}
