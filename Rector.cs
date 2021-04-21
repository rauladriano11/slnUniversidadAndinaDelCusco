using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Rector
    {
        //Atributos
        private string apellidos;
        private string nombres;
        private int dni;
        private string gradoEstudios;

        //Propiedades 
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public string GradoEstudios
        {
            get { return gradoEstudios; }
            set { gradoEstudios = value; }
        }
        // Metodos u Operaciones 
        public string Dirigir()
        {
            return "No se ha implementado el método dirigir.";
        }
        public string Organizar()
        {
            return "No se ha implementado el método organizar.";
        }
        public string Promover()
        {
            return "No se ha implementado el método promover.";
        }
        public string Contratar()
        {
            return "No se ha implementado el método contratar.";
        }
    }
}
