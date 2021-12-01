using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaModelos.SuperClases
{
    public abstract class Personal : Persona
    {
        public string CodPersonal { get; set; }
        public string TipoContrato { get; set; }

        //// para presentarse es mas importante el nombre
        //public string PresentarPersonal()
        //{
        //    return string.Format("Personal con codigo - {0}, nombre Completo - {1} {2}, ci- {3}",
        //        CodPersonal, Nombre, Apellido, CI);
        //}        
    }
}
