using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clEntidadProfesor
    {
        private int idProfesor;
        private String nombre;
        private String apellido1;
        private String apellido2;
        private String genero;
        private String fechaNaci;
        private String jornada;
        private String estado;
        private String identificacion;
        private String tipoIden;
        private byte[] foto;
        private byte[] curriculum;

        public clEntidadProfesor(int idProfesor, String nombre, String apellido1, String apellido2, String genero, String fechaNaci , String jornada, String estado, String identificacion, String tipoIden,byte[] foto, byte[] curriculum)
        {
            this.idProfesor = idProfesor;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.genero = genero;
            this.fechaNaci = fechaNaci;
            this.jornada = jornada;
            this.estado = estado;
            this.identificacion = identificacion;
            this.tipoIden = tipoIden;
            this.foto = foto;
            this.curriculum = curriculum;
        }
        public clEntidadProfesor() {
            this.idProfesor = 0;
           this.nombre = "";
          this.apellido1 = "";
          this.apellido2 = "";
          this.genero = "";
          this.fechaNaci = "";
          this.jornada = "";
          this.estado = "";
          this.identificacion = "";
          this.tipoIden = "";
          this.foto =null;
          this.curriculum = null;
        }


        public int getIdProfesor()
        {
            return idProfesor;
        }

        public void setIdProfesor(int idProfesor)
        {
            this.idProfesor = idProfesor;
        }

        /**public string getUsuario()
        {
            return this.usuario;
        }

        public void setUsuario(string usuario)
        {
            this.usuario = usuario;
        }**/

        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getApellido1()
        {
            return apellido1;
        }

        public void setApellido1(String apellido1)
        {
            this.apellido1 = apellido1;
        }

        public String getApellido2()
        {
            return apellido2;
        }

        public void setApellido2(String apellido2)
        {
            this.apellido2 = apellido2;
        }

        public String getGenero()
        {
            return genero;
        }

        public void setGenero(String genero)
        {
            this.genero = genero;
        }

        public String getFechaNaci()
        {
            return fechaNaci;
        }

        public void setFechaNaci(String fechaNaci)
        {
            this.fechaNaci = fechaNaci;
           
        }

        public String getJornada()
        {
            return jornada;
        }

        public void setJornada(String jornada)
        {
            this.jornada = jornada;
        }

        public String getEstado()
        {
            return estado;
        }

        public void setEstado(String estado)
        {
            this.estado = estado;
        }

        public String getIdentificacion()
        {
            return identificacion;
        }

        public void setIdentificacion(String identificacion)
        {
            this.identificacion = identificacion;
        }

        public String getTipoIden()
        {
            return tipoIden;
        }

        public void setTipoIden(String tipoIden)
        {
            this.tipoIden = tipoIden;
        }

        public byte[] getFoto()
        {
            return foto;
        }

        public void setFoto(byte[] foto)
        {
            this.foto = foto;
        }

        public byte[] getCurriculum()
        {
            return curriculum;
        }

        public void setCurriculum(byte[] curriculum)
        {
            this.curriculum = curriculum;
        }


    }
}
