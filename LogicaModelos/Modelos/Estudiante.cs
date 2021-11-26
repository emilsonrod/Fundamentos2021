using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaModelos.SuperClases;

namespace LogicaModelos.Modelos
{
    public class Estudiante : Persona
    {
        // La sobrecarga de funciones permite tener una firma similar firma de funcion
        // pero se la reconoce por la cantidad de parametros, o sea es diferente en la
        // cantidad y tipo de parametros
        public Estudiante(string nombre, string apellido, string ci, string codEst)
        {
            Nombre = nombre;
            Apellido = apellido;
            CI = ci;
            CodEst = codEst;
            ListaNotas = new List<int>();
        }

        public Estudiante(Estudiante estudiante)
        {
            Nombre = estudiante.Nombre;
            Apellido = estudiante.Apellido;
            CI = estudiante.CI;
            CodEst = estudiante.CodEst;
            ListaNotas = new List<int>();
        }

        public string CodEst { get; set; }
        public List<int> ListaNotas { get; set; }

        // para presentarse es mas importante el nombre
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

        // sobreescritura se encarga de remplazar totalmente la funcionalidad
        // de la funcion que queremos sobreescribir
        public override string Identificarse()
        {
            return string.Format("Soy un estudiante con ci: {0}", CI);
        }
    }
}
