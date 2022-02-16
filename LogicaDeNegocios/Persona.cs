

namespace LogicaDeNegocios
{

    /// <exclude />
    public class Persona
    {
        private int cedula;
        private string nombre;
        private string sexo;
        private string telefono;
        /// <exclude />
        public Persona() { }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="cedula"></param>
        /// <param name="nombre"></param>
        /// <param name="sexo"></param>
        /// <param name="telefono"></param>
        
        public Persona(int cedula, string nombre, string sexo, string telefono)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.sexo = sexo;
            this.telefono = telefono;

        }
        //se realiza comentario
        
        public int Cedula { get => cedula; set => cedula = value; }

        public string Nombre { get => nombre; set => nombre = value; }

        public string Sexo { get => sexo; set => sexo = value; }

        public string Telefono { get => telefono; set => telefono = value; }

        public override string ToString()
        {
            return "Cedula: " + cedula + "Nombre: " + nombre + "Sexo: " + sexo + "Telefono: " + telefono;

        }
    }
}
