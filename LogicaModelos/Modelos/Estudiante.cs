using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaModelos.Modelos
{
    class Estudiante
    {

        public Estudiante(string nombre, string apellido, string ci, string codEst)
        {
            Nombre = nombre;
            Apellido = apellido;
            CI = ci;
            CodEst = codEst;
            ListaNotas = new List<int>();
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CI { get; set; }
        public string CodEst { get; set; }
        public List<int> ListaNotas { get; set; }

        public string PresentarEstudiante()
        {
            return string.Format("Estudiante con codigo - {0}, nombre Completo - {1} {2}, ci- {3}",
                CodEst, Nombre, Apellido, CI);
        }

        public int PromedioNotas()
        {
            int sumatoria = 0;

            foreach (int nota in ListaNotas)
            {
                sumatoria = sumatoria + nota;
            }

            return sumatoria / ListaNotas.Count;
        }
    }
}
