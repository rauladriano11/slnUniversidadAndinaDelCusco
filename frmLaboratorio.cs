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
    public partial class frmLaboratorio : Form
    {
        public frmLaboratorio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        ClassLibrary1.Laboratorio laboratorio1 = new ClassLibrary1.Laboratorio();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string curso = txtCurso.Text;
            string jefe = txtJefe.Text;
            string aula = txtAula.Text;
            int cantidadAlumnos = int.Parse(txtCantidadAlumnos.Text);
            laboratorio1.Curso = curso;
            laboratorio1.Jefe = jefe;
            laboratorio1.Aula = aula;
            laboratorio1.CantidadAlumnos = cantidadAlumnos;
            MessageBox.Show("Se han registrado correctamente los datos del Laboratorio. ");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string curso = laboratorio1.Curso;
            string jefe = laboratorio1.Jefe;
            string aula = laboratorio1.Aula;
            int cantidadAlumnos = laboratorio1.CantidadAlumnos;
            MessageBox.Show("Curso : " + curso + "  Jefe : " + jefe + "  Aula : " + aula + "  Cantidad de Alumnos : " + cantidadAlumnos);
        }

        private void btnPracticar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Practicar());
        }

        private void bntModelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Modelar());
        }

        private void btnExperimentar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Experimentar());
        }

        private void btnProgramar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Programar());
        }
    }
}
