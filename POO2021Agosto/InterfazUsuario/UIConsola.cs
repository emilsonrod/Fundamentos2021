
using System;
using LogicaModelos.Controllers;
using LogicaModelos.Modelos;

namespace POO2021Agosto.InterfazUsuario
{
    public class UIConsola
    {
        private TiendaAutos tienda;

        public UIConsola()
        {
            tienda = new TiendaAutos();
        }

        public void AgregarAuto()
        {
            Console.WriteLine("Ingresar Marca Automovil");
            string marca = Console.ReadLine();
            Console.WriteLine("Ingresar Numero de Chasis Automovil");
            string numeroChasis = Console.ReadLine();
            Console.WriteLine("Ingresar Numero Motor Automovil");
            int numeroMotor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar Placa Automovil");
            string placa = Console.ReadLine();
            Console.WriteLine("Ingresar Kilometraje Automovil");
            int kilometraje = Convert.ToInt32(Console.ReadLine());
            tienda.AgregarAuto(marca, numeroChasis, numeroMotor, placa, kilometraje);
            Console.WriteLine("Agregado Exitosamente,");
            MostrarCantidad();
        }

        public void MostrarCantidad()
        {
            Console.WriteLine("Tienes {0} autos",
                tienda.CantidadAutos());
        }

        public void MostrarDatosAuto()
        {
            Console.WriteLine("Ingrese el numero de chasis a buscar");
            string numeroChasis = Console.ReadLine();
            Automovil busqueda = tienda.MostrarAuto(numeroChasis);
            string datosAuto = busqueda.MostrarDatos();
            Console.WriteLine(datosAuto);
        }
    }
}
