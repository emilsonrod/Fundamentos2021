using LogicaModelos.SuperClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaModelos.Modelos
{
    public class PersonalPlanta : Personal
    {
        public PersonalPlanta(string nombre, string apellido, string ci,
            string codigo)
        {
            Nombre = nombre;
            Apellido = apellido;
            CI = ci;
            CodPersonal = codigo;
            TipoContrato = "Trabajador Planta";
        }

        public override string Identificarse()
        {
            return string.Format("Soy un Trabajador de planta con ci: {0}", CI);
        }
    }
}
