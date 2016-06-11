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
        private string carnet;
        #endregion

        #region Constructor
        public clEntidadMiembro()
        {
            nombreMiembro = "";
            apellido1Miembro = "";
            apellido2Miembro = "";
            carreraMiembro = "";
            tipoMiembro = "";
            carnet = "";
        }
        #endregion

        #region Metodos Set y Get

        public string getSetCarnetMiembro
        {
            get { return this.carnet; }
            set { this.carnet = value; }
        }

        public string getSetNombreMiembro    
        {
            get{ return this.nombreMiembro;}
            set{  this.nombreMiembro = value;}
        }

        public string getSetApellido1Miembro
        {
            get { return this.apellido1Miembro; }
            set { this.apellido1Miembro = value; }
        }
        public string getSetApellido2Miembro
        {
            get { return this.apellido2Miembro; }
            set { this.apellido2Miembro = value; }
        }
        public string getSetCarreraMiembro
        {
            get { return this.carreraMiembro; }
            set { this.carreraMiembro = value; }
        }
        public string getSetTipo
        {
            get { return this.tipoMiembro; }
            set { this.tipoMiembro = value; }
        }
        #endregion


    }
}
