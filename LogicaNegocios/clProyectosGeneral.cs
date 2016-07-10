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
    public class clProyectosGeneral
    {
        #region Atributos
        private string strSentencia;
       // private SqlDataReader dtrProyectos;
        #endregion

        #region Metodos

        public SqlDataReader getProyectosCoordinador(clConexion conexion, String identificacion)
        {
            strSentencia = "select py.nombre, py.descripcion, py.estado, py.tipo from tbProyectos py, tbProfesores pf, tbCoordinadoresProy co where pf.identificacion ='"+identificacion+"' and pf.idProfesor = co.idProfesor and co.idProyecto = py.idProyecto";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        public SqlDataReader getProyectosResponsable(clConexion conexion, String  identificacion)
        {
            strSentencia = "select py.nombre, py.descripcion, py.estado, py.tipo from tbProyectos py, tbProfesores pf, tbResponsablesProy re where pf.identificacion ='" + identificacion + "' and pf.idProfesor = re.idProfesor and re.idProyecto = py.idProyecto";
            return conexion.mSeleccionar(strSentencia, conexion);
        }
        public SqlDataReader getProyectosConEstudiantes(clConexion conexion, String identificacion)
        {
            strSentencia = "select py.nombre, py.descripcion, py.estado, py.tipo, pe.horasInve from tbProyectos py, tbProfesores pf, tbProyectosEstu pe where pf.identificacion ='" + identificacion + "' and pf.idProfesor = pe.idProfesor and pe.idProyecto = py.idProyecto";
            return conexion.mSeleccionar(strSentencia, conexion);
        }
        public SqlDataReader getProyectosComoTrabajador(clConexion conexion, String identificacion)
        {
            strSentencia = "select py.nombre, py.descripcion, py.estado, py.tipo, pp.horasInvertidas from tbProyectos py, tbProfesores pf, tbProyectosProf pp where pf.identificacion ='" + identificacion + "' and pf.idProfesor = pp.idProfesor and pp.idProyecto = py.idProyecto";
            return conexion.mSeleccionar(strSentencia, conexion);
        }

        #endregion
    }
}
