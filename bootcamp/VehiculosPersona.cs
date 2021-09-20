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
            this.Volador = Volador;
        }

        public override string ToString()
        {
            return Persona.ToString() + "\n" + Vehiculo.ToString() + "\n" + Volador.ToString();
        }
    }
}
