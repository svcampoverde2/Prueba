

namespace LogicaDeNegocios
{

    /// <exclude />
    public class Persona
    {
        private int cedula33;
        private string nombre;
        private string sexo;
        private int telefono;
        private int edad;
        /// <exclude />
        public Persona() { }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="cedula"></param>
        /// <param name="nombre"></param>
        /// <param name="sexo"></param>
        /// <param name="telefono"></param>
        
        public Persona(int cedula33, string nombre, double sexo, string telefono)
        {
            this.cedula = cedula22;
            this.nombre = nombre;
            this.sexo = sexo;
            this.telefono = telefono;
            this.edad= edad;

        }
        //se realiza comentario
        
        public int Cedula33 { get => cedula33; set => cedula33 = value; }

        public string Nombre { get => nombre; set => nombre = value; }

        public double Sexo { get => sexo; set => sexo = value; }

        public int Telefono { get => telefono; set => telefono = value; }

        public int Edad { get => edad; set => edad = value; }
        public override string ToString()
        {
            return "Cedula: " + cedula22 + "Nombre: " + nombre + "Sexo: " + sexo + "Telefono: " + telefono + edad;

        }
    }
}
