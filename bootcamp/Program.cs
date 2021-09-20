using System;

namespace bootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona objPersona1 = new Persona("1234", "Manuel", "Hurtado");
            Persona objPersona2 = new Persona("1234", "Jorge", "Puerta");

            VehiculoTerrestre objVehiculo1 = new VehiculoTerrestre("Toyota", "Hilux", "2010", "Blanco", "CWT581", "Automovil", "5");
            VehiculoTerrestre objVehiculo2 = new VehiculoTerrestre("Toyota", "Hilux", "2010", "Blanco", "CWT582", "Automovil", "5");

            VehiculoVolador objVolador1 = new VehiculoVolador("Jumbo", "Jumbo", "2020", "Azul", "CWT58100", "Avión", "100");
            VehiculoVolador objVolador2= new VehiculoVolador("Avioneta", "Avioneta", "2020", "Rojo", "CWT58111", "Avioneta", "50");

            VehiculosPersona objVehiculosPersona1 = new VehiculosPersona(objPersona1, objVehiculo1, objVolador1);
            VehiculosPersona objVehiculosPersona2 = new VehiculosPersona(objPersona2, objVehiculo2, objVolador2);

            Console.WriteLine(objVehiculosPersona1);
            Console.WriteLine();
            Console.WriteLine(objVehiculosPersona2);

            Console.WriteLine();

            objVehiculosPersona1.Vehiculo.Encender();
            objVehiculosPersona1.Vehiculo.Arrancar();
            objVehiculosPersona1.Vehiculo.Detener();

            Console.WriteLine();

            objVehiculosPersona1.Volador.Encender();
            objVehiculosPersona1.Volador.Arrancar();
            objVehiculosPersona1.Volador.Volar();
            objVehiculosPersona1.Volador.Detener();

        }
    }
}
