using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Laboratorio
    {
        private string curso;
        private string jefe;
        private string aula;
        private int cantidadAlumnos;
        //Propiedades 
        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        public string Jefe
        {
            get { return jefe; }
            set { jefe = value; }
        }
        public string Aula
        {
            get { return this.aula; }
            set { this.aula = value; }
        }
        public int CantidadAlumnos
        {
            get { return this.cantidadAlumnos; }
            set { this.cantidadAlumnos = value; }
        }
        // Metodos u Operaciones 
        public string Practicar()
        {
            return "No se ha implementado el método practicar.";
        }
        public string Modelar()
        {
            return "No se ha implementado el método modelar.";
        }
        public string Experimentar()
        {
            return "No se ha implementado el método experimentar.";
        }
        public string Programar()
        {
            return "No se ha implementado el método programar.";
        }
    }
}
