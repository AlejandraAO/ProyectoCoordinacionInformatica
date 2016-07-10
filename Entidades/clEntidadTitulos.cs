using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public  class clEntidadTitulos
    {
        private int idProfesor;
        private int idTitulo;

        public clEntidadTitulos(int idProfesor, int idTitulo)
        {
            this.idProfesor = idProfesor;
            this.idTitulo = idTitulo;
        }

        public clEntidadTitulos()
        {
            this.idProfesor = 0;
            this.idTitulo = 0;
        }

        public int getIdProfesor()
        {
            return idProfesor;
        }

        public void setIdProfesor(int idProfesor)
        {
            this.idProfesor = idProfesor;
        }

        public int getIdTitulo()
        {
            return idTitulo;
        }

        public void setIdTitulo(int idTitulo)
        {
            this.idTitulo = idTitulo;
        }
    }
}
