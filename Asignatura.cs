using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Asignatura
    {
        //Atributos
        private string nombre;
        private string ciclo;
        private int creditos;
        private string aula;

        //Propiedades 
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Ciclo
        {
            get { return ciclo; }
            set { ciclo = value; }
        }
        public int Creditos
        {
            get { return this.creditos; }
            set { this.creditos = value; }
        }
        public string Aula
        {
            get { return this.aula; }
            set { this.aula = value; }
        }
        // Metodos u Operaciones 
        public string Diseñar()
        {
            return "No se ha implementado el método diseñar.";
        }
        public string Debatir()
        {
            return "No se ha implementado el método debatir.";
        }
        public string ElaborarDocumentos()
        {
            return "No se ha implementado el método elaborar documentos.";
        }
        public string Evaluar()
        {
            return "No se ha implementado el método evaluar.";
        }
    }

}
