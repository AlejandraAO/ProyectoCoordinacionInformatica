using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class clEntidadCurso
    {
        #region Atributos
        private int idCurso;
        private string siglaCurso;
        private string nombreCurso;
        private string lugarCurso;
        private string cicloCurso;
        private int creditosCurso;
        private byte programaCurso;
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

        public string MCicloCurso
        {
            set { this.cicloCurso = value; }
            get { return this.cicloCurso; }
        }

        public int MCreditosCurso
        {
            set { this.creditosCurso = value; }
            get { return this.creditosCurso; }
        }

        public byte MProgramaCurso
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
