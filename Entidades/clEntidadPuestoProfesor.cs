using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clEntidadPuestoProfesor
    {
        private int idProfesor;
        private int idEmpresa;
        private int tiempoLaboral;
        private string puesto;

        public clEntidadPuestoProfesor()
        {
            idProfesor = 0;
            idEmpresa = 0;
            tiempoLaboral =0 ;
            puesto = "";
}

        public clEntidadPuestoProfesor(int idProfesor, int idEmpresa, int tiempoLaboral,string puesto)
        {
            this.idProfesor = idProfesor;
            this.idEmpresa = idEmpresa;
            this.tiempoLaboral = tiempoLaboral;
            this.puesto = puesto;
        }

        public int getIdProfesor()
        {
            return idProfesor;
        }

        public void setIdProfesor(int idProfesor)
        {
            this.idProfesor = idProfesor;
        }

        public int getIdEmpresa()
        {
            return idEmpresa;
        }

        public void setIdEmpresa(int idEmpresa)
        {
            this.idEmpresa = idEmpresa;
        }


        public int getTiempoLaboral()
        {
            return tiempoLaboral;
        }

        public void setTiempoLaboral(int tiempoLaboral)
        {
            this.tiempoLaboral = tiempoLaboral;
        }

        public string getPuesto()
        {
            return puesto;
        }

        public void setPuesto(string puesto)
        {
            this.puesto = puesto;
        }
    }
}
