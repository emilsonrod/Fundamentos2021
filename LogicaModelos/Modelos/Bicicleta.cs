using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaModelos.Modelos
{
    public class Bicicleta
    {
        // atributos de clases
        // atributos de clases no es bueno que sean publicos
        string marca;
        int cantidadVelocidades;
        // int cantidadRuedas;
        // string color;

        public Bicicleta()
        {
            Marca = "Sin marca";
            CantidadRuedas = 2;
            CantidadVelocidades = 1;
            Color = "Negro";
        }

        public Bicicleta(string nuevaMarca, int nueCantVelo)
        {
            Marca = nuevaMarca;
            CantidadVelocidades = nueCantVelo;
        }

        public Bicicleta(string marca, int cantidadVelocidades,
            int cantidadRuedas, string color)
        {
            Marca = marca;
            CantidadVelocidades = cantidadVelocidades;
            CantidadRuedas = cantidadRuedas;
            Color = color;
        }

        // Propiedades estas propiedades van directamente realcionadas a los atributos
        // de clase
        public string Marca { get { return marca; } set { marca = value; } }
        public int CantidadVelocidades
        { get { return cantidadVelocidades; } set { cantidadVelocidades = value; } }
        public int CantidadRuedas { get; set; } // trabaja en su forma base
        public string Color { get; set; } // trabaja en su forma base
        // antes se solia usar metodos getters y setters
        //public string getMarca()
        //{
        //    return marca;
        //}

        //public void setMarca(string nuevaMarca)
        //{
        //    marca = nuevaMarca;
        //}
    }
}
