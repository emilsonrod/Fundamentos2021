using LogicaModelos.Controllers;
using System;

namespace POO2021Agosto.InterfazUsuario
{
    class UIPersonal
    {
        ControllerPersonal controller;

        public UIPersonal()
        {
            controller = new ControllerPersonal();
        }

        public void AgregarPersonal()
        {
            Console.WriteLine("Ingresar Nombre Personal");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresar Apellido Personal");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingresar CI");
            string ci = Console.ReadLine();
            Console.WriteLine("Ingresar Codigo Personal");
            string codigo = Console.ReadLine();
            Console.WriteLine("Ingresar Tipo Personal");
            string tipo = Console.ReadLine();

            controller.AgregarPersonal(nombre, apellido, ci, codigo, tipo);

        }

        public void MostrarCantidadTrabajadores()
        {
            Console.WriteLine("Tenemos {0} trabajadores:", controller.CantidadPersonal());
            foreach (string saludos in controller.PresentarTrabajadores())
            {
                Console.WriteLine(saludos);
            }
        }
    }
}
