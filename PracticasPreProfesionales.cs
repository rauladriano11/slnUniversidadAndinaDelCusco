using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PracticasPreProfesionales
    {
        //Atributos
        private string carrera;
        private string lugar;
        private string empresa;
        private string cargo;

        //Propiedades 
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }
        public string Empresa
        {
            get { return this.empresa; }
            set { this.empresa = value; }
        }
        public string Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }
        //Procesos u Operaciones 
        public string Dirigir()
        {
            return "No se ha implementado el método dirigir.";
        }
        public string Programar()
        {
            return "No se ha implementado el método programar.";
        }
        public string Trabajar()
        {
            return "No se ha implementado el método trabajar.";
        }
        public string Aprender()
        {
            return "No se ha implementado el método aprender.";
        }
    }
}
