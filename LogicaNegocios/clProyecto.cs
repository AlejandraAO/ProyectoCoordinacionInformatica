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
        public SqlDataReader mConsultarProyectos(clConexion cone)
        {
            strSentencia = "select * from tbProyectos";
            return cone.mSeleccionar(strSentencia, cone);
        }
        //public SqlDataReader mConsultarCantidadViajes(clConexion cone, clEntidadProyecto pEntidadProyecto)
        //{
        //    strSentencia = "select cantidadPersonas from tbViaje where numViaje='" + pEntidadVIaje.getNumViaje() + "'";
        //    return cone.mSeleccionar(strSentencia, cone);
        //}

            //revisar informacion proyecto en la forma que se inserta un varbinary.
        public Boolean mInsertarProyecto(clConexion cone, clEntidadProyecto pEntidadProyecto)
        {
            strSentencia = "Insert into tbProyectos(idProyecto,nombre,descripcion,estado,tipo,informacion)values(" +pEntidadProyecto.mIdProyecto + "'"+pEntidadProyecto.mNombre+"''"+pEntidadProyecto.mDescripcion+"''"+pEntidadProyecto.mEstado+"''"+pEntidadProyecto.mTipo+"'"+pEntidadProyecto.mInformacioProyecto+")";
            return cone.mEjecutar(strSentencia, cone);
        }

        //public Boolean mModificarViaje(clConexion cone, clEntidadProyecto pEntidadProyecto)
        //{
        //    strSentencia = "Update tbViaje set cantidadPersonas=" + pEntidadViaje.getCantidadPersona() + "  where numViaje= '" + pEntidadViaje.getNumViaje() + "'";
        //    return cone.mEjecutar(strSentencia, cone);
        //}
        #endregion
    }
}
