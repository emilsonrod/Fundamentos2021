using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaModelos.SuperClases;

namespace LogicaModelos.Modelos
{
    class Personal : Persona
    {
        public Personal(string nombre, string apellido, string ci,
            string codigo, string tipo )
        {
            Nombre = nombre;
            Apellido = apellido;
            CI = ci;
            CodPersonal = codigo;
            TipoContrato = tipo;
        }

        public string CodPersonal { get; set; }
        public string TipoContrato { get; set; }

        public string PresentarPersonal()
        {
            return string.Format("Personal con codigo - {0}, nombre Completo - {1} {2}, ci- {3}",
                CodPersonal, Nombre, Apellido, CI);
        }
    }
}
