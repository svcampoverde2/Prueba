
namespace LogicaDeNegocios
{
   
    public class AdmVendedor
    {

        public bool RegistrarVendedor(Vendedor vendedor)
        {
            Vendedor registrar = vendedor;
            registrar.InsertarVendedor(registrar);
            return true;
        }
    }
}
