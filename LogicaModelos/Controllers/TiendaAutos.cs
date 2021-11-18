using System.Collections.Generic;
using LogicaModelos.Modelos;

namespace LogicaModelos.Controllers
{
    public class TiendaAutos
    {
        public TiendaAutos()
        {
            ListaAutos = new List<Automovil>();
        }

        public List<Automovil> ListaAutos { get; set; }

        public void AgregarAuto(string marca, string numeroChasis, int numeroMotor,
            string placa, int kilometraje)
        {
            Automovil newAuto = new Automovil(marca, numeroChasis, numeroMotor,
                placa, kilometraje);
            ListaAutos.Add(newAuto);
        }

        public int CantidadAutos()
        {
            return ListaAutos.Count;
        }

        public Automovil MostrarAuto(string numeroChasis)
        {
            Automovil autoBuscar = null;
            foreach (Automovil auto in ListaAutos)
            {
                if (auto.NumeroChasis.Equals(numeroChasis))
                {
                    autoBuscar = auto;
                }
            }

            return autoBuscar;
        }
    }
}
