using System;
using LogicaModelos.Modelos;

namespace LogicaModelos.Controllers
{
    public class EjeCartesiano
    {
        public EjeCartesiano()
        {
            ListaPuntos = new Punto[5];
        }

        private Punto[] ListaPuntos { get; set; }

        public void AgregarPunto(Punto punto)
        {
            ListaPuntos[LastIndex()] = punto;
        }

        private int LastIndex()
        {
            for (int index = 0; index < ListaPuntos.Length; index++)
            {
                if (ListaPuntos[index] == null)
                {
                    return index;
                }
            }
            return 0;
        }

        public void MostrarPlanos()
        {
            foreach (Punto punto in ListaPuntos)
            {
                Console.WriteLine(punto.MostrarCoordenadas());
            }
        }

        public void MostrarDistancias()
        {
            for (int pibot = 0; pibot < ListaPuntos.Length; pibot++)
            {
                for (int index = 0; index < ListaPuntos.Length; index++)
                {
                    if (pibot != index)
                    {
                        Linea lineaAux = new Linea(ListaPuntos[pibot], ListaPuntos[index]);
                        Console.WriteLine("Para el punto {0} con el punto {1}", pibot + 1, index + 1);
                        Console.WriteLine(lineaAux.MostrarFuncionesLinea());
                    }
                }
            }
        }
    }
}
