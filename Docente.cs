using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Docente
    {
        //Atributos
        private string dni;
        private string apellidos;
        private string nombres;
        private DateTime fechaNacimiento;
        private string profesion;

        //Propiedades 
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
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
        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }
        // Metodos u Operaciones 
        public string Enseñar()
        {
            return "No se ha implementado el método enseñar.";
        }
        public string Matricular()
        {
            return "No se ha implementado el método matricular.";
        }
        public string Aprobar()
        {
            return "No se ha implementado el método aprobar.";
        }
        public string Desaprobar()
        {
            return "No se ha implementado el método desaprobar.";
        }
    }
}
    