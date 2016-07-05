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
    public class clHorario
    {
        private string sentencia = "";

        public SqlDataReader mConsultarHorarios(clConexion conexion, clEntidadHorario pEntidadHorario)
        {
            sentencia = "select c.sigla, h.dia, h.horaInic, h.horaSali from tbHorarios h, tbHorariosGrupCurs hg, tbCursos c, tbGruposCurs gc where h.idHorario = hg.idHorario and c.idCurso = gc.idCurso and gc.idGrupo = hg.idGrupo";
            return conexion.mSeleccionar(sentencia,conexion);
        }
        public SqlDataReader mConsultarHorarioLaboratorio(clConexion conexion, clEntidadHorario pEntidadHorario, string laboratorio)
        {
            sentencia = "select c.sigla, h.dia, h.horaInic, h.horaSali from tbHorarios h, tbHorariosGrupCurs hg, tbCursos c, tbGruposCurs gc where h.idHorario = hg.idHorario and c.idCurso = gc.idCurso and gc.idGrupo = hg.idGrupo and c.lugar='"+laboratorio+"'";
            return conexion.mSeleccionar(sentencia, conexion);
        }
        public SqlDataReader mConsultarIdHorario(clConexion conexion)
        {
            sentencia = "select idHorario from tbHorarios'";
            return conexion.mSeleccionar(sentencia, conexion);
        }
        public SqlDataReader mConsultarHorario(clConexion conexion)
        {
            sentencia = "Select * from tbHorarios ";
            return conexion.mSeleccionar(sentencia, conexion);
        }


        public Boolean mInsertarHorario(clConexion conexion, clEntidadHorario pEntidadHorario)
        {
            sentencia = "insert into tbHorarios (dia,horaInic,horaSali) values('" + pEntidadHorario.mDia + "', '" + pEntidadHorario.mHoraInicio + "', '" + pEntidadHorario.mHoraSalida + "') ";
            return conexion.mEjecutar(sentencia, conexion);
        }


        public Boolean mModificarHorario(clConexion conexion, clEntidadHorario pEntidadHorario)
        {

            sentencia = "update tbHorarios set dia = '" + pEntidadHorario.mDia + "', horaInic = '" + pEntidadHorario.mHoraInicio + "', horaSali ='" + pEntidadHorario.mHoraSalida+"' ";
            return conexion.mEjecutar(sentencia, conexion);
        }

        public SqlDataReader mConsultarHorarioProfesor(clConexion conexion, int idProfesor)
        {
            sentencia= "select c.sigla, h.dia, h.horaInic, h.horaSali from tbProfesores p, tbProfesoresGrupCurs pg, tbHorarios h, tbHorariosGrupCurs hg, tbCursos c, tbGruposCurs gc where h.idHorario = hg.idHorario and c.idCurso = gc.idCurso and gc.idGrupo = hg.idGrupo and pg.idGrupo=gc.idGrupo and pg.idProfesor=p.idProfesor and p.idProfesor='"+idProfesor+"'";
            return conexion.mSeleccionar(sentencia,conexion);
        }

        public SqlDataReader mConsultarProfesores(clConexion conexion)
        {
            sentencia = "select idProfesor,nombre,apaellido1,apellido2 from tbProfesores";
            return conexion.mSeleccionar(sentencia, conexion);
        }
    }
}
