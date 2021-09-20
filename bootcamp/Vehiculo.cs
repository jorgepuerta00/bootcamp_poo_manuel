using System;

namespace bootcamp
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Linea { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public string NumeroPasajeros { get; set; }

        public Vehiculo(string Marca, string Linea, string Modelo, string Color, string Placa, string Tipo, string NumeroPasajeros)
        {
            this.Marca = Marca;
            this.Linea = Linea;
            this.Modelo = Modelo;
            this.Color = Color;
            this.Placa = Placa;
            this.Tipo = Tipo;
            this.NumeroPasajeros = NumeroPasajeros;
        }

        public Vehiculo()
        {
        }

        public void Arrancar()
        {
            Console.WriteLine("Vehiculo [" + Tipo + "] Arrancó");
        }

        public void Encender()
        {
            Console.WriteLine("Vehiculo [" + Tipo + "] Encendió");
        }

        public void Detener()
        {
            Console.WriteLine("Vehiculo [" + Tipo + "] se detuvo");
        }

        public override string ToString()
        {
            return "Vehiculo " + Tipo + " [ Marca: " + Marca + ", Linea: " + Linea + ", Color: " + Color + ", Pasajeros: " + NumeroPasajeros + " ]";
        }
    }
}
