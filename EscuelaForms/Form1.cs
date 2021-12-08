using System;
using EscuelaForms.FormulariosEscuela;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaModelos.Controllers;

namespace EscuelaForms
{
    public partial class Form1 : Form
    {
        EstudiantesForm formularioEstudiantes;
        ControllerProfesor controllerProfesor;
        ControllerMateria controllerMateria;
        public Form1()
        {
            InitializeComponent();
            controllerProfesor = new ControllerProfesor();
            controllerMateria = new ControllerMateria();
            //Form Estudiantes
            //this.formularioEstudiantes = new EstudiantesForm("Hola formulario Estudiantes");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this.BackColor = System.Drawing.Color.DarkCyan;
            string texto = this.textBox1.Text;
            this.formularioEstudiantes = new EstudiantesForm(texto);
            this.formularioEstudiantes.Show();
        }

        private void delegadoButton2(object sender, EventArgs argEvent)
        {
            //this.BackColor = System.Drawing.Color.Yellow;
            MateriasForm materias = new MateriasForm(
                controllerMateria, controllerProfesor);
            materias.Show();
        }

        private void delegadoHoverButton(object sender, EventArgs argEvent)
        {
            if (sender is System.Windows.Forms.Button)
            {
                System.Windows.Forms.Button buttonSample = (System.Windows.Forms.Button)sender;
                buttonSample.BackColor = System.Drawing.Color.White;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProfesoresForm profesores = new ProfesoresForm(controllerProfesor);
            profesores.Show();
        }
    }
}
