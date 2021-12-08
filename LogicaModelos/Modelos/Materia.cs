using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaModelos.Modelos
{
    public class Materia
    {
        private Profesor profesor;// para crear una Materia ya deberia Existir
        // el profesor
        private List<Estudiante> listaEstudiantes;

        public Materia(Profesor profesor)
        {
            this.profesor = profesor;
            listaEstudiantes = new List<Estudiante>();
        }

        public string NombreMateria { get; set; }
        public string CodigoMateria { get; set; }

        public void AgregarEstrudiante(Estudiante estudiante)
        {
            listaEstudiantes.Add(estudiante);
        }
    }
}
