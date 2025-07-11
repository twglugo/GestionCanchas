namespace Logica.Renta
{
    using Conexion;
    using Modelos.Entidades;
    using MySql.Data.MySqlClient;

    public class RentaConsulta
    {

        public List<Renta> ConsultaTotal()
        {
            List<Renta> rentaLista = new();
            Renta renta;
            using (MySqlConnection Conect = Conecta.ObtenerConexion())
            {
                try
                {
                    Conect.Open();
                    string Query = "SELECT * FROM Renta";
                    MySqlCommand Comando = new MySqlCommand(Query, Conect);
                    MySqlDataReader read = Comando.ExecuteReader();
                    while (read.Read())
                    {
                        int Id = read.GetInt32(0);
                        DateTime Fecha = read.GetDateTime(1);
                        int Horas = read.GetInt32(2);
                        float Abono = read.GetFloat(3);
                        int clienteCedula = read.GetInt32(4);
                        int idCancha = read.GetInt32(5);
                        renta = new Renta(Id, Fecha, Horas, Abono, clienteCedula, idCancha);
                        rentaLista.Add(renta);
                    }
                    return rentaLista;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Error en la consulta -> {ex.Message}");
                }
                catch (System.Exception e)
                {

                    throw new Exception($"Error en el sistema -> {e.Message}");
                }
            }
            
        }

    }

}