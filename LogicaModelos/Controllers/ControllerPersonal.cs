using LogicaModelos.Modelos;
using LogicaModelos.SuperClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaModelos.Controllers
{
    public class ControllerPersonal
    {
        List<Personal> listaPersonal;

        public ControllerPersonal()
        {
            listaPersonal = new List<Personal>();
        }

        public void AgregarPersonalPlanta(string nombre, string apellido, string ci,
            string codigo)
        {
            PersonalPlanta personal = new PersonalPlanta(nombre, apellido, ci, codigo);
            listaPersonal.Add(personal);
        }
        public void AgregarPersonalConsultor(string nombre, string apellido, string ci,
            string codigo)
        {
            PersonalConsultor personal = new PersonalConsultor(nombre, apellido, ci, codigo);
            listaPersonal.Add(personal);
        }

        public int CantidadPersonal()
        {
            return listaPersonal.Count;
        }

        public List<string> PresentarTrabajadores()
        {
            List<string> saludosPert = new List<string>();
            foreach (Personal personal in listaPersonal)
            {
                saludosPert.Add(personal.Identificarse());
            }

            return saludosPert;
        }
    }
}
