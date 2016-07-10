using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clEntidadEspecialidadProfesor
    {

        private int idProfesor;
        private int idEspecialidad;

        public clEntidadEspecialidadProfesor(int idProfesor, int idEspecialidad)
        {
            this.idProfesor = idProfesor;
            this.idEspecialidad = idEspecialidad;
        }

        public clEntidadEspecialidadProfesor()
        {
            this.idProfesor = 0;
            this.idEspecialidad = 0;
        }

        public int getIdProfesor()
        {
            return idProfesor;
        }

        public void setIdProfesor(int idProfesor)
        {
            this.idProfesor = idProfesor;
        }

        public int getIdEspecialidad()
        {
            return idEspecialidad;
        }

        public void setIdEspecialidad(int idEspecialidad)
        {
            this.idEspecialidad = idEspecialidad;
        }
    }
}
