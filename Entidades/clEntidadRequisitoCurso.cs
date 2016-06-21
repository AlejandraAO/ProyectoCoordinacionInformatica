using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clEntidadRequisitoCurso
    {
        #region Atributos
        private int idCurso;
        private int idCursoRequerido;
        #endregion

        #region Metodos set y get
        public int mIdCurso
        {
            set { this.idCurso = value; }
            get { return this.idCurso; }
        }
        public int mIdCursoRequerido
        {
            set { this.idCursoRequerido = value; }
            get { return this.idCursoRequerido; }
        }
        #endregion
    }
}
