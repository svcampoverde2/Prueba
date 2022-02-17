

namespace LogicaDeNegocios
{

    /// <exclude />
    public class Persona
    {
        private int cedula22;
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
        
        public Persona(int cedula22, string nombre, string sexo, string telefono, int edad)
      
        {
            this.cedula = cedula22;
            this.nombre = nombre;
            this.sexo = sexo;
            this.telefono = telefono;
            this.edad= edad;

        }
        //se realiza comentario
        
       
        /// <summary>
        /// Gets or sets the cedula.
        /// </summary>
        /// <value>The cedula.</value>
     public int Cedula22 { get => cedula22; set => cedula22 = value; }
        /// <summary>
        /// Gets or sets the nombre.
        /// </summary>
        /// <value>The nombre.</value>
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
