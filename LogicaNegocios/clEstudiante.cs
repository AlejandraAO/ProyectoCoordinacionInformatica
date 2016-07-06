using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AccesoDatos;
using EntidadNegocios;


namespace LogicaNegocios
{
    public class clEstudiante
    {

        #region Atributos
        private string strSentencia;
        #endregion

        #region Metodos
        public Boolean mInsertar(clConexion cone, clEntidadEstudiante pEntidadEstudiante)
        { 
            strSentencia = "Insert into tbEstudiantes(idEstudiante,carnet, nombre, apellido1, apellido2, cedula, fechaNaci, genero, institucion, carrera, foto) values(" +
                            pEntidadEstudiante.getIdEstudiante()+" ,'"+
                            pEntidadEstudiante.getCarnet() + "','" + pEntidadEstudiante.getNombre() + "','" +
                            pEntidadEstudiante.getApellido1() + "','" + pEntidadEstudiante.getApellido2() + "', " +
                            pEntidadEstudiante.getCedula() + ",'" + pEntidadEstudiante.getFechaNacimiento() + "', '" +
                            pEntidadEstudiante.getGenero() + "','" + pEntidadEstudiante.getInstitucion() +
                            "','" + pEntidadEstudiante.getCarrera() + "', '" + pEntidadEstudiante.getFoto() + "')";
            return cone.mEjecutar(strSentencia, cone);
        }

        /*public Boolean mInsertar(clsConexionSQL cone, clEntidadEstudiante pEntidadEstudiante)
        {
            strSentencia = "Insert into tbEstudiantes(carnet, nombre, apellido1, apellido2, cedula, fechaNaci, genero, institucion, carrera, foto) values('" +
                            pEntidadEstudiante.getCarnet() + "','" + pEntidadEstudiante.getNombre() + "','" +
                            pEntidadEstudiante.getApellido1() + "','" + pEntidadEstudiante.getApellido2() + "', " +
                            pEntidadEstudiante.getCedula() + ",'" + pEntidadEstudiante.getFechaNacimiento() + "', '" +
                            pEntidadEstudiante.getGenero() + "','" + pEntidadEstudiante.getInstitucion() +
                            "','" + pEntidadEstudiante.getCarrera() + "', '" + pEntidadEstudiante.getFoto() + "')";
            return cone.mEjecutar(strSentencia, cone);
        }*/

        public Boolean mModificar(clConexion cone, clEntidadEstudiante pEntidadEstudiante)
        {
            strSentencia = "Update tbEstudiantes set nombre='" + pEntidadEstudiante.getNombre() +
                "', apellido1='" + pEntidadEstudiante.getApellido1() +
                "',apellido2='" + pEntidadEstudiante.getApellido2() + "', cedula=" + pEntidadEstudiante.getCedula() +
                ",fechaNaci='" + pEntidadEstudiante.getFechaNacimiento() + "', genero='" + pEntidadEstudiante.getGenero() 
                +"', institucion='" + pEntidadEstudiante.getInstitucion() +
                "',carrera='" + pEntidadEstudiante.getCarrera() + "', foto=" + pEntidadEstudiante.getFoto() +
                " where carnet='" + pEntidadEstudiante.getCarnet() + "'";
            return cone.mEjecutar(strSentencia, cone);
        }

        public Boolean mEliminarEstudiante(clConexion cone, clEntidadEstudiante pEntidadEstudiante)
        {
            strSentencia = "Delete from tbEstudiantes where carnet = '"+pEntidadEstudiante.getCarnet()+"'";

            return cone.mEjecutar(strSentencia, cone);
        }

        public SqlDataReader mConsultarCarnet(clConexion cone, clEntidadEstudiante pEntidadEstudiante)
        {
            strSentencia = "select * from tbEstudiantes where carnet= '" + pEntidadEstudiante.getCarnet() + "'";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public SqlDataReader mConsultaGeneral(clConexion cone)
        {
            strSentencia = "Select * from tbEstudiantes";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public SqlDataReader mConsultaGeneralCorreos(clConexion cone)
        {
            strSentencia = "Select * from tbCorreos";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public SqlDataReader mConsultaGeneralTelefonos(clConexion cone)
        {
            strSentencia = "Select * from tbTelefonos";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public Boolean mIngresarCorreo(clConexion cone, int idEstudiante, int correo, int IdCorreo)
        {
            strSentencia = "Insert into tbCorreos(idCorreo, idPersona, tipoPersona, correo) values ("+IdCorreo+","+idEstudiante + ",'Estudiante','"+correo+"')";
            return cone.mEjecutar(strSentencia,cone);
        }

        public Boolean mIngresarTelefono(clConexion cone, int idEstudiante, int telefono, int idTelefono)
        {
            strSentencia = "Insert into tbTelefonos(idTelefono, telefono, idPersona, tipoPers) values ("+idTelefono+","+telefono+","+idEstudiante+",'Estudiante')";
            return cone.mEjecutar(strSentencia,cone);
        }

        public SqlDataReader mConsultarIdEstudiante(clConexion cone, string carnet)
        {
            strSentencia = "Select idEstudiante from tbEstudiantes where carnet = '"+carnet+"'";
            return cone.mSeleccionar(strSentencia,cone);
        }

        public SqlDataReader mConsultaEmpresas(clConexion cone)
        {
            strSentencia = "Select * from tbEmpresas";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public SqlDataReader mConsultarTelefono(clConexion cone, int idEstuidnte)
        {
            strSentencia = "Select * from tbTelefonos where idEstudiante= "+idEstuidnte+"";
            return cone.mSeleccionar(strSentencia, cone);
        }


        public SqlDataReader mConsultarCorreo(clConexion cone, int idEstuidnte)
        {
            strSentencia = "Select * from tbCorreos where idEstudiante= " + idEstuidnte + "";
            return cone.mSeleccionar(strSentencia, cone);
        }

    }

        #endregion


    }
