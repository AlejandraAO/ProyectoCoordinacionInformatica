using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clEntidadTituloProfesor
    {
        private int codigo;
        private String nombre;
        private String institucion;
        private String fecha;
        private String tipo;

        public clEntidadTituloProfesor(int codigo,string nombre,string institucion,string fecha,string tipo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.institucion = institucion;
            this.fecha = fecha;
            this.tipo = tipo;

        }

        public int getcodigo()
        {
            return codigo;
        }

        public void setcodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public String getnombre()
        {
            return nombre;
        }

        public void setGenero(string nombre)
        {
            this.nombre = nombre;
        }

        public String getFechaTitulo()
        {
            return fecha;
        }

        public void setFechaTitulo(String fecha)
        {
            this.fecha = fecha;
        }
        public String getinstitucion()
        {
            return institucion;
        }

        public void setinstitucion(String institucion)
        {
            this.institucion = institucion;
        }
        public String gettipo()
        {
            return tipo;
        }

        public void settipo(String tipo)
        {
            this.tipo = tipo;
        }
    }
}
