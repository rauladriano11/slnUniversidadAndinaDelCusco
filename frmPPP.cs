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
    public partial class frmPPP : Form
    {
        public frmPPP()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        ClassLibrary1.PracticasPreProfesionales practica1 = new ClassLibrary1.PracticasPreProfesionales();
        private void button1_Click(object sender, EventArgs e)
        {
            string carrera =txtCarrera.Text;
            string lugar = txtLugar.Text;
            string empresa = txtEmpresa.Text;
            string cargo = txtCargo.Text;
            practica1.Carrera = carrera;
            practica1.Lugar = lugar;
            practica1.Empresa = empresa;
            practica1.Cargo = cargo;
            MessageBox.Show("Se han registrado correctamente los datos de practicas pre profesionales . ");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string carrera = practica1.Carrera;
            string lugar = practica1.Lugar;
            string empresa = practica1.Empresa;
            string cargo = practica1.Empresa;
            MessageBox.Show("Carrera Profesional : " + carrera + "  Lugar : " + lugar + "  Empresa : " + empresa + "  Cargo : " + cargo);
        }

        private void btnDirigir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(practica1.Dirigir());
        }

        private void btnProgramar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(practica1.Programar());
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(practica1.Trabajar());
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(practica1.Aprender());
        }
    }
}
