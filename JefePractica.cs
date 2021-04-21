using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class JefePractica
    {
        //Atributos 
        private string apellidos;
        private string nombres;
        private string profesion;
        private int edad;
        private string lugarTrabajo;

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
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string LugarTrabajo
        {
            get { return lugarTrabajo; }
            set { lugarTrabajo = value; }
        }
        //Metodos u Operaciones 
        public string Enseñar()
        {
            return "No se ha implementado el método enseñar.";
        }
        public string Dirigir()
        {
            return "No se ha implementado el método dirigir."; 
        }
        public string Evaluar()
        {
            return "No se ha implementado el método evaluar.";
        }
        public string Corregir()
        {
            return "No se ha implementado el método corregir.";
        }
    }
}
