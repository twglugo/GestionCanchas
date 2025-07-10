namespace Modelos.Entidades {

    public class Renta
    {
        //Atributos de la clase Renta

        private int Id;
        private DateTime Fecha;
        private int HoraTotal;
        private float Abono;
        private int CedulaUsuario;
        private int IdCancha;

        //Constructor de la clase Renta
        public Renta(int id, DateTime fecha, int horaTotal, float abono, int cedulaUsuario, int idCancha)
        {
            Id = id;
            Fecha = fecha;
            HoraTotal = horaTotal;
            Abono = abono;
            CedulaUsuario = cedulaUsuario;
            IdCancha = idCancha;
        }

        //Getters para los atributos
        public int GetId()
        {
            return Id;
        }               

        public DateTime GetFecha()
        {
            return Fecha;
        }

        public int GetHoraTotal()
        {
            return HoraTotal;
        }
        
        public float GetAbono()
        {
            return Abono;
        }
        public int GetCedulaUsuario()
        {
            return CedulaUsuario;
        }
        public int GetIdCancha()
        {
            return IdCancha;
        }
        //Setters para los atributos

        public void SetFecha(DateTime fecha)
        {
            Fecha = fecha;
        }
        public void SetHoraTotal(int horaTotal)
        {
            HoraTotal = horaTotal;
        }
        public void SetAbono(float abono)
        {
            Abono = abono;
        }
        public void SetCedulaUsuario(int cedulaUsuario)
        {
            CedulaUsuario = cedulaUsuario;
        }
        public void SetIdCancha(int idCancha)
        {
            IdCancha = idCancha;
        }
        









    }


















}