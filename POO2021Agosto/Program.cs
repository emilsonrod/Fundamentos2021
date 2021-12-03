
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
            //Punto punto1 = new Punto(5, 15);
            //Punto punto2 = new Punto(-3, 10);
            //Punto punto3 = new Punto(7, 35);
            //Punto punto4 = new Punto(-12, 20);
            //Punto punto5 = new Punto(-1, -15);
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

            //int menu = 0;
            //UIConsola interfazUsuario = new UIConsola();
            //do
            //{
            //    Console.WriteLine("Seleccione del menu");
            //    Console.WriteLine("1.- AgregarAuto");
            //    Console.WriteLine("2.- Ver CantidadAutos");
            //    Console.WriteLine("3.- Buscar Auto");
            //    Console.WriteLine("4.- Salir");
            //    int menuSelected = Convert.ToInt32(Console.ReadLine());
            //    switch (menuSelected)
            //    {
            //        case 1:
            //            interfazUsuario.AgregarAuto();
            //            menu = 1;
            //            break;
            //        case 2:
            //            interfazUsuario.MostrarCantidad();
            //            menu = 2;
            //            break;
            //        case 3:
            //            interfazUsuario.MostrarDatosAuto();
            //            menu = 3;
            //            break;
            //        case 4:
            //            Console.WriteLine("Gracias!! hasta luego");
            //            menu = 0;
            //            break;
            //    }
            //}
            //while (menu != 0);

            //int valor1 = 25;
            //int valor2 = valor1;

            //valor1 = Sumar(valor1);


            //Bicicleta bicicleta = new Bicicleta();
            //bicicleta.CantidadRuedas = 3;
            //bicicleta.CantidadVelocidades = 3;
            //bicicleta.Color = "Verde";
            //bicicleta.Marca = "Veramo";
            //Bicicleta bicicleta2 = bicicleta;

            //Bicicleta.CambiarDatosBicicleta(bicicleta);

            //int menu = 0;
            //UIEstudiante estudiante = new UIEstudiante();
            //UIPersonal personal = new UIPersonal();
            //UIProfesor profesor = new UIProfesor();

            //do
            //{
            //    Console.WriteLine("Seleccione del menu");
            //    Console.WriteLine("1.- Modulo Estudiante");
            //    Console.WriteLine("2.- Modulo Personal");
            //    Console.WriteLine("3.- Modulo Profesor");
            //    Console.WriteLine("5.- Salir");
            //    int menuSelected = Convert.ToInt32(Console.ReadLine());
            //    switch (menuSelected)
            //    {
            //        case 1:
            //            FuncionalidadEstudiante(estudiante);
            //            menu = 1;
            //            break;
            //        case 2:
            //            FuncionalidadPersonal(personal);
            //            menu = 2;
            //            break;
            //        case 3:
            //            FuncionalidadProfesor(profesor);
            //            menu = 3;
            //            break;
            //        case 4:

            //            menu = 0;
            //            break;
            //        case 5:
            //            Console.WriteLine("Gracias!! hasta luego");
            //            menu = 0;
            //            break;
            //    }
            //}
            //while (menu != 0);

            //Estudiante estudiante1 = new Estudiante("Emilson", "Rodriguez", "325685CBBA", "123EST");
            //// boxing, la habilidad que guardar cualquier objeto en una variable
            //// del tipo de la super super clase Object
            //Object genericEstudiante = estudiante1;
            // uboxing es la habilidad de sacar un objeto de una variable generica
            //object y asignarla a una variable especifica de su tipo
            //if (genericEstudiante is Profesor)
            //{
            //    Profesor estudiante2 = (Profesor)genericEstudiante;
            //}
            //if (genericEstudiante is Personal)
            //{
            //    Personal estudiante2 = (Personal)genericEstudiante;
            //}
            //if (genericEstudiante is Estudiante)
            //{
            //    Estudiante estudiante2 = (Estudiante)genericEstudiante;
            //}
            //Profesor estudiante2 = genericEstudiante as Profesor;
            //Personal estudiante3 = genericEstudiante as Personal;
            //Estudiante estudiante4 = genericEstudiante as Estudiante;
            Punto punto1 = new Punto(12, 25);
            int numero1 = 125;
            Console.WriteLine(numero1.ToString());
            Console.WriteLine(punto1.ToString());
        }   

        public static void FuncionalidadEstudiante(UIEstudiante interfazUsuario)
        {
            int menu = 0;
            // UIEstudiante interfazUsuario = new UIEstudiante();
            do
            {
                Console.WriteLine("Seleccione del menu");
                Console.WriteLine("1.- Agregar Estudiante");
                Console.WriteLine("2.- Ver Cantidad Estudiantes");
                Console.WriteLine("3.- Buscar Estudiante");
                Console.WriteLine("4.- Agregar Nota Estudiante");
                Console.WriteLine("5.- Salir");
                int menuSelected = Convert.ToInt32(Console.ReadLine());
                switch (menuSelected)
                {
                    case 1:
                        interfazUsuario.AgregarEstudiante();
                        menu = 1;
                        break;
                    case 2:
                        interfazUsuario.MostrarCantidadEstudiantes();
                        menu = 2;
                        break;
                    case 3:

                        menu = 3;
                        break;
                    case 4:

                        menu = 0;
                        break;
                    case 5:
                        Console.WriteLine("Gracias!! hasta luego");
                        menu = 0;
                        break;
                }
            }
            while (menu != 0);
        }
        public static void FuncionalidadPersonal(UIPersonal interfazUsuario)
        {
            int menu = 0;
            // UIPersonal interfazUsuario = new UIPersonal();
            do
            {
                Console.WriteLine("Seleccione del menu");
                Console.WriteLine("1.- Agregar Personal");
                Console.WriteLine("2.- Ver Cantidad Trabajadores");
                Console.WriteLine("3.- Buscar Personal");
                Console.WriteLine("5.- Salir");
                int menuSelected = Convert.ToInt32(Console.ReadLine());
                switch (menuSelected)
                {
                    case 1:
                        interfazUsuario.AgregarPersonal();
                        menu = 1;
                        break;
                    case 2:
                        interfazUsuario.MostrarCantidadTrabajadores();
                        menu = 2;
                        break;
                    case 3:
                        interfazUsuario.IdentificarTrabajadores();
                        menu = 3;
                        break;
                    case 4:

                        menu = 0;
                        break;
                    case 5:
                        Console.WriteLine("Gracias!! hasta luego");
                        menu = 0;
                        break;
                }
            }
            while (menu != 0);
        }

        public static void FuncionalidadProfesor(UIProfesor interfazUsuario)
        {
            int menu = 0;
            // UIProfesor interfazUsuario = new UIProfesor();
            do
            {
                Console.WriteLine("Seleccione del menu");
                Console.WriteLine("1.- Agregar Profesor");
                Console.WriteLine("2.- Ver Cantidad Profesores");
                Console.WriteLine("3.- Buscar Profesor");
                Console.WriteLine("5.- Salir");
                int menuSelected = Convert.ToInt32(Console.ReadLine());
                switch (menuSelected)
                {
                    case 1:
                        interfazUsuario.AgregarProfesor();
                        menu = 1;
                        break;
                    case 2:
                        interfazUsuario.MostrarCantidadProfesores();
                        menu = 2;
                        break;
                    case 3:

                        menu = 3;
                        break;
                    case 4:

                        menu = 0;
                        break;
                    case 5:
                        Console.WriteLine("Gracias!! hasta luego");
                        menu = 0;
                        break;
                }
            }
            while (menu != 0);
        }

        //private static void CambiarDatosBicicleta(Bicicleta bicicleta)
        //{
        //    bicicleta.CantidadRuedas = 2;
        //    bicicleta.CantidadVelocidades = 6;
        //    bicicleta.Color = "Rojo";
        //    bicicleta.Marca = "Santosa";
        //}
        //private static int Sumar(int dato)
        //{
        //    dato = dato + 10;
        //    return dato;
        //}
    }
}
