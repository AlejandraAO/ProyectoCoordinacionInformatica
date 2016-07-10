using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using AccesoDatos;

namespace LogicaNegocios
{
    public class clEspecialidadesTitulos
    {
        #region Atributos

        private String sentencia;
        SqlDataReader dtrEspecialidadTitulo;

        #endregion


        #region Metodos

        //******************************************************************************
        //Metodo Seleccionar por ID
        //******************************************************************************
        public SqlDataReader mConsultarEspId(clConexion cone,int codigo)
        {

            sentencia = "Select * from tbEspecialidadesTitu where idEspecialidad ='" + codigo + "'";
            return cone.mSeleccionar(sentencia, cone);

        }

        //******************************************************************************
        //Metodo Seleccionar por ID
        //******************************************************************************

        public SqlDataReader mConsultarTablaEspecialidad(clConexion cone, int idProfesor , int codigo )
        {

            sentencia = "Select * from tbEspecialidadesProf where idProfesor ='" + idProfesor + "'and idEspecialidad='"+  codigo + "'";
            return cone.mSeleccionar(sentencia, cone);

        }

        //******************************************************************************
        //Metodo Consulta General
        //******************************************************************************
        public SqlDataReader mConsultarGeneral(clConexion cone)
        {

            sentencia = "Select * from tbEspecialidadesTitu";
            return cone.mSeleccionar(sentencia, cone);

        }

        //******************************************************************************
        //Metodo consecutivos
        //******************************************************************************
        public int idConsecutivo(clConexion conexion)
        {
            sentencia = "Select count(*) from tbEspecialidadesTitu";
            dtrEspecialidadTitulo = conexion.mSeleccionar(sentencia, conexion);
            int cantidad = 0;
            if (dtrEspecialidadTitulo != null)
            {
                if (dtrEspecialidadTitulo.Read())
                {
                    cantidad = dtrEspecialidadTitulo.GetInt32(0) + 1;
                }
            }
            return cantidad;
        }


        //*****************************************************************************
        //Metodo Insertar
        //*****************************************************************************
        public Boolean mInsertarObjeto(clConexion cone, clEntidadEspecialidadesTitulos pEntidadEspecialidadTitulo)
        {

            sentencia = "Insert into tbEspecialidadesTitu (idEspecialidad, nombre, descripcion, institucion) values('" + pEntidadEspecialidadTitulo.getIdEspecialidad() + "','" + pEntidadEspecialidadTitulo.getNombre() + "','" + pEntidadEspecialidadTitulo.getDescripcion() + "','" + pEntidadEspecialidadTitulo.getInstitucion()+"')";
            return cone.mEjecutar(sentencia, cone);

        }


        //*****************************************************************************     
        //Metodo Modificar
        //*****************************************************************************
        public Boolean mModificar(clConexion cone, clEntidadEspecialidadesTitulos pEntidadEspecialidadTitulo)
        {

            sentencia = "update tbEspecialidadesTitu set  nombre='"+pEntidadEspecialidadTitulo.getNombre()+"', descripcion='" + pEntidadEspecialidadTitulo.getDescripcion() + "', institucion='" + pEntidadEspecialidadTitulo.getInstitucion() + "' where idEspecialidad='" + pEntidadEspecialidadTitulo.getIdEspecialidad() + "'";
            return cone.mEjecutar(sentencia, cone);

        }

        //**************************************************************************
        //Metodo Eliminar
        //**************************************************************************

        public Boolean mEliminar(clConexion cone, int codigo)
        {

            sentencia = "delete * from tbEspecialidadesTitu where idEspecialidad =" + codigo + "'";
            return cone.mEjecutar(sentencia, cone);

        }


        #endregion
    }
}
