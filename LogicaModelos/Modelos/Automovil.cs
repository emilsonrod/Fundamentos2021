
namespace LogicaModelos.Modelos
{
    public class Automovil
    {
        public Automovil(string marca, string numeroChasis, int numeroMotor)
        {
            Marca = marca;
            NumeroChasis = numeroChasis;
            NumeroMotor = numeroMotor;
            Placa = "000000";
            Kilometraje = 0;
        }

        public Automovil(string marca, string numeroChasis, int numeroMotor,
            string placa, int kilometraje)
        {
            Marca = marca;
            NumeroChasis = numeroChasis;
            NumeroMotor = numeroMotor;
            Placa = placa;
            Kilometraje = kilometraje;
        }

        public string Marca { get; set; }
        public string Placa { get; set; }
        public string NumeroChasis { get; set; }
        public int NumeroMotor { get; set; }
        public int Kilometraje { get; set; }


        public string MostrarDatos()
        {
            return string.Format("Automovil marca: {0}, chasis: {1}, motor: {2}, placa: {3}, kilometraje: {4} ",
                Marca, NumeroChasis, NumeroMotor, Placa, Kilometraje);
        }
    }
}
