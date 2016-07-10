using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using AccesoDatos;
using Entidades;


namespace LogicaNegocios
{
    public class clsTitulosProfesor
    {
        #region Atributos
        private string strSentencia;
        SqlDataReader dtrTituloProf;
        //  clEntidadTituloProfesor pEntidadTitulosProfesor;


        public clsTitulosProfesor()
        {
            strSentencia = "";
        }

        #endregion

        #region Metodos

        /**
        Este metodo devuelve todo lo que se encuentre en la tabla tbTitulos de la base de datos en ese momento.
        **/

        public SqlDataReader mConsultaGeneral(clConexion conexion)
        {
            strSentencia = "Select * from tbTitulos";
            return conexion.mSeleccionar(strSentencia, conexion);
        }
        //***********************************************************************************************
        //***********************************************************************************************
        //***********************************************************************************************
        /**
       Este metodo devuelve todo lo que se encuentre en la tabla tbTitulos por codigo de titulo por la identificacion de la base de datos en ese momento.
       **/

        public SqlDataReader mConsultaCodigoTitulo(clConexion conexion, int codigo)
        {
            strSentencia = "Select * from tbTitulos where idTitulo=" + codigo + "";
            return conexion.mSeleccionar(strSentencia, conexion);
        }
        //***********************************************************************************************
        //***********************************************************************************************
        //***********************************************************************************************
        /**
        Este metodo inserta en la tabla tbTitulosProf de la base de datos.
        **/

        public Boolean mInsertar(clConexion conexion, clEntidadTituloProfesor pEntidadTitulosProfesor)
        {

            strSentencia = "insert into tbTitulos(idTitulo, nombre,institucion,fecha,tipo) values('" +
                pEntidadTitulosProfesor.getcodigo() + "','" +
                pEntidadTitulosProfesor.getnombre() + "','" +
                pEntidadTitulosProfesor.getinstitucion() + "','" +
                pEntidadTitulosProfesor.getFechaTitulo() + "','" +
               pEntidadTitulosProfesor.gettipo() + "')";
            return conexion.mEjecutar(strSentencia, conexion);

        }
        //***********************************************************************************************
        //***********************************************************************************************
        //***********************************************************************************************
        public Boolean mInsertarTtitulosProfesor(clConexion conexion, clEntidadTituloProfesor pEntidadTitulosProfesor, String identificacionProfesor)
        {

            strSentencia = "insert into tbTitulosProf(idProfesor, idTitulo) values('" +
                  identificacionProfesor + "','" +
              pEntidadTitulosProfesor.getcodigo() + "')";
            return conexion.mEjecutar(strSentencia, conexion);

        }

        /**
        Este metodo elimina un registro mediante idProfesor y idTitulo en la tabla tbTitulosProf de la base de datos.
        **/

        public Boolean mEliminar(clConexion conexion, int codigo)
        {
            strSentencia = "Delete * from tbTitulos where idTitulo = " + codigo + " ";
            return conexion.mEjecutar(strSentencia, conexion);
        }

        //***********************************************************************************************
        //***********************************************************************************************
        //***********************************************************************************************
        public Boolean mModificar(clConexion conexion, clEntidadTituloProfesor pEntidadTitulosProfesor)
        {
            strSentencia = "update tbTitulos set  nombre=' " + pEntidadTitulosProfesor.getnombre() + 
                 "',institucion= '" + pEntidadTitulosProfesor.getinstitucion() + "',fecha='" +
                  pEntidadTitulosProfesor.getFechaTitulo() + "',tipo='" + pEntidadTitulosProfesor.gettipo() + "' where idTitulo ='"+pEntidadTitulosProfesor.getcodigo() +"'";
            return conexion.mEjecutar(strSentencia, conexion);
        }
        //***********************************************************************************************
        //***********************************************************************************************
        //***********************************************************************************************
        public int idConsecutivo(clConexion conexion)
        {
            strSentencia = "Select count(*) from tbTitulos";
          dtrTituloProf = conexion.mSeleccionar(strSentencia, conexion);
            int cantidad = 0;
            if (dtrTituloProf != null)
            {
                if (dtrTituloProf.Read())
                {
                    cantidad = dtrTituloProf.GetInt32(0) + 1;
                }
            }
            return cantidad;
        }

        //***********************************************************************************************
        //***********************************************************************************************
        //***********************************************************************************************
        public SqlDataReader ConsultaGeneral(clConexion conexion)
        {
            strSentencia = "select * from tbTitulos "  ;
            return conexion.mSeleccionar(strSentencia, conexion);
        }
        //***********************************************************************************************
        //***********************************************************************************************
        //***********************************************************************************************
        public SqlDataReader ConsultaComparacionDatos(clConexion conexion, int codigoProfe,int idTitulo)
        {
            strSentencia = "select * from tbTitulosProf where idProfesor='" + codigoProfe + "' and idTitulo='"+ idTitulo+"'";
            return conexion.mSeleccionar(strSentencia, conexion);
        }
        //***********************************************************************************************
        //***********************************************************************************************
        //***********************************************************************************************
       
        #endregion
    }
}
