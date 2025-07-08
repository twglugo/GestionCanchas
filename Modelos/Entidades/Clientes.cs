
namespace Modelos.Entidades
{
    public class Clientes
    {
        
        // Atributos de la clase Usuarios
        private int Cedula;
        private string Nombre;
        private int Telefono;

        // Constructor de la clase Usuarios

        public Clientes(int cedula, string nombre, int telefono)
        {
            Cedula = cedula;
            Nombre = nombre;
            Telefono = telefono;
        }
        
        // Getters  para los atributos
        public int GetCedula()
        {
            return Cedula;
        }   
        public string GetNombre()
        {
            return Nombre;
        }
        public int GetTelefono()
        {
            return Telefono;
        }
        // Setters para los atributos
        
        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }

        public void SetTelefono(int telefono)
        {
            Telefono = telefono;
        }


    }


}