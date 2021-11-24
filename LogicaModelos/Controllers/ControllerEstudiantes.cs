using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaModelos.Modelos;

namespace LogicaModelos.Controllers
{
    public class ControllerEstudiantes
    {
        List<Estudiante> listaEstudiantes;

        public ControllerEstudiantes()
        {
            listaEstudiantes = new List<Estudiante>();
        }

        public void AgregarEstudiante(string nombre, string apellido, string ci, string codEst)
        {
            Estudiante estudiante = new Estudiante(nombre, apellido, ci, codEst);
            listaEstudiantes.Add(estudiante);
        }

        public int CantidadEstudiantes()
        {
            return listaEstudiantes.Count;
        }

        public List<string> PresentarEstudiantes() 
        {
            List<string> saludosEst = new List<string>();
            foreach (Estudiante estudiante in listaEstudiantes)
            {
                saludosEst.Add(estudiante.PresentarEstudiante());
            }

            return saludosEst;
        } 

    }
}
