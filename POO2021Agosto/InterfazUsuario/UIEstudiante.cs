using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaModelos.Controllers;

namespace POO2021Agosto.InterfazUsuario
{
    public class UIEstudiante
    {
        ControllerEstudiantes controller;

        public UIEstudiante()
        {
            controller = new ControllerEstudiantes();
        }

        public void AgregarEstudiante()
        {
            Console.WriteLine("Ingresar Nombre Estudiante");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresar Apellido Estudiante");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingresar CI");
            string ci = Console.ReadLine();
            Console.WriteLine("Ingresar Codigo Estudiante");
            string codigoEstudiante = Console.ReadLine();

            controller.AgregarEstudiante(nombre, apellido, ci, codigoEstudiante);
            
        }

        public void MostrarCantidadEstudiantes()
        {
            Console.WriteLine("Tenemos {0} estudiantes", controller.CantidadEstudiantes());
        }
    }
}
