using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using EntidadNegocios;
using System.Data.SqlClient;

namespace LogicaNegocios
{
    public class clObservavionesPeriodoLaboral
    {
        #region Atributos
        private string strSentencia;
       // private SqlDataReader dtrObservaciones;
        //private SqlDataReader dtrPeriodoLaboral;
        #endregion

        #region Metodos

        public SqlDataReader getObservaciones(clConexion conexion, String identificacion)
        {
            strSentencia = "select o.descripcion, o.observador, o.fecha from tbObservacionesProf o, tbProfesores p where p.identificacion ='" + identificacion + "' and p.idProfesor = o.idProfesor";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        public SqlDataReader getPeriodoLaboral(clConexion conexion, String  identificacion)
        {
            strSentencia = "select pl.fechaIngr, pl.fechaSali from tbPeriodosLaboProf pl, tbProfesores pf where pf.identificacion ='" + identificacion + "' and pf.idProfesor = pl.idProfesor ";
            return conexion.mSeleccionar(strSentencia, conexion);
        }
       
        #endregion
    }
}
