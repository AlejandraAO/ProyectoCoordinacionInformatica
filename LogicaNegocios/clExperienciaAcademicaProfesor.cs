using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Data.SqlClient;



namespace LogicaNegocios
{
    public class clExperienciaAcademicaProfesor
    {
        #region Atributos
        SqlDataReader dtrExperiencias;
        private String sentencia;

        #endregion


        #region Metodos


        //******************************************************************************
        //Metodo Seleccionar por ID
        //******************************************************************************
        public Boolean mConsultarID(clConexion cone, int idExperiencia, String identificacion)
        {
            Boolean salida = false;
            sentencia = "Select ea.idExperienciaLabo, ea.tiempo from tbProfesores pf, tbExperienciasProf ep, tbExperienciasAcad ea where pf.identificacion = '" + identificacion + "' and pf.idProfesor = ep.idProfesor and ep.idExperienciaLabo = ea.idExperienciaLabo and ea.idExperienciaLabo = " + idExperiencia + "";
            this.dtrExperiencias = cone.mSeleccionar(sentencia, cone);
            if (dtrExperiencias != null)
            {
                while (dtrExperiencias.Read())
                {
                    salida = true;
                }
            }
            return salida;
        }

        //******************************************************************************
        //Metodo Consulta y devuelve solo un registro
        //******************************************************************************
        public SqlDataReader mDevolverUnRegistro(clConexion cone, int idExperienciaLab, String identificacion)
        {
            sentencia = "Select ea.tiempo, ea.tipoCarg from tbProfesores pf, tbExperienciasAcad ea, tbExperienciasProf ep where pf.identificacion = '"+ identificacion + "' and pf.idProfesor = ep.idProfesor and ep.idExperienciaLabo = ea.idExperienciaLabo and ea.idExperienciaLabo = "+ idExperienciaLab + "";
            return cone.mSeleccionar(sentencia, cone);

        }

        //******************************************************************************
        //Metodo Consulta General
        //******************************************************************************
        public SqlDataReader mConsultarGeneral(clConexion cone)
        {

            sentencia = "Select * from tbExperienciasAcad";
            return cone.mSeleccionar(sentencia, cone);

        }
        
        //*****************************************************************************
        //Metodo Insertar
        //*****************************************************************************
        public Boolean mInsertar(clConexion cone, clEntidadExperienciaAcademica pEntidadExperienciaAcademica, clEntidadExperienciasProfesor pEntidadExperienciasProfesor)
        {
            sentencia = "Insert into tbExperienciasAcad (idExperienciaLabo, tiempo, tipoCarg) values('" + pEntidadExperienciaAcademica.getIdExperienciaLabo() + "','" + pEntidadExperienciaAcademica.getTiempo() + "','" + pEntidadExperienciaAcademica.getTipoCarg() + "')";
            Boolean tbExperienciasAcad = cone.mEjecutar(sentencia, cone);
            Boolean TbExperienciasProf = this.mInsertarTbExperienciasProf(cone, pEntidadExperienciasProfesor);
            if (tbExperienciasAcad && TbExperienciasProf)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public Boolean mInsertarTbExperienciasProf(clConexion cone, clEntidadExperienciasProfesor pEntidadExperienciasProfesor)
        {
            sentencia = "Insert into tbExperienciasProf (idProfesor, idExperienciaLabo) values (" + pEntidadExperienciasProfesor.getIdProfesor() + ", "+ pEntidadExperienciasProfesor.getIdExperienciaLabo() + ")";
            return cone.mEjecutar(sentencia, cone);
        }

        //*****************************************************************************     
        //Metodo Modificar
        //*****************************************************************************
        public Boolean mModificar(clConexion cone, clEntidadExperienciaAcademica pEntidadExperienciaAcademica)
        {
            sentencia = "update tbExperienciasAcad set tiempo = " + pEntidadExperienciaAcademica.getTiempo() + ", tipoCarg='" + pEntidadExperienciaAcademica.getTipoCarg() + "' where idExperienciaLabo = " + pEntidadExperienciaAcademica.getIdExperienciaLabo() + "";
            return cone.mEjecutar(sentencia, cone);
        }

        //**************************************************************************
        //Metodo Eliminar
        //**************************************************************************

        public Boolean mEliminarEnTabla(clConexion cone, clEntidadExperienciaAcademica pEntidadExperienciaAcademica)
        {
            sentencia = "delete  from tbExperienciasAcad where idExperienciaLabo =" + pEntidadExperienciaAcademica.getIdExperienciaLabo() + "";
            return cone.mEjecutar(sentencia, cone);
            
        }
        
        //**************************************************************************
        //Metodo Eliminar en la tabla de muchos a muchos tbExperienciasProf
        //**************************************************************************

        public Boolean mEliminarTbExperienciasProf(clConexion cone, clEntidadExperienciasProfesor pEntidadExperienciasProfesor)
        {
            sentencia = "delete  from tbExperienciasProf where idExperienciaLabo =" + pEntidadExperienciasProfesor.getIdExperienciaLabo() + " and idProfesor = "+ pEntidadExperienciasProfesor.getIdProfesor() + "";
            return cone.mEjecutar(sentencia, cone);
        }


        #endregion
    }
}
