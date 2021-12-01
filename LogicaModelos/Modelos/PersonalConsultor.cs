using LogicaModelos.SuperClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaModelos.Modelos
{
    public class PersonalConsultor : Personal
    {
        public PersonalConsultor(string nombre, string apellido, string ci,
            string codigo)
        {
            Nombre = nombre;
            Apellido = apellido;
            CI = ci;
            CodPersonal = codigo;
            TipoContrato = "Trabajador Consultor";
        }

        public override string Identificarse()
        {
            return string.Format("Soy un Trabajador consultor con ci: {0}", CI);
        }
    }
}
