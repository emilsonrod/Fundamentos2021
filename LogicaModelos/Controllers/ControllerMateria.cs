using LogicaModelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaModelos.Controllers
{
    public class ControllerMateria
    {
        List<Materia> listaMaterias;

        public ControllerMateria()
        {
            listaMaterias = new List<Materia>();
        }

        public void AgregarMateria(Profesor profesorMateria,
            string nombreMateria, string codigoMateria)
        {
            Materia nuevaMateria = new Materia(profesorMateria);
            nuevaMateria.CodigoMateria = codigoMateria;
            nuevaMateria.NombreMateria = nombreMateria;
            listaMaterias.Add(nuevaMateria);
        }

        public void AgregarEstudiante(Estudiante estudiante,
            string codMateria)
        {
            // las funciones de las listas dinamicas, suelen necesitar
            // una valor de verdad
            // se la puede dar con notacion funcional

            // define del lado izquierdo de => las variables a trabajar
            // define del lado derecho una funcion de verdad
            Materia materia = listaMaterias.Find(item => item.CodigoMateria.Equals(codMateria));
            // la funcionalidad similar con ciclo seria
            //foreach (Materia item in listaMaterias)
            //{
            //    if (item.CodigoMateria.Equals(codMateria))
            //    {
            //        materia = item;
            //        break;
            //    }
            //}
            // despues de encontrar la materia que necesito agrego el estudiante
            materia.AgregarEstrudiante(estudiante);
        }
    }
}
