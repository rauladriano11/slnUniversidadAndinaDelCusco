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
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno1.Aprobar());
        }
        //Instanciar la clase a traves de un objeto

        ClassLibrary1.Alumno alumno1 = new ClassLibrary1.Alumno();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string lugarNacimiento = txtLugarnacimiento.Text;
            alumno1.Apellidos = apellidos;
            alumno1.Nombres = nombres;
            alumno1.Edad = edad;
            alumno1.LugarNacimiento = lugarNacimiento;
            MessageBox.Show("Se han registrado correctamente los datos del alumno. ");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar datos almacenados del objeto 1
            string apellidos = alumno1.Apellidos;
            string nombres = alumno1.Nombres;
            int edad = alumno1.Edad;
            string lugarNacimiento = alumno1.LugarNacimiento;
            MessageBox.Show("Apellidos : " + apellidos + "  Nombres : " + nombres + "  Edad : " + edad + "  Lugar de Nacimiento : " + lugarNacimiento);

        }

        private void btnEstudiar_Click(object sender, EventArgs e)
        {
            // Mostrar el emtodo u operacion estudiar
            MessageBox.Show(alumno1.Estudiar());
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno1.Trabajar());
        }

        private void txtLugarnacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
