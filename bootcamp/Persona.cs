namespace bootcamp
{
    public class Persona
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona(string Cedula, string Nombre, string Apellido)
        {
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
        }

        public override string ToString()
        {
            return "Persona[ Cedula: " + Cedula + ", Nombre: " + Nombre + ", Apellido: " + Apellido + " ]";
        }
    }
}