using LogicaModelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaModelos.Controllers
{
    public class ControllerProfesor
    {
        List<Profesor> listaProfesores;

        public ControllerProfesor()
        {
            listaProfesores = new List<Profesor>();
        }

        public void AgregarProfesor(string nombre, string apellido, string ci,
            string materia)
        {
            Profesor profesor = new Profesor(nombre, apellido, ci, materia);
            listaProfesores.Add(profesor);
        }

        public int CantidadProfesor()
        {
            return listaProfesores.Count;
        }

        public List<string> PresentarProfesor()
        {
            List<string> saludosPert = new List<string>();
            foreach (Profesor profesor in listaProfesores)
            {
                saludosPert.Add(profesor.PresentarProfesor());
            }

            return saludosPert;
        }
    }
}
