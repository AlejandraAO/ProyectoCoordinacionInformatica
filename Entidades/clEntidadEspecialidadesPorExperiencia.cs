using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clEntidadEspecialidadesPorExperiencia
    {
        private int idEspecialidad;
        private String nombre;
        private int tiempoExpe;
        private String area;
        private String puesto;
        private String tipoEmpresa;

        public clEntidadEspecialidadesPorExperiencia(int idEspecialidad, String nombre, int tiempoExpe, String area, String puesto, String tipoEmpresa)
        {
            this.idEspecialidad = idEspecialidad;
            this.nombre = nombre;
            this.tiempoExpe = tiempoExpe;
            this.area = area;
            this.puesto = puesto;
            this.tipoEmpresa = tipoEmpresa;
        }

        public clEntidadEspecialidadesPorExperiencia()
        {

            this.idEspecialidad = 0;
            this.nombre = "";
            this.tiempoExpe = 0;
            this.area = "";
            this.puesto = "";
            this.tipoEmpresa = "";
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

        public int getTiempoExperiencia()
        {
            return tiempoExpe;
        }

        public void setTiempoExpe(int tiempoExpe)
        {
            this.tiempoExpe = tiempoExpe;
        }

        public String getArea()
        {
            return area;
        }

        public void setArea(String area)
        {
            this.area = area;
        }

        public String getPuestoOcupado()
        {
            return puesto;
        }

        public void setPuesto(String puesto)
        {
            this.puesto = puesto;
        }

        public String getTipoEmpresa()
        {
            return tipoEmpresa;
        }

        public void setTipoEmpresa(String tipoEmpresa)
        {
            this.tipoEmpresa = tipoEmpresa;
        }

    }
}
