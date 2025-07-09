namespace Modelos.Entidades
{
    public class Cancha
    {
        // Atributos de la clase Cancha
        
        private int Id;
        private int Numero;
        private bool Estado;
        private float Precio;

        // Constructor de la clase Cancha
        public Cancha(int id, int numero, bool estado, float precio)
        {
            Id = id;
            Numero = numero;
            Estado = estado;
            Precio = precio;
        }

        //Constructor Vacio

        public Cancha()
        {
            
        }
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

        // Setters para los atributos

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
    }


}