using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clEntidadCorreos
    {
        private int idCorreo;
        private int idPersona;
        private String tipoPers;
        private String correo;



        public clEntidadCorreos(int idCorreo, int idPersona, String tipoPers, String correo)
        {
            this.idCorreo = idCorreo;
            this.idPersona = idPersona;
            this.tipoPers = tipoPers;
            this.correo = correo;
        }

        public clEntidadCorreos()
        {
            this.idCorreo = 0;
            this.idPersona = 0;
            this.tipoPers = "";
            this.correo = "";
        }

        public int getIdCorreo()
        {
            return idCorreo;
        }

        public void setIdCorreo(int idCorreo)
        {
            this.idCorreo = idCorreo;
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

        public String getCorreo()
        {
            return correo;
        }

        public void setCorreo(String correo)
        {
            this.correo = correo;
        }
    }
}
