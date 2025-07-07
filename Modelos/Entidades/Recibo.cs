namespace Modelos.Entidades
{
    public class Recibo
    {
        // Atributos de la clase Recibo
        private int Id;
        private Datetime fecha ;
        private float total;
        private string MetodoPago;
        private int IdRenta;

        // Constructor de la clase Recibo
        
        public Recibo(int id, Datetime fecha, float total, string metodoPago, int idRenta)
        {
            Id = id;
            this.fecha = fecha;
            this.total = total;
            MetodoPago = metodoPago;
            IdRenta = idRenta;
        }

        // Getters para los atributos
        public int GetId()
        {
            return Id;
        }
        public Datetime GetFecha()
        {
            return fecha;
        }
        public float GetTotal()
        {
            return total;
        }
        public string GetMetodoPago()
        {
            return MetodoPago;
        }
        public int GetIdRenta()
        {
            return IdRenta;
        }
        // Setters para los atributos
        public void SetFecha(Datetime fecha)
        {
            this.fecha = fecha;
        }
        public void SetTotal(float total)
        {
            this.total = total;
        }
        public void SetMetodoPago(string metodoPago)
        {
            MetodoPago = metodoPago;
        }
        public void SetIdRenta(int idRenta)
        {
            IdRenta = idRenta;
        }
        
        

        
    }
}