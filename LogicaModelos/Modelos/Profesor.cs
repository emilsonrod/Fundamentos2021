using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaModelos.SuperClases;

namespace LogicaModelos.Modelos
{
    class Profesor : Persona
    {
        public Profesor(string nombre, string apellido, string ci,
            string materia)
        {
            Nombre = nombre;
            Apellido = apellido;
            CI = ci;
            Materia = materia;
        }

        public string Materia { get; set; }

        public string PresentarProfesor()
        {
            return string.Format("Profesor de la materia - {0}, nombre Completo - {1} {2}, ci- {3}",
                Materia, Nombre, Apellido, CI);
        }
    }
}
