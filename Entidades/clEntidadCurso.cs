using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clEntidadCurso
    {
        #region Atributos
        private int idCurso;
        private string siglaCurso;
        private string nombreCurso;
        private string lugarCurso;
        private string cicloCurso;
        private int creditosCurso;
        private string programaCurso;
        private string estadoCurso;
        private int totalDeHorasCurso;
        private string modalidadCurso;
        #endregion

        #region Métodos set y get
        public int mIdCurso
        {
            set { this.idCurso = value; }
            get { return this.idCurso; }
        }

        public string mSiglaCurso
        {
            set { this.siglaCurso = value; }
            get { return this.siglaCurso; }
        }

        public string mNombreCurso
        {
            set { this.nombreCurso = value; }
            get { return this.nombreCurso; }
        }

        public string mLugarCurso
        {
            set { this.lugarCurso = value; }
            get { return this.lugarCurso; }
        }

        public string mCicloCurso
        {
            set { this.cicloCurso = value; }
            get { return this.cicloCurso; }
        }

        public int mCreditosCurso
        {
            set { this.creditosCurso = value; }
            get { return this.creditosCurso; }
        }

        public string mProgramaCurso
        {
            set { this.programaCurso = value; }
            get { return this.programaCurso; }
        }

        public string mEstadoCurso
        {
            set { this.estadoCurso = value; }
            get { return this.estadoCurso; }
        }

        public int mTotalDeHorasCurso
        {
            set { this.totalDeHorasCurso = value; }
            get { return this.totalDeHorasCurso; }
        }

        public string mModalidadCurso
        {
            set { this.modalidadCurso = value; }
            get { return this.modalidadCurso; }
        }

        #endregion
    }
}
