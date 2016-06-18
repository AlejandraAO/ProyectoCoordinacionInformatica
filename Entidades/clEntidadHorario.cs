using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clEntidadHorario
    {
        #region Atributos
        private int idHorario;
        private string dia;
        private string horaInicio;
        private string horaSalida;
        #endregion

        #region Set y Get
        public int mIdHorario
        {
            set { this.idHorario = value; }
            get { return this.idHorario; }
        }

        public string mDia
        {
            set { this.dia = value; }
            get { return this.dia; }
        }

        public string mHoraInicio
        {
            set { this.horaInicio = value; }
            get { return this.horaInicio; }
        }

        public string mHoraSalida
        {
            set { this.horaSalida = value; }
            get { return this.horaSalida; }
        }
        #endregion
    }
}
