using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmJefePractica : Form
    {
        public frmJefePractica()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        ClassLibrary1.JefePractica jefepractica1 = new ClassLibrary1.JefePractica();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            string profesion = txtProfesion.Text;
            int edad = int.Parse(txtEdad.Text);
            string lugarTrabajo = txtLugarTrabajo.Text;
            jefepractica1.Apellidos = apellidos;
            jefepractica1.Nombres = nombres;
            jefepractica1.Profesion = profesion;
            jefepractica1.Edad = edad;
            jefepractica1.LugarTrabajo = lugarTrabajo; 
            MessageBox.Show("Se han registrado correctamente los datos del jefe de práctica. ");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = jefepractica1.Apellidos;
            string nombres = jefepractica1.Nombres;
            string profesion = jefepractica1.Profesion;
            int edad = jefepractica1.Edad;
            string lugarTrabajo = jefepractica1.LugarTrabajo;
            MessageBox.Show("Apellidos : " + apellidos + "  Nombres : " + nombres + "  Profesión : " + profesion + "  Edad : " + edad + "  Lugar de trabajo : " + lugarTrabajo);
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefepractica1.Enseñar());
        }

        private void btnDirigir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefepractica1.Dirigir());
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefepractica1.Evaluar());
        }

        private void btnCorregir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefepractica1.Corregir());
        }
    }
}
