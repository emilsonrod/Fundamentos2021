using LogicaModelos.Modelos;
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

        public void AgregarPersonal(string nombre, string apellido, string ci,
            string codigo, string tipo)
        {
            Personal personal = new Personal(nombre, apellido, ci, codigo, tipo);
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
                saludosPert.Add(personal.PresentarPersonal());
            }

            return saludosPert;
        }
    }
}
