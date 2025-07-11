namespace Logica.Renta
{
    using Conexion;
    using MySql.Data.MySqlClient;

    public class RentaInsert
    {

        public bool InsertarRenta(DateTime fecha, int horas, float abono, int cedulaCancha, int idCancha)
        {
            using (MySqlConnection Conect = Conecta.ObtenerConexion())
            {
                try
                {
                    Conect.Open();
                    string Query = "INSERT INTO Renta (Ren_Fecha, Ren_Horas, Ren_Abono, Cliente_Cli_Cedula, Cancha_idCancha) VALUES (@fecha, @horas, @abono, @clienteCedula, @idCancha);";
                    MySqlCommand Comando = new MySqlCommand(Query, Conect);
                    Comando.Parameters.AddWithValue("@fecha", fecha);
                    Comando.Parameters.AddWithValue("@horas", horas);
                    Comando.Parameters.AddWithValue("@abono", abono);
                    Comando.Parameters.AddWithValue("@clienteCedula", cedulaCancha);
                    Comando.Parameters.AddWithValue("@idCancha", idCancha);
                    bool Resultado = Comando.ExecuteNonQuery() > 0;
                    return Resultado;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Error en la consulta {ex.Message}");
                }
                catch (System.Exception e)
                {

                    throw new Exception($"Error en el sistema {e.Message} ");
                }    
            }
 
        }

    }

}