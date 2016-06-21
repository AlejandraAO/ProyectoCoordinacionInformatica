using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clEntidadCoRequisitoCurso
    {
        #region Atributos
        private int idCurso;
        private int idCursoCoRequisito;
        #endregion

        #region Set y Get
        public int mIdCurso
        {
            set { this.idCurso = value; }
            get { return this.idCurso; }
        }
        public int mIdCursoCoRequisito
        {
            set { this.idCursoCoRequisito = value; }
            get { return this.idCursoCoRequisito; }
        }
        #endregion
    }
}
