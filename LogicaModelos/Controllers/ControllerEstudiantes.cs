using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaModelos.Modelos;
using LogicaModelos.SuperClases;

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
            Profesor profesor = new Profesor(nombre, apellido, ci, "programacion") ;
            Estudiante estudiante = new Estudiante(nombre, apellido, ci, codEst);
            //Personal personal1 = new Personal(nombre,apellido, ci, "codigo", "tipo");

            // al transformar la clase padre Persona en una clase abstracta
            // impedimos la creacion de objetos
            // Persona persona = new Persona();
            // Estudiante estudiante2 = estudiante;
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
