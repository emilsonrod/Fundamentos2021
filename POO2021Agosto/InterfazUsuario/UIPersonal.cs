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
            Console.WriteLine("1 => Planta");
            Console.WriteLine("2 => Consultor");
            int tipo = Convert.ToInt32(Console.ReadLine());

            if(tipo == 1)
                controller.AgregarPersonalPlanta(nombre, apellido, ci, codigo);
            else if(tipo == 2)
                controller.AgregarPersonalConsultor(nombre, apellido, ci, codigo);
        }

        public void MostrarCantidadTrabajadores()
        {
            Console.WriteLine("Tenemos {0} trabajadores:", controller.CantidadPersonal());
            foreach (string saludos in controller.PresentarTrabajadores())
            {
                Console.WriteLine(saludos);
            }
        }

        public void IdentificarTrabajadores()
        {
            foreach (string saludos in controller.PresentarTrabajadores())
            {
                Console.WriteLine(saludos);
            }
        }
    }
}
