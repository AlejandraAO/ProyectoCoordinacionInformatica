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
    }
}
