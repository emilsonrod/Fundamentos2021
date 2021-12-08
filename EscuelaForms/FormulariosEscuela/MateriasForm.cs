using LogicaModelos.Controllers;
using LogicaModelos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscuelaForms.FormulariosEscuela
{
    public partial class MateriasForm : Form
    {
        ControllerMateria controller;
        ControllerProfesor controllerProfesores;
        public MateriasForm(ControllerMateria controller,
            ControllerProfesor controllerProfesor)
        {
            InitializeComponent();
            this.controller = controller;
            this.controllerProfesores = controllerProfesor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo = textBox1.Text;
            Profesor prof = controllerProfesores.BuscarProfesor(codigo);
            textBox2.Text = prof.PresentarProfesor();
        }
    }
}
