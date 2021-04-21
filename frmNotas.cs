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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        ClassLibrary1.Notas nota1 = new ClassLibrary1.Notas();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string materia = txtMateria.Text;
            string aporte = txtAporte.Text;
            string alumno = txtAlumno.Text;
            int nota = int.Parse(txtNota.Text);
            nota1.Materia = materia;
            nota1.Aporte = aporte;
            nota1.Alumno = alumno;
            nota1.Nota = nota;
            MessageBox.Show("Se han registrado correctamente los datos de la nota.");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string materia = nota1.Materia;
            string aporte = nota1.Aporte;
            string alumno = nota1.Alumno;
            int nota = nota1.Nota;
            MessageBox.Show("Materia : "+ materia +  "  Aporte : " + aporte + "  Alumno : " + alumno + "  Nota :" + nota);
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota1.Desaprobar());
        }

        private void btnReemplazar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota1.Reemplazar());
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota1.Recuperar());
        }
    }
}
