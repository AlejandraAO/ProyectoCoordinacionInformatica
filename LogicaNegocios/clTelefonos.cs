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
    public class clTelefonos
    {
        #region Atributos
        private string strSentencia;
        private SqlDataReader dtrTelefonos;
        #endregion

        #region Metodos

        /**
        Este metodo devuelve todo lo que se encuentre en la tabla tbTitulosProf de la base de datos en ese momento.
        **/

        //public SqlDataReader mConsultaGeneral(clsConexionSQL conexion)
        //{
        //    strSentencia = "Select * from tbTitulosProf";
        //    return conexion.mSeleccionar(strSentencia, conexion);
        //}

        /**
        Este metodo inserta en la tabla tbTitulosProf de la base de datos.
        **/

        public Boolean mInsertar(clConexion conexion, clEntidadTelefonos pEntidadTelefono)
        {
            strSentencia = "Insert into tbTelefonos (idTelefono, telefono, idPersona, tipoPers) values(" +
            pEntidadTelefono.getIdTelefono() + " , " +
            pEntidadTelefono.getTelefono() + " , "+ 
            pEntidadTelefono.getIdPersona()+" , '"+ 
            pEntidadTelefono.getTipoPers() + "')";
            return conexion.mEjecutar(strSentencia, conexion);
        }

        /**
        Este metodo elimina un registro mediante idProfesor y idTitulo en la tabla tbTitulosProf de la base de datos.
        **/

        //public Boolean mEliminar(clsConexionSQL conexion, clEntidadTitulosProfesor pEntidadTitulosProfesor)
        //{
        //    strSentencia = "Delete * from tbTitulosProf where idProfesor = " +
        //    pEntidadTitulosProfesor.getIdProfesor() + " and idTitulo = " +
        //    pEntidadTitulosProfesor.getIdTitulo() + "";
        //    return conexion.mEjecutar(strSentencia, conexion);
        //}

        /**
        Este metodo devulve el id para utilizarlo en la insercion en el frame, lo que devuelve es un numero entero listo para usar.
         **/
        public int idConsecutivo(clConexion conexion)
        {
            strSentencia = "Select count(*) from tbTelefonos";
            dtrTelefonos = conexion.mSeleccionar(strSentencia, conexion);
            int cantidad = 0;
            if (dtrTelefonos != null)
            {
                if (dtrTelefonos.Read())
                {
                    cantidad = dtrTelefonos.GetInt32(0) + 1;
                }
            }
            return cantidad;
        }//Fin del metodo idConsecutivo.

        public SqlDataReader getTelefonos(clConexion conexion, int idPersona)
        {
            strSentencia = "select telefono from tbTelefonos where idPersona ='" + idPersona + "' and tipoPers = 'profesor'";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        #endregion
    }
}
