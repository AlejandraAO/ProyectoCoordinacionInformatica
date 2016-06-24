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
    public class clProyecto
    {

        //Clase que se encargara de insertar, consultar, modificar y eliminar en la
        //base de datos de la tabla proyectos.
        #region Atributos
        private string strSentencia;
        #endregion

        #region Metodos
        public SqlDataReader mConsultarProyectos(clConexion cone,clEntidadProyecto entidadProyecto)
        {
            strSentencia = "select * from tbProyectos where idProyecto="+entidadProyecto.mIdProyecto+"";
            return cone.mSeleccionar(strSentencia, cone);
        }

        //revisar informacion proyecto en la forma que se inserta un varbinary.
        public Boolean mInsertarProyecto(clConexion cone, clEntidadProyecto pEntidadProyecto)
        {
            strSentencia = "Insert into tbProyectos(nombre,descripcion,estado,tipo,informacion, nombreDocumento)values('" + pEntidadProyecto.mNombre+"','"+pEntidadProyecto.mDescripcion+"','"+pEntidadProyecto.mEstado+"','"+pEntidadProyecto.mTipo+ "', (SELECT * FROM OPENROWSET(BULK N'" + pEntidadProyecto.mInformacioProyecto + "', SINGLE_BLOB) as Pdf), '" + pEntidadProyecto.mNombreDocumento + "')";
            return cone.mEjecutar(strSentencia, cone);
           
          
        }

        public SqlDataReader mConsultaGeneralProyectos(clConexion cone)
        {
            strSentencia = "select * from tbProyectos";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public void mDescargarDocumentoProyecto(clConexion conexion, string ruta, clEntidadProyecto pEntidadProyecto)
        {
            strSentencia = "select informacion from tbProyectos where idProyecto= '" + pEntidadProyecto.mIdProyecto + "'";
            conexion.leer(conexion, ruta, strSentencia);
        }

        public SqlDataReader mConsultarPorNombre(clConexion cone, clEntidadProyecto entidadProyecto)
        {
            strSentencia = "select * from tbProyectos where nombre='" + entidadProyecto.mNombre + "'";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public SqlDataReader mSelecccionarMiembroProyecto(clConexion conexion, int idMiembro)
        {
            strSentencia = "select * from tbtbMiembrosProy where idMiembro=" + idMiembro+ "";
            return conexion.mSeleccionar(strSentencia, conexion);
        }
        #endregion
    }
}
