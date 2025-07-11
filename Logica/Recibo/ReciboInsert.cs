

namespace Logica.Recibo
{
    using MySql.Data.MySqlClient;
    using Conexion;
    public class ReciboInsert
    {


        public bool InsertarRecibo(DateTime fecha, float total, string metodo, int idRenta)
        {

            using (MySqlConnection Conect = Conecta.ObtenerConexion())
            {
                try
                {
                    Conect.Open();
                    string Query = "INSERT INTO Recibo (Rec_Fecha, Rec_total, Rec_Metodo, Renta_Ren_Id) values (@Fecha, @total, @Metodo, @IdRenta)";
                    MySqlCommand Comando = new MySqlCommand(Query, Conect);
                    Comando.Parameters.AddWithValue("@Fecha", fecha);
                    Comando.Parameters.AddWithValue("@total", total);
                    Comando.Parameters.AddWithValue("@Metodo", metodo);
                    Comando.Parameters.AddWithValue("@IdRenta", idRenta);

                    Comando.ExecuteNonQuery();

                    return true;

                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Error en la inserccion {ex.Message}");
                    
                    
                }

                catch (System.Exception e)
                {

                    throw new Exception($"Error en el sistema {e.Message}");

                }
            }


                
        }
    }



}