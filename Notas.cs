using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Notas
    {
        //Atributos
        private string materia;
        private string aporte;
        private string alumno;
        private int nota;

        //Propiedades 
        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }
        public string Aporte
        {
            get { return aporte; }
            set { aporte = value; }
        }
        public string Alumno
        {
            get { return alumno; }
            set { alumno = value; }
        }
        public int Nota
        {
            get { return this.nota; }
            set { this.nota = value; }
        }
        //Procesos u Operaciones 
        public string Aprobar()
        {
            return "No se ha implementado el método aprobar.";
        }
        public string Desaprobar()
        {
            return "No se ha implementado el método desaprobar.";
        }
        public string Reemplazar()
        {
            return "No se ha implementado el método reemplazar.";
        }
        public string Recuperar()
        {
            return "No se ha implementado el método recuperar.";
        }
    }
}
