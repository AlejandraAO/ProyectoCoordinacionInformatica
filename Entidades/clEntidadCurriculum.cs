using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadNegocios
{
    public class clEntidadCurriculum
    {
        private int idEstudiante;
        private string curriculum;


        public clEntidadCurriculum(int idEstudiante, string curriculum)
        {
            this.idEstudiante = idEstudiante;
            this.curriculum = curriculum;
        }

        public clEntidadCurriculum()
        {
            this.idEstudiante = 0;
            this.curriculum = "";
        }
        public void setIdEstudiante(int idEstudiante)
        {
            this.idEstudiante = idEstudiante;
        }
        public int getIdEstudiante()
        {
            return idEstudiante;
        }
        public void setCurriculum(string curriculum)
        {
            this.curriculum = curriculum;
        }
        public string getCurriculum()
        {
            return curriculum;
        }
    }// fin public class
}//fin del namespace 
