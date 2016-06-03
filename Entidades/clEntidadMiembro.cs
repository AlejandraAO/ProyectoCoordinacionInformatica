using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clEntidadMiembro
    {
        #region Atributos
        private string nombreMiembro;
        private string apellido1Miembro;
        private string apellido2Miembro;
        private string carreraMiembro;
        private string tipoMiembro;
        #endregion

        #region Constructor
        public clEntidadMiembro()
        {
            nombreMiembro = "";
            apellido1Miembro = "";
            apellido2Miembro = "";
            carreraMiembro = "";
            tipoMiembro = "";
        }
        #endregion

        #region Metodos Set y Get
        public string getSetNombreMiembro    
        {
            get{ return nombreMiembro;}
            set{  nombreMiembro = value;}
        }

        public string getSetApellido1Miembro
        {
            get { return apellido1Miembro; }
            set { apellido1Miembro = value; }
        }
        public string getSetApellido2Miembro
        {
            get { return apellido2Miembro; }
            set { apellido2Miembro = value; }
        }
        public string getSetCarreraMiembro
        {
            get { return carreraMiembro; }
            set { carreraMiembro = value; }
        }
        public string getSetTipo
        {
            get { return tipoMiembro; }
            set { tipoMiembro = value; }
        }
        #endregion


    }
}
