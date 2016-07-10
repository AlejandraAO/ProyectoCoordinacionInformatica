using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clEntidadEspecialidadesTitulos
    {
        private int idEspecialidad;
        private String nombre;
        private String descripcion;
        private String institucion;

        public clEntidadEspecialidadesTitulos()
        {
            this.idEspecialidad = 0;
            this.nombre = "";
            this.descripcion = "";
            this.institucion = "";
        }

        public clEntidadEspecialidadesTitulos(int idEspecialidad, String nombre, String descripcion, String institucion)
        {
            this.idEspecialidad = idEspecialidad;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.institucion = institucion;
        }

        public int getIdEspecialidad()
        {
            return idEspecialidad;
        }

        public void setIdEspecialidad(int idEspecialidad)
        {
            this.idEspecialidad = idEspecialidad;
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getDescripcion()
        {
            return descripcion;
        }

        public void setDescripcion(String descripcion)
        {
            this.descripcion = descripcion;
        }

        public String getInstitucion()
        {
            return institucion;
        }

        public void setInstitucion(String institucion)
        {
            this.institucion = institucion;
        }
    }
}
