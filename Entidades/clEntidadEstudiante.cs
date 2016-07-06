using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadNegocios
{
    public class clEntidadEstudiante
    {
        private int idEstudiante;
        private string carnet;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private int cedula;
        private string fechaNacimiento;
        private string genero;
        private string institucion;
        private string carrera;
        private byte [] foto;

        public clEntidadEstudiante(int idEstudiante, string carnet, string nombre, string apellido1, string apellido2, int cedula, string fechaNacimiento, string genero, string institucion, string carrera, byte [] foto)
        {
            this.idEstudiante = idEstudiante;
            this.carnet = carnet;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.cedula = cedula;
            this.fechaNacimiento = fechaNacimiento;
            this.genero = genero;
            this.institucion = institucion;
            this.carrera = carrera;
            this.foto = foto;
        }

        public clEntidadEstudiante()
        {
            this.idEstudiante = 0;
            this.carnet = "";
            this.nombre = "";
            this.apellido1 = "";
            this.apellido2 = "";
            this.cedula = 0;
            this.fechaNacimiento = "";
            this.genero = "";
            this.institucion = "";
            this.carrera = "";
            this.foto = null;
        }

        public void setIdEstudiante(int idEstudiante)
        {
            this.idEstudiante = idEstudiante;
        }
        public int getIdEstudiante()
        {
            return idEstudiante;
        }

        public void setCarnet(string carnet)
        {
            this.carnet = carnet;
        }
        public string getCarnet()
        {
            return carnet;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setApellido1(string apellido1)
        {
            this.apellido1 = apellido1;
        }
        public string getApellido1()
        {
            return apellido1;
        }
        public void setApellido2(string apellido2)
        {
            this.apellido2 = apellido2;
        }
        public string getApellido2()
        {
            return apellido2;
        }
        public void setCedula(int cedula)
        {
            this.cedula = cedula;
        }
        public int getCedula()
        {
            return cedula;
        }
        public void setFechaNacimiento(String fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        public string getFechaNacimiento()
        {
            return fechaNacimiento;
        }

        public void setGenero(String genero)
        {
            this.genero = genero;
        }
        public string getGenero()
        {
            return genero;
        }

        public void setInstitucion(string institucion)
        {
            this.institucion = institucion;
        }
        public string getInstitucion()
        {
            return institucion;
        }

        public void setCarrera(string carrera)
        {
            this.carrera = carrera;
        }
        public string getCarrera()
        {
            return carrera;
        }

        public void setFoto(byte [] foto)
        {
            this.foto = foto;
        }
        public byte [] getFoto()
        {
            return foto;
        }
    }
}
