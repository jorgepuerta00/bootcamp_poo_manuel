using System;

namespace bootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            VehiculoTerrestre objVehiculo1 = new VehiculoTerrestre("Toyota", "Hilux", "2010", "Blanco", "CWT581");
            VehiculoTerrestre objVehiculo2 = new VehiculoTerrestre("Toyota", "Hilux", "2010", "Blanco", "CWT582");

            objVehiculo1.Marca = "Ford";
            objVehiculo1.Linea = "Edge";
            objVehiculo1.Color = "Azul";

            Persona objPersona1 = new Persona("1234", "Manuel", "Hurtado");
            Persona objPersona2 = new Persona("1234", "Jorge", "Puerta");

            VehiculosPersona objVehiculosPersona1 = new VehiculosPersona(objPersona1, objVehiculo1);
            VehiculosPersona objVehiculosPersona2 = new VehiculosPersona(objPersona2, objVehiculo2);

            Console.WriteLine(objVehiculosPersona1);
            Console.WriteLine();
            Console.WriteLine(objVehiculosPersona2);

        }
    }
}