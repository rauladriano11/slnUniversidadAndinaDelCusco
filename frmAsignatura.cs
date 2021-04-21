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
    public partial class frmAsignatura : Form
    {
        public frmAsignatura()
        {
            InitializeComponent();
        }
        ClassLibrary1.Asignatura asignatura1 = new ClassLibrary1.Asignatura();
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string ciclo = txtCiclo.Text;
            int creditos = int.Parse(txtCreditos.Text);
            string aula = txtAula.Text;
            asignatura1.Nombre = nombre;
            asignatura1.Ciclo = ciclo;
            asignatura1.Creditos = creditos;
            asignatura1.Aula = aula;
            MessageBox.Show("Se han registrado correctamente los datos de la asignatura. ");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombre = asignatura1.Nombre;
            string ciclo = asignatura1.Ciclo;
            int creditos = asignatura1.Creditos;
            string aula = asignatura1.Aula;
            MessageBox.Show("Nombre de la Asignatura : " + nombre + "  Ciclo : " + ciclo + "  Creditos : " + creditos + "  Aula : " + aula);
        }

        private void btnDiseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Diseñar());
        }

        private void btnDebatir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Debatir());
        }

        private void btnElaborarDocumentos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.ElaborarDocumentos());
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Evaluar());
        }
    }
}
