namespace bootcamp
{
    public class VehiculoTerrestre : Vehiculo
    {
        public VehiculoTerrestre(string Marca, string Linea, string Modelo, string Color, string Placa, string Tipo, string NumeroPasajeros)
            : base(Marca, Linea, Modelo, Color, Placa, Tipo, NumeroPasajeros)
        {
            
        }

        public override string ToString()
        {
            return "Vehiculo terrestre [ Marca: " + Marca + ", Linea: " + Linea + ", Color: " + Color + ", Tipo: " + Tipo + ", Pasajeros: " + NumeroPasajeros + " ]";
        }
    }
}