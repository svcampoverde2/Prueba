﻿

namespace LogicaDeNegocios
{

    /// <exclude />
    public class Persona
    {
        private int cedula;
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
        
        public Persona(int cedula, string nombre, string sexo, string telefono, int edad)
      
        {
            this.cedula = cedula;
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
     public int Cedula { get => cedula; set => cedula = value; }
        /// <summary>
        /// Gets or sets the nombre.
        /// </summary>
        /// <value>The nombre.</value>
        public string Nombre { get => nombre; set => nombre = value; }

        public string Sexo { get => sexo; set => sexo = value; }

        public int Telefono { get => telefono; set => telefono = value; }

        public int Edad { get => edad; set => edad = value; }
        public override string ToString()
        {
            return "Cedula: " + cedula + "Nombre: " + nombre + "Sexo: " + sexo + "Telefono: " + telefono + edad;

        }
    }
}
