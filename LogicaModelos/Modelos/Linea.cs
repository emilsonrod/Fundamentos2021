using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaModelos.Modelos
{
    public class Linea
    {
        public Linea(Punto punto1, Punto punto2)
        {
            PrimerPunto = punto1;
            SegundoPunto = punto2;
        }

        public Linea()
        { }

        public Punto PrimerPunto { get; set; }
        public Punto SegundoPunto { get; set; }

        public double CalcularDistanciaPuntos()
        {
            int difCoordX = SegundoPunto.CoordX - PrimerPunto.CoordX;
            int difCoordY = SegundoPunto.CoordY - PrimerPunto.CoordY;
            double potX = Math.Pow(difCoordX, 2);
            double potY = Math.Pow(difCoordY, 2);
            return Math.Sqrt(potX + potY);
        }

        public double CalcularPendiente()
        {
            int difCoordX = SegundoPunto.CoordX - PrimerPunto.CoordX;
            int difCoordY = SegundoPunto.CoordY - PrimerPunto.CoordY;
            return difCoordY / difCoordX;
        }

        public string MostrarFuncionesLinea()
        {
            return string.Format("La distancia entre ambos puntos es {0}, y su pendiente es {1}",
                CalcularDistanciaPuntos(), CalcularPendiente());
        }
    }
}
