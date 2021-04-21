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
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
        }
        ClassLibrary1.Docente docente1 = new ClassLibrary1.Docente();
        private void frmDocente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int dni = int.Parse(txtDni.Text);
            string profesion = txtProfesion.Text;
            DateTime fechaNacimiento = dateFechaNacimiento.Value;
            docente1.Apellidos = apellidos;
            docente1.Nombres = nombres;
            docente1.Dni = Convert.ToString(dni);
            docente1.FechaNacimiento = fechaNacimiento;
            docente1.Profesion = profesion;
            MessageBox.Show("Se han registrado correctamente los datos del docente.");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar datos almacenados del objeto 1
            string apellidos = docente1.Apellidos;
            string nombres = docente1.Nombres;
            string dni  = docente1.Dni;
            DateTime fechaNacimiento = docente1.FechaNacimiento;
            string profesion = docente1.Profesion;
            MessageBox.Show("Apellidos : " + apellidos + "  Nombres : " + nombres + "  DNI : " + dni + "  Fecha de Nacimiento : " + fechaNacimiento + "  Profesion : " + profesion);
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Enseñar());
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Desaprobar());
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Matricular());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
