using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clEntidadCursoLibre
    {

        #region Atributos/variables locales
        private int idCursoLibre;
        private int idProfesor;
        private int cupo;
        private string lugar;
        private string nombre;
        private string estado;
        private string programa;
        private string descripcion;
        private string nombrePrograma;
        #endregion


        #region Métodos set y get
        public int mIdCursoLibre
        {
            get
            {
                return idCursoLibre;
            }

            set
            {
                idCursoLibre = value;
            }
        }

        public int mIdProfesor
        {
            get
            {
                return idProfesor;
            }

            set
            {
                idProfesor = value;
            }
        }

        public string mNombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string mNombrePrograma
        {
            get
            {
                return nombrePrograma;
            }

            set
            {
                nombrePrograma = value;
            }
        }

        public string mDescripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string mEstado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string mLugar
        {
            get
            {
                return lugar;
            }

            set
            {
                lugar = value;
            }
        }

        public int mCupo
        {
            get
            {
                return cupo;
            }

            set
            {
                cupo = value;
            }
        }

        public String mPrograma
        {
            get
            {
                return programa;
            }

            set
            {
                programa = value;
            }
        }
        #endregion



    }
}
