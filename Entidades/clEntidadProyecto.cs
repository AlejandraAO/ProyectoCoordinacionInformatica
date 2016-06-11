using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clEntidadProyecto
    {
        #region Atributos
        private int idProyecto;
        private string nombre;
        private string descripcion;
        private string tipo;
        private string estado;
        private string informacionProyecto;
        private string nombreDocumento;
        
        #endregion

        #region Métodos set y get
        public int mIdProyecto
        {
            set { this.idProyecto = value; }
            get { return this.idProyecto; }
        }

        public string mNombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public string mDescripcion
        {
            set { this.descripcion = value; }
            get { return this.descripcion; }
        }

        public string mTipo
        {
            set { this.tipo = value; }
            get { return this.tipo; }
        }

        public string mEstado
        {
            set { this.estado = value; }
            get { return this.estado; }
        }

       

        public string mInformacioProyecto
        {
            set { this.informacionProyecto = value; }
            get { return this.informacionProyecto; }
        }

        public string mNombreDocumento
        {
            set { this.nombreDocumento = value; }
            get { return this.nombreDocumento; }
        }

        #endregion
    }
}
