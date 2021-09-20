using System;

namespace bootcamp
{
    public class VehiculoVolador : Vehiculo
    {
        public VehiculoVolador(string Marca, string Linea, string Modelo, string Color, string Placa, string Tipo, string NumeroPasajeros)
            : base(Marca, Linea, Modelo, Color, Placa, Tipo, NumeroPasajeros)
        {

        }

        public void Volar()
        {
            Console.WriteLine("Vehiculo Volador [" + Tipo + "] esta volando.");
        }

        public override string ToString()
        {
            return "Vehiculo volador [ Marca: " + Marca + ", Linea: " + Linea + ", Color: " + Color + ", Tipo: " + Tipo + ", Pasajeros: " + NumeroPasajeros + " ]";
        }
    }
}