using LogicaModelos.Controllers;
using System;

namespace POO2021Agosto.InterfazUsuario
{
    class UIProfesor
    {
        ControllerProfesor controller;

        public UIProfesor()
        {
            controller = new ControllerProfesor();
        }

        public void AgregarProfesor()
        {
            Console.WriteLine("Ingresar Nombre Personal");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresar Apellido Personal");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingresar CI");
            string ci = Console.ReadLine();
            Console.WriteLine("Ingresar Materia");
            string materia = Console.ReadLine();

            controller.AgregarProfesor(nombre, apellido, ci, materia);

        }

        public void MostrarCantidadProfesores()
        {
            Console.WriteLine("Tenemos {0} profesores:", controller.CantidadProfesor());
            foreach (string saludos in controller.PresentarProfesor())
            {
                Console.WriteLine(saludos);
            }
        }
    }
}
