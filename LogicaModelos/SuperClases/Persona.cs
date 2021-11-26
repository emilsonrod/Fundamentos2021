using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaModelos.SuperClases
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CI { get; set; }

        // para identificarse mostraremos el CI y codigo si tiene
        // las funciones abstractas obligan a las clases hijas a desarrollar
        // la funcionalidad declarada pero se implementa segun cada clase hija
        public abstract string Identificarse();
    }
}
