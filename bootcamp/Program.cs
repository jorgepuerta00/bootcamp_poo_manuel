using System;

namespace bootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            VehiculoTerrestre objVehiculo1 = new VehiculoTerrestre("Toyota", "Hilux", "2010", "Blanco", "CWT581");
            VehiculoTerrestre objVehiculo2 = new VehiculoTerrestre("Toyota", "Hilux", "2010", "Blanco", "CWT582");
            VehiculoVolador objVolador1 = new VehiculoVolador("Jumbo","Dos mil","Blanco","Cien");
            VehiculoVolador objVolador2= new VehiculoVolaodor("Avioneta","Noventa","Gris","Cincuenta");

            objVehiculo1.Marca = "Ford";
            objVehiculo1.Linea = "Edge";
            objVehiculo1.Color = "Azul";
            objVolador1.Tipo="Coloso";
            ObjVolador1.Modelo="Dos mil";
            ObjVolador1.Color="Rojo";
            ObjVoaldor1.NumeroPasajeros="CIENTO CINCUENTA";

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
