using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class clEntidadMiembroProyecto
    {
        #region Atributos
        private int idProyecto;
        private int idMiembro;

        #endregion

        public int mIdProyecto
        {
            set { this.idProyecto = value; }
            get { return this.idProyecto; }
        }

        public int mIdMiembro
        {
            set { this.idMiembro = value; }
            get { return this.idMiembro; }
        }
    }
}
