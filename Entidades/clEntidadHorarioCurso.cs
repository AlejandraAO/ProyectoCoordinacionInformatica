using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clEntidadHorarioCurso
    {

        #region Atributos
        private int idCurso;
        private int idGrupo;
        private int numeroGrupo;
        private int cupoMaximo;
        private int cupoMinimo;
        private int cupoActual;
        #endregion

        #region Métodos set y get

        public int mIdCurso
        {
            set { this.idCurso = value; }
            get { return this.idCurso; }
        }

        public int mIdGrupo
        {
            set { this.idGrupo = value; }
            get { return this.idGrupo; }
        }

        public int mNumeroGrupo
        {
            set { this.numeroGrupo = value; }
            get { return this.numeroGrupo; }
        }

        public int mCupoMaximo
        {
            set { this.cupoMaximo = value; }
            get { return this.cupoMaximo; }
        }

        public int mCupoMinimo
        {
            set { this.cupoMinimo = value; }
            get { return this.cupoMinimo; }
        }

        public int mCupoActual
        {
            set { this.cupoActual = value; }
            get { return this.cupoActual; }
        }

      
        #endregion
    }
}
