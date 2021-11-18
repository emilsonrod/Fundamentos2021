
using System;
using POO2021Agosto.InterfazUsuario;
using LogicaModelos.Modelos;
using LogicaModelos.Controllers;

namespace POO2021Agosto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bicicleta bicicleta1 = new Bicicleta();
            //bicicleta1.CantidadRuedas = 2;
            //bicicleta1.CantidadVelocidades = 3;
            //bicicleta1.Color = "verde";
            //bicicleta1.Marca = "Veramo";

            //Bicicleta bicicleta2 = new Bicicleta("BMX", 5);
            //bicicleta2.CantidadRuedas = 3;
            //bicicleta2.Color = "Plateado";

            //Bicicleta bicicleta3 = new Bicicleta("Santosa", 5, 2, "Dorado");
            Punto punto1 = new Punto(5, 15);
            Punto punto2 = new Punto(-3, 10);
            Punto punto3 = new Punto(7, 35);
            Punto punto4 = new Punto(-12, 20);
            Punto punto5 = new Punto(-1, -15);
            ////Console.WriteLine(punto1.MostrarCoordenadas());
            ////Console.WriteLine(punto2.MostrarCoordenadas());

            //Linea linea1 = new Linea(punto1, punto2);
            //Console.WriteLine(linea1.MostrarFuncionesLinea());
            //Linea linea2 = new Linea();
            //linea2.PrimerPunto = punto3;
            //linea2.SegundoPunto = punto4;
            //Console.WriteLine(linea2.MostrarFuncionesLinea());

            //EjeCartesiano cartisiano1 = new EjeCartesiano();
            //cartisiano1.AgregarPunto(punto1);
            //cartisiano1.AgregarPunto(punto2);
            //cartisiano1.AgregarPunto(punto3);
            //cartisiano1.AgregarPunto(punto4);
            //cartisiano1.AgregarPunto(punto5);
            //cartisiano1.MostrarPlanos();
            //cartisiano1.MostrarDistancias();

            int menu = 0;
            UIConsola interfazUsuario = new UIConsola();
            do
            {
                Console.WriteLine("Seleccione del menu");
                Console.WriteLine("1.- AgregarAuto");
                Console.WriteLine("2.- Ver CantidadAutos");
                Console.WriteLine("3.- Buscar Auto");
                Console.WriteLine("4.- Salir");
                int menuSelected = Convert.ToInt32(Console.ReadLine());
                switch (menuSelected)
                {
                    case 1:
                        interfazUsuario.AgregarAuto();
                        menu = 1;
                        break;
                    case 2:
                        interfazUsuario.MostrarCantidad();
                        menu = 2;
                        break;
                    case 3:
                        interfazUsuario.MostrarDatosAuto();
                        menu = 3;
                        break;
                    case 4:
                        Console.WriteLine("Gracias!! hasta luego");
                        menu = 0;
                        break;
                }
            }
            while (menu != 0);


        }
    }
}
