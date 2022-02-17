
using Datos;
using MySqlConnector;
using System;
using System.Collections.Generic;

namespace LogicaDeNegocios
{
    public class Vendedor : Persona
    {
        private double sueldoVendedor;
        CredencialUsuario credencialUsuario;
        public Vendedor(string cedula, string nombre, string sexo, string telefono, double sueldoVendedor, CredencialUsuario credencialUsuario)
            : base(cedula, nombre, sexo, telefono)
        {
            this.sueldoVendedor = sueldoVendedor;
            this.credencialUsuario = credencialUsuario;
        }

        public double SueldoVendedor { get => sueldoVendedor; set => sueldoVendedor = value; }
        public CredencialUsuario CredencialUsuario { get => credencialUsuario; set => credencialUsuario = value; }

        public void InsertarVendedor(Vendedor vendedor)
        {
            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            try
            {
                List<Vendedor> ListaNueva = new List<Vendedor>();
                ListaNueva.Add(vendedor);
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("spl_insertarVendedor", con.conectar());
                foreach (Vendedor Vendedor in ListaNueva)
                {
                    mySqlCommand.Parameters.AddWithValue("@CedulaFx", Vendedor.Cedula);
                    mySqlCommand.Parameters.AddWithValue("@NombreFx", Vendedor.Nombre);
                    mySqlCommand.Parameters.AddWithValue("@SexoFx", Vendedor.Sexo);
                    mySqlCommand.Parameters.AddWithValue("@TelefonoFx", Vendedor.Telefono);
                    mySqlCommand.Parameters.AddWithValue("@SueldoFx", Vendedor.Sueldo);
                    mySqlCommand.Parameters.AddWithValue("@CorreoFx", Vendedor.CredencialUsuario.Correo);
                    mySqlCommand.Parameters.AddWithValue("@ContrasenaFx", Vendedor.CredencialUsuario.Contrasena);
                    mySqlCommand.Parameters.AddWithValue("@Foreking_RolesUsuarioFx", Vendedor.CredencialUsuario.Rol);

                }
                mySqlCommand.ExecuteReader();
                con.cerrar();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex);
            }

        }

        
    }
}
