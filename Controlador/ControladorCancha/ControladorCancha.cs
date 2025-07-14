namespace Controlador.ControladorCancha
{

    using Logica.Cancha;
    using Modelos.Entidades;
    using Utils.Cancha;
    public class ControladorCancha
    {

        public List<Cancha> ConsultaTotalCanchas()
        {
            CanchaConsulta Estadios = new();
            List<Cancha> ListaEstadios = new(); 
            ListaEstadios = Estadios.ConsultaTotal();
            
            return ListaEstadios;
               
            
        }

        public bool InsertTotalCanchas(string precio, string direccion, bool estado)
        {
            ValidarUtilsCancha Parse = new();
            CanchasInsert EstadioNuevo;
            Cancha Estadio = new();
            try
            {
                float nuevoPrecio = Parse.ParseTextPrecio(precio);
                string nuevaDireccion = Parse.ParseTextDirrecion(direccion);
                Estadio.SetEstado(estado);
                Estadio.SetPrecio(nuevoPrecio);
                Estadio.SetDireccion(nuevaDireccion);

                EstadioNuevo = new CanchasInsert(Estadio);
                EstadioNuevo.InsertarCanchas();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }

}