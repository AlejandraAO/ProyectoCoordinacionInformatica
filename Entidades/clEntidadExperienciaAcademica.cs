using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clEntidadExperienciaAcademica
    {
        private int idExperienciaLabo;
        private int tiempo;
        private String tipoCarg;

        public clEntidadExperienciaAcademica(int idExperienciaLabo, int tiempo, String tipoCarg)
        {
            this.idExperienciaLabo = idExperienciaLabo;
            this.tiempo = tiempo;
            this.tipoCarg = tipoCarg;
        }

        public clEntidadExperienciaAcademica()
        {
            this.idExperienciaLabo = 0;
            this.tiempo = 0;
            this.tipoCarg = "";
        }

        public int getIdExperienciaLabo()
        {
            return idExperienciaLabo;
        }

        public void setIdExperienciaLabo(int idExperienciaLabo)
        {
            this.idExperienciaLabo = idExperienciaLabo;
        }

        public int getTiempo()
        {
            return tiempo;
        }

        public void setTiempo(int tiempo)
        {
            this.tiempo = tiempo;
        }

        public String getTipoCarg()
        {
            return tipoCarg;
        }

        public void setTipoCarg(String tipoCarg)
        {
            this.tipoCarg = tipoCarg;
        }

    }
}
