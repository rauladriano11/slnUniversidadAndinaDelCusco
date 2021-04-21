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
    public partial class frmRector : Form
    {
        public frmRector()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Contratar());
        }
        ClassLibrary1.Rector rector1 = new ClassLibrary1.Rector();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int dni = int.Parse(txtDni.Text);
            string gradoEstudios = txtGradoEstudios.Text;
            rector1.Apellidos = apellidos;
            rector1.Nombres = nombres;
            rector1.Dni = dni;
            rector1.GradoEstudios = gradoEstudios;
            MessageBox.Show("Se han registrado correctamente los datos del rector . ");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = rector1.Apellidos;
            string nombres = rector1.Nombres;
            int dni = rector1.Dni;
            string gradoEstudios = rector1.GradoEstudios;
            MessageBox.Show("Apellidos : " + apellidos + "  Nombres : " + nombres + "  Dni : " + dni + "  Grado de Estudios : " + gradoEstudios);
        }

        private void btnDirigir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Dirigir());
        }

        private void btnOrganizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Organizar());
        }

        private void btnPromover_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Promover());
        }
    }
}
