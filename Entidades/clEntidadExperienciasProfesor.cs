using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clEntidadExperienciasProfesor
    {

        private int idProfesor;
        private int idExperienciaLabo;

        public clEntidadExperienciasProfesor(int idProfesor, int idExperienciaLabo)
        {
            this.idProfesor = idProfesor;
            this.idExperienciaLabo = idExperienciaLabo;
        }

        public clEntidadExperienciasProfesor()
        {
            this.idProfesor = 0;
            this.idExperienciaLabo = 0;
        }

        public int getIdProfesor()
        {
            return idProfesor;
        }

        public void setIdProfesor(int idProfesor)
        {
            this.idProfesor = idProfesor;
        }

        public int getIdExperienciaLabo()
        {
            return idExperienciaLabo;
        }

        public void setIdExperienciaLabo(int idExperienciaLabo)
        {
            this.idExperienciaLabo = idExperienciaLabo;
        }
    }
}
