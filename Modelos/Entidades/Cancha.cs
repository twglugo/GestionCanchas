namespace Modelos.Entidades
{
    public class Cancha
    {
        // Atributos de la clase Cancha

        private int Id;
        private int Numero;
        private bool Estado;
        private float Precio;

        private string Direccion;

        // Constructor de la clase Cancha
        public Cancha(int id, int numero, bool estado, float precio, string direccion)
        {
            Id = id;
            Numero = numero;
            Estado = estado;
            Precio = precio;
            Direccion = direccion;
        }

        //Constructor Vacio

        
        // Getters para los atributos

        public int GetId()
        {
            return Id;
        }

        public int GetNumero()
        {
            return Numero;
        }

        public bool GetEstado()
        {
            return Estado;
        }

        public float GetPrecio()
        {
            return Precio;
        }

        public string GetDireccion()
        {

            return Direccion;
        }

        // Setters para los atributos

        public void SetId(int id)
        {

            Id = id;
        }
        public void SetNumero(int numero)
        {
            Numero = numero;
        }
        public void SetEstado(bool estado)
        {
            Estado = estado;
        }
        public void SetPrecio(float precio)
        {
            Precio = precio;
        }

        public void SetDireccion(string direccion)
        {
            Direccion = direccion;

        }
    }


}