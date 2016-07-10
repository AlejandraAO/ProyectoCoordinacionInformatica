using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data.SqlClient;
using Entidades;


namespace LogicaNegocios
{
    public class clEspecialidadesPorExperiencia
    {
        #region Atributos

        private String sentencia;

        #endregion


        #region Metodos

        //******************************************************************************
        //Metodo Seleccionar por ID
        //******************************************************************************
        public SqlDataReader mConsultarID(clConexion cone, clEntidadEspecialidadesPorExperiencia pEntidadEspecialidadPorExperiencia)
        {

            sentencia = "Select * from tbEspecialidadesPorExpe where idEspecialidad='" + pEntidadEspecialidadPorExperiencia.getIdEspecialidad() + "'";
            return cone.mSeleccionar(sentencia, cone);

        }

        //******************************************************************************
        //Metodo Consulta General
        //******************************************************************************
        public SqlDataReader mConsultarGeneral(clConexion cone)
        {

            sentencia = "Select * from tbEspecialidadesPorExpe";
            return cone.mSeleccionar(sentencia, cone);

        }

        //*****************************************************************************
        //Metodo Insertar
        //*****************************************************************************
        public Boolean mInsertar(clConexion cone, clEntidadEspecialidadesPorExperiencia pEntidadEspecialidadExperiencia)
        {

            sentencia = "Insert into tbEspecialidadesPorExpe(idEspecialidad,nombre, tiempoExpe, area, puesto, tipoEmpresa) values('" + pEntidadEspecialidadExperiencia.getIdEspecialidad() + "','" + pEntidadEspecialidadExperiencia.getNombre() + "','" + pEntidadEspecialidadExperiencia.getTiempoExperiencia()+"','"+pEntidadEspecialidadExperiencia.getArea()+"','"+pEntidadEspecialidadExperiencia.getPuestoOcupado()+"','"+pEntidadEspecialidadExperiencia.getTipoEmpresa()+"')";
            return cone.mEjecutar(sentencia, cone);

        }

        //*****************************************************************************     
        //Metodo Modificar
        //*****************************************************************************
        public Boolean mModificar(clConexion cone, clEntidadEspecialidadesPorExperiencia pEntidadEspecialidadExperiencia)
         {

             sentencia = "update tbEspecialidadesPorExpe set tiempoExpe='" + pEntidadEspecialidadExperiencia.getTiempoExperiencia() + "', area='" + pEntidadEspecialidadExperiencia.getArea()+ "', puesto='" + pEntidadEspecialidadExperiencia.getPuestoOcupado() + "', tipoEmpresa='" + pEntidadEspecialidadExperiencia.getTipoEmpresa() + "' where idEspecialidad='" + pEntidadEspecialidadExperiencia.getIdEspecialidad() + "'";
             return cone.mEjecutar(sentencia, cone);

         }

        //**************************************************************************
        //Metodo Eliminar
        //**************************************************************************

         public Boolean mEliminar(clConexion cone, clEntidadEspecialidadesPorExperiencia pEntidadEspecialidadExperiencia)
        {

            sentencia = "delete * from tbEspecialidadesPorExpe where idEspecialidad ='"+pEntidadEspecialidadExperiencia.getIdEspecialidad()+"'";
            return cone.mEjecutar(sentencia, cone);

        }

        public SqlDataReader consultaEspecialidadExperienciaProfesor(clConexion cone, int codigoProfesor)
        {
            sentencia = "select max(eep.idEspecialidadExperiencia)+1 from tbEspecialidadExperienciaProfesor eep, tbProfesores p where p.idProfesor = eep.idProfesor and p.idProfesor = '" + codigoProfesor +"'";
            return cone.mSeleccionar(sentencia, cone);

        }
        public SqlDataReader consultaProfesorExperiencia(clConexion cone, int idEspecialidadExperiencia)
        {
            sentencia = "select idProfesor from tbEspecialidadExperienciaProfesor where idEspecialidadExperiencia ='" + idEspecialidadExperiencia + "'";
            return cone.mSeleccionar(sentencia, cone);

        }
        #endregion

    }
}
