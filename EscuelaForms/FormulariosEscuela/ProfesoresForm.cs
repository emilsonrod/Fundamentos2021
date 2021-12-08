using LogicaModelos.Controllers;
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
    public partial class ProfesoresForm : Form
    {
        ControllerProfesor controller;
        public ProfesoresForm(ControllerProfesor controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string ci = textBox3.Text;
            string materia = textBox4.Text;

            controller.AgregarProfesor(nombre, apellido, ci, materia);

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }
    }
}
