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

         public VehiculoTerrestre(string Tipo, string Modelo, string NumeroPasajeros)
        {
            this.Tipo = Tipo;
            this.Modelo = Modelo;
            this.NumoeroPasajeros= NumeroPasajeros;
            
        }

        public VehiculoTerrestre()
        {

        }

        public void Arrancar()
        {
            Console.WriteLine("Vehiculo Volador [" + Tipo + ", Modelo :" + Modelo + "] Arrancó");
        }

        public void Encender()
        {
            Console.WriteLine("Vehiculo terrestre [" + Tipo + "] Encendió");
        }

        public void Detener()
        {
            Console.WriteLine("Vehiculo terrestre [" + Tipo+ "] se detuvo");
        }

        public override string ToString()
        {
            return "Vehiculo Volador [ Tipo: " + Tipo + ", Modelo: " + Modelo + ", Color: " + Color + " ]"; //porque se le coloca overide?// //si yo llamo cualquier de estos metodos también me muestra?//
        }
    }
}
© 2021 GitHub, Inc.
