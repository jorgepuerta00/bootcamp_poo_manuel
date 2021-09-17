using System;
namespace bootcamp
{
    public class VehiculosPersona
    {
        public Persona Persona;
        public VehiculoTerrestre Vehiculo;
        public VehiculoVolador Volador;

        public VehiculosPersona(Persona Persona, VehiculoTerrestre Vehiculo, VehiculoVolador Volador)
        {
            this.Persona = Persona;
            this.Vehiculo = Vehiculo;
            this.VehiculoVolador= Volador;
        }

        public override string ToString()
        {
            //string cadena = "Persona [" + Persona.Nombre + "] \n" + "vehiculo [" + Vehiculo.Marca +"]";
            //return cadena;

            return Persona.ToString() + "\n" + Vehiculo.ToString() + VehiculoVolador.Tostring();
        }
    }
}
