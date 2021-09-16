using System;
namespace bootcamp
{
    public class VehiculosPersona
    {
        public Persona Persona;
        public VehiculoTerrestre Vehiculo;

        public VehiculosPersona(Persona Persona, VehiculoTerrestre Vehiculo)
        {
            this.Persona = Persona;
            this.Vehiculo = Vehiculo;
        }

        public override string ToString()
        {
            //string cadena = "Persona [" + Persona.Nombre + "] \n" + "vehiculo [" + Vehiculo.Marca +"]";
            //return cadena;

            return Persona.ToString() + "\n" + Vehiculo.ToString();
        }
    }
}