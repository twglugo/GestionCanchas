namespace Controlador
{
    using Modelos.Entidades;
    using Logica.Cliente;
    using Controlador.Utils.Cliente;

    public class ControladorCliente
    {

        /// Metodos para entidad Cliente y logica cliente
        /// 
        ///  Excepcion 

        public bool RegistrarClienteControlador(string cedula, string nombre, string telefono)
        {
            ClienteInsert NuevoCliente = new();
            ValidarUtilsCliente parse = new();

            try
            {
                int Cedula = parse.ParseTextTCedula(cedula);
                string Nombre = parse.EmptyTextNombre(nombre);
                int Telefono = parse.ParseTextTelefono(telefono);

                NuevoCliente.InsertarCliente(Cedula,Nombre,Telefono);
                return true;
                
            }
            catch (Exception )
            {

                throw;
            }
        }
        /// 
        /// Consutla de todos los clientes 
        /// 
        /// 

        public List<Clientes> ConsultaTotalCliente()
        {
            List<Clientes> listaClientes = new ();
            ClienteConsulta FuncionesCliente = new ();
            listaClientes = FuncionesCliente.ConsultarCliente();
            return listaClientes;
        }

       
    }
    
}