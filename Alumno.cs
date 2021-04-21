using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Alumno
    {
        //Atributos
        private string apellidos;
        private string nombres;
        private int edad;
        private string lugarNacimiento;

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
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
        public string LugarNacimiento
        {
            get { return this.lugarNacimiento; }
            set { this.lugarNacimiento = value; }
        }
        // Metodos u Operaciones 
        public string Estudiar()
        {
            return "No se ha implementado el método estudiar.";
        }
        public string Trabajar()
        {
            return "No se ha implementado el método trabajar.";
        }
        public string Aprobar()
        {
            return "No se ha implementado el método aprobar.";
        }
    }
}
