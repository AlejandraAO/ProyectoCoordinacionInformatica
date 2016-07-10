using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace LogicaNegocios
{
    public class clProfesor
    {
        #region Atributos
        private string strSentencia;
        private SqlDataReader dtrProfesor;
        #endregion
        #region Metodos
        public int mDevolverId(clConexion cone, string identificacion)
        {
            int idProfesor = 0;
            strSentencia = "Select idProfesor from tbProfesores where identificacion = "+ identificacion + "";
            dtrProfesor = cone.mSeleccionar(strSentencia, cone);
            if (dtrProfesor != null)
            {
                while (dtrProfesor.Read())
                {
                    idProfesor = dtrProfesor.GetInt32(0);
                }
            }
            return idProfesor;
        }
        /**
        metodo para llenar el combo de la busqueda de proyectos
        **/
        public SqlDataReader mLlenarCombo(clConexion cone)
        {
            strSentencia = "Select identificacion from tbProfesores";
            return cone.mSeleccionar(strSentencia, cone);
        }

        /**
        Este metodo devuelve una consulta mediante el idProfesor especifico.
        **/
        public SqlDataReader mConsultarIdProfesor(clConexion conexion, clEntidadProfesor pEntidadProfesor)
        {
            strSentencia = "select * from tbProfesores where idProfesor = '" +
            pEntidadProfesor.getIdProfesor() + "'";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        /**
        Este metodo se necesita en el frame de consultarprofesor.
        **/
        public SqlDataReader mConsultarPorFiltro(clConexion conexion, String dato, String filtro)
        {
            if (filtro == "IDENTIFICACION")
            {
                strSentencia = "select * from tbProfesores where identificacion = '" + dato + "'";
                return conexion.mSeleccionar(strSentencia, conexion);
            }
            if (filtro == "GENERO")
            {
                strSentencia = "select * from tbProfesores where genero = '" + dato + "'";
                return conexion.mSeleccionar(strSentencia, conexion);
            }
            if (filtro == "JORNADA")
            {
                strSentencia = "select * from tbProfesores where jornada = '" + dato + "'";
                return conexion.mSeleccionar(strSentencia, conexion);
            }
            if (filtro == "ESTADO")
            {
                strSentencia = "select * from tbProfesores where estado = '" + dato + "'";
                return conexion.mSeleccionar(strSentencia, conexion);
            }
            else
            {
                return null;
            }
        }

        public SqlDataReader mConsultarExistencia(clConexion conexion, int id)
        {
            strSentencia = "select * from tbProfesores where idProfesor = " + id + "";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        /**
        Este metodo devuelve todo lo que se encuentre en la tabla tbProfesores de la base de datos en ese momento.
        **/

        public SqlDataReader mConsultaGeneral(clConexion conexion)
        {
            strSentencia = "Select * from tbProfesores";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        

        /**
       Este metodo devulve el id para verifacar si existe el numero de identificacion en la base de datos
       **/

        public SqlDataReader mConsultaPorCodigo(clConexion conexion, int codigo)
        {
            strSentencia = "select * from tbProfesores where idProfesor = '" + codigo + "'";
            return conexion.mSeleccionar(strSentencia, conexion);
                    
        }


        public SqlDataReader mConsultaPoridentificacion(clConexion conexion, string identificacion)
        {
            strSentencia = "select * from tbProfesores where identificacion = '" + identificacion + "'";
            return conexion.mSeleccionar(strSentencia, conexion);
        }
        /**
        Este metodo devulve el id para utilizarlo en la insercion en el frame, lo que devuelve es un numero entero listo para usar.
        **/
        public int idConsecutivo(clConexion conexion)
        {
            strSentencia = "Select MAX(idProfesor) from tbProfesores";
            dtrProfesor = conexion.mSeleccionar(strSentencia, conexion);
            int cantidad = 0;
            if (dtrProfesor != null)
            {
                if (dtrProfesor.Read())
                {
                    cantidad = dtrProfesor.GetInt32(0) + 1;
                }
            }
            return cantidad;
        }//Fin del metodo idConsecutivo.

        public Boolean mInsertar(clConexion conexion, clEntidadProfesor pEntidadProfesor)
        {
              try
              {
                  SqlConnection cn = new SqlConnection(conexion.getDatosConexion(conexion));
                  using (SqlCommand cmd = cn.CreateCommand())
                  {
                      cn.Open();
                      cmd.CommandText = "insert into tbProfesores(idProfesor,nombre,apellido1,apellido2, genero, fechaNaci, jornada,estado, identificacion, tipoIden,foto,curriculum) values (@idProfesor,@nombre, @apellido1,@apellido2, @genero, @fechaNaci, @jornada, @estado, @identificacion, @tipoIden,@foto,@curriculum)";
                      cmd.Parameters.Add("@idProfesor", System.Data.SqlDbType.Int).Value = pEntidadProfesor.getIdProfesor();
                      cmd.Parameters.Add("@nombre", System.Data.SqlDbType.NVarChar).Value = pEntidadProfesor.getNombre();
                      cmd.Parameters.Add("@apellido1", System.Data.SqlDbType.NVarChar).Value = pEntidadProfesor.getApellido1();
                      cmd.Parameters.Add("@apellido2", System.Data.SqlDbType.NVarChar).Value = pEntidadProfesor.getApellido2();
                      cmd.Parameters.Add("@genero", System.Data.SqlDbType.NVarChar).Value = pEntidadProfesor.getGenero();
                      cmd.Parameters.Add("@fechaNaci", System.Data.SqlDbType.Date).Value = pEntidadProfesor.getFechaNaci();
                      cmd.Parameters.Add("@jornada", System.Data.SqlDbType.NVarChar).Value = pEntidadProfesor.getJornada();
                      cmd.Parameters.Add("@estado", System.Data.SqlDbType.NVarChar).Value = pEntidadProfesor.getEstado();
                      cmd.Parameters.Add("@identificacion", System.Data.SqlDbType.NVarChar).Value = pEntidadProfesor.getIdentificacion();
                      cmd.Parameters.Add("@tipoIden", System.Data.SqlDbType.NVarChar).Value = pEntidadProfesor.getTipoIden();
                      cmd.Parameters.Add("@foto", System.Data.SqlDbType.VarBinary).Value = pEntidadProfesor.getFoto();
                    cmd.Parameters.Add("@curriculum", System.Data.SqlDbType.VarBinary).Value = pEntidadProfesor.getCurriculum();
                    cmd.ExecuteNonQuery();
                      cn.Close();
                  }
              }
              catch (Exception ex)
              {
                  throw new Exception(ex.Message);
              }
            return conexion.mEjecutar(strSentencia, conexion);
        }

        /**
        Este metodo modfica en la tabla tbProfesores de la base de datos.
        **/

        public Boolean mModificar(clConexion conexion, clEntidadProfesor pEntidadProfesor)
        {
            try
            {
                SqlConnection cn = new SqlConnection(conexion.getDatosConexion(conexion));
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cn.Open();
                    cmd.CommandText = "Update tbProfesores set nombre=@nombre, apellido1=@apellido1, apellido2=@apellido2, genero=@genero, fechaNaci=@fechaNaci, jornada=@jornada, estado=@estado, identificacion=@identificacion, tipoIden=@tipoIden, foto=@foto, curriculum=@curriculum where idProfesor=@idProfesor";
                    cmd.Parameters.Add("@idProfesor", System.Data.SqlDbType.Int).Value = pEntidadProfesor.getIdProfesor();
                    cmd.Parameters.Add("@nombre", System.Data.SqlDbType.NVarChar).Value = pEntidadProfesor.getNombre();
                    cmd.Parameters.Add("@apellido1", System.Data.SqlDbType.NVarChar).Value = pEntidadProfesor.getApellido1();
                    cmd.Parameters.Add("@apellido2", System.Data.SqlDbType.NVarChar).Value = pEntidadProfesor.getApellido2();
                    cmd.Parameters.Add("@genero", System.Data.SqlDbType.NVarChar).Value = pEntidadProfesor.getGenero();
                    cmd.Parameters.Add("@fechaNaci", System.Data.SqlDbType.Date).Value = pEntidadProfesor.getFechaNaci();
                    cmd.Parameters.Add("@jornada", System.Data.SqlDbType.NVarChar).Value = pEntidadProfesor.getJornada();
                    cmd.Parameters.Add("@estado", System.Data.SqlDbType.NVarChar).Value = pEntidadProfesor.getEstado();
                    cmd.Parameters.Add("@identificacion", System.Data.SqlDbType.NVarChar).Value = pEntidadProfesor.getIdentificacion();
                    cmd.Parameters.Add("@tipoIden", System.Data.SqlDbType.NVarChar).Value = pEntidadProfesor.getTipoIden();
                    cmd.Parameters.Add("@foto", System.Data.SqlDbType.VarBinary).Value = pEntidadProfesor.getFoto();
                    cmd.Parameters.Add("@curriculum", System.Data.SqlDbType.VarBinary).Value = pEntidadProfesor.getCurriculum();
                    cmd.ExecuteNonQuery();              
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return conexion.mEjecutar(strSentencia, conexion);
        }

        /**
        Este metodo elimina un registro mediante idProfesor en la tabla tbProfesores de la base de datos.
        **/

        public Boolean mEliminar(clConexion conexion, int codProfesor)
        {
            try
            {
                SqlConnection cn = new SqlConnection(conexion.getDatosConexion(conexion));
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cn.Open();
                    cmd.CommandText = "Delete from tbProfesores where idProfesor=@idProfesor";
                    cmd.Parameters.Add("@idProfesor", System.Data.SqlDbType.Int).Value = codProfesor;
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return conexion.mEjecutar(strSentencia, conexion);
        }


        //TELEFONO&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%

        public SqlDataReader mConsultaTelefonos(clConexion conexion, int codigo)
        {
            strSentencia = "select * from tbTelefonos where idPersona = '" + codigo + "'";
            return conexion.mSeleccionar(strSentencia, conexion);
        }
        //CORREOS%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&
        public SqlDataReader mConsultaorreos(clConexion conexion, int codigo)
        {
            strSentencia = "select * from tbCorreos where idPersona = '" + codigo + "'";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        #endregion
    }
}
