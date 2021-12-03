using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaModelos.Modelos
{
    public class Punto
    {
        public Punto(int coordX, int coordY)
        {
            CoordX = coordX;
            CoordY = coordY;
        }

        // propiedades publicas definidas
        public int CoordX { get; set; }
        public int CoordY { get; set; }

        // funcion o metodo
        public string MostrarCoordenadas()
        {
            string plano = "";
            if (CoordX >= 0 && CoordY >= 0)
            {
                plano = "I";
            }
            else if (CoordX < 0 && CoordY >= 0)
            {
                plano = "II";
            }
            else if (CoordX < 0 && CoordY < 0)
            {
                plano = "III";
            }
            else if (CoordX >= 0 && CoordY < 0)
            {
                plano = "IV";
            }

            return string.Format("Mis coordenadas son {0}, {1} y estoy en el plano {2}",
                CoordX, CoordY, plano);
        }

        public override string ToString()
        {
            return string.Format("Punto con coordenadas {0}, {1}",
                CoordX, CoordY);
        }
    }
}
