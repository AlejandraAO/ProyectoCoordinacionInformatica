using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public  class clEntidadGrupoCurso
    {


        #region Atributos
        private int idGrupo;
        private int idCurso;
        private int numeroGrup;
        private int cupoMaximo;
        private int cupoMinimo;
        private int cupoActual;
        #endregion

        #region Constructor
        public clEntidadGrupoCurso()
        {
            idGrupo = 0;
            idCurso = 0;
            numeroGrup = 0;
            cupoMaximo = 0;
            cupoMinimo = 0;
            cupoActual = 0;
        }
        #endregion

        #region Metodos Set y Get

        public int getsetIdGrupo
        {
            get { return this.idGrupo; }
            set { this.idGrupo = value; }
        }

        public int getSetIdCurso
        {
            get { return this.idCurso; }
            set { this.idCurso = value; }
        }

        public int getSetNumeroGrup
        {
            get { return this.numeroGrup; }
            set { this.numeroGrup = value; }
        }
        public int getSetCupoMaximo
        {
            get { return this.cupoMaximo; }
            set { this.cupoMaximo = value; }
        }
        public int getSetCupoMinimo
        {
            get { return this.cupoMinimo; }
            set { this.cupoMinimo = value; }
        }
        public int getSetCupoActual
        {
            get { return this.cupoActual; }
            set { this.cupoActual = value; }
        }
        #endregion


    }
}
