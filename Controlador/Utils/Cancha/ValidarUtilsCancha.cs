namespace Controlador.Utils.Cancha
{
    using Controlador;
    using Logica.Cancha;
    using Modelos.Entidades;

    public class ValidarUtilsCancha
    {

        //Manejo de conversion de int de precio Utils
        public float ParseTextPrecio(string precio)
        {
            if (string.IsNullOrEmpty(precio))
            {
                throw new Exception("No puede estar vacio...");
            }
            if (!int.TryParse(precio, out int Precio))
            {
                throw new Exception("Debe ser numerico el precio !!!!");
            }
            if (!(Precio < 0))
            {
                throw new Exception("Debe ser mayor a cero!!!");

            }

            return Precio;


        }

        public string ParseTextDirrecion(string direccion)
        {

            if (string.IsNullOrWhiteSpace(direccion))
            {
                throw new Exception("No puede dejarse vacio el campo Direccion");

            }

            return direccion;


        }



        
    }

}