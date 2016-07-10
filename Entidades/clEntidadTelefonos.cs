using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades { 
    public class clEntidadTelefonos
    {
        private int idTelefono;
        private int telefono;
        private int idPersona;
        private String tipoPers;

        public clEntidadTelefonos(int idTelefono, int telefono, int idPersona, String tipoPers)
        {
            this.idTelefono = idTelefono;
            this.telefono = telefono;
            this.idPersona = idPersona;
            this.tipoPers = tipoPers;
        }

        public clEntidadTelefonos()
        {
            this.idTelefono = 0;
            this.telefono = 0;
            this.idPersona = 0;
            this.tipoPers = "";
        }

        public int getIdTelefono()
        {
            return idTelefono;
        }

        public void setIdTelefono(int idTelefono)
        {
            this.idTelefono = idTelefono;
        }

        public int getTelefono()
        {
            return telefono;
        }

        public void setTelefono(int telefono)
        {
            this.telefono = telefono;
        }

        public int getIdPersona()
        {
            return idPersona;
        }

        public void setIdPersona(int idPersona)
        {
            this.idPersona = idPersona;
        }

        public String getTipoPers()
        {
            return tipoPers;
        }

        public void setTipoPers(String tipoPers)
        {
            this.tipoPers = tipoPers;
        }

    }
}
