using System;

namespace bootcamp
{
    public class VehiculoTerrestre
    {
        public string Marca { get; set; }
        public string Linea { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Placa { get; set; }

        public VehiculoTerrestre(string Marca, string Linea, string Modelo, string Color, string Placa)
        {
            this.Marca = Marca;
            this.Linea = Linea;
            this.Modelo = Modelo;
            this.Color = Color;
            this.Placa = Placa;
        }

        public VehiculoTerrestre(string Marca, string Linea, string Modelo)
        {
            this.Marca = Marca;
            this.Linea = Linea;
            this.Modelo = Modelo;
        }

        public VehiculoTerrestre()
        {

        }

        public void Arrancar()
        {
            Console.WriteLine("Vehiculo terrestre [" + Marca + ", Linea :" + Linea + "] Arrancó");
        }

        public void Encender()
        {
            Console.WriteLine("Vehiculo terrestre [" + Marca + "] Encendió");
        }

        public void Detener()
        {
            Console.WriteLine("Vehiculo terrestre [" + Marca + "] se detuvo");
        }

        public override string ToString()
        {
            return "Vehiculo terrestre [ Marca: " + Marca + ", Linea: " + Linea + ", Color: " + Color + " ]";
        }
    }
}