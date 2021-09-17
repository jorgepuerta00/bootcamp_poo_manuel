using System;

namespace bootcamp
{
    public class VehiculoVolador
    {
        public string Tipo { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public String NumeroPasajeros { get; set; }

        public VehiculoTerrestre(string Tipo, string Modelo, string Color, string NumeroPasajeros)
        {
            this.Tipo = Tipo;
            this.Modelo = Modelo;
            this.Color = Color;
            this.NumoeroPasajeros= NumeroPasajeros;
            
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
© 2021 GitHub, Inc.
