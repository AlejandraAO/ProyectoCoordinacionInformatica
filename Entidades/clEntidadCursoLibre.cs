using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clEntidadCursoLibre
    {

        #region Atributos/varibles locales
        private int _idCursoLibre;
        private int _idProfesor;
        private string _nombre;
        private string _descripcion;
        private string _estado;
        private string _lugar;
        private int _cupo;
        private byte _programa;
        #endregion


        #region Métodos set y get
        public int IdCursoLibre
        {
            get
            {
                return _idCursoLibre;
            }

            set
            {
                _idCursoLibre = value;
            }
        }

        public int IdProfesor
        {
            get
            {
                return _idProfesor;
            }

            set
            {
                _idProfesor = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }

            set
            {
                _descripcion = value;
            }
        }

        public string Estado
        {
            get
            {
                return _estado;
            }

            set
            {
                _estado = value;
            }
        }

        public string Lugar
        {
            get
            {
                return _lugar;
            }

            set
            {
                _lugar = value;
            }
        }

        public int Cupo
        {
            get
            {
                return _cupo;
            }

            set
            {
                _cupo = value;
            }
        }

        public byte Programa
        {
            get
            {
                return _programa;
            }

            set
            {
                _programa = value;
            }
        }
        #endregion



    }
}
