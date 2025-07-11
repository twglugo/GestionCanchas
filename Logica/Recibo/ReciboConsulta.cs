namespace Logica.Recibo
{
    using Conexion;
    using MySql.Data.MySqlClient;
    using Modelos.Entidades;
    public class ReciboConsulta()
    {



        //Metodo Consultar 

        public List<Recibo> ConsultarRecibo()
        {
            List<Recibo> ReciboLista = new();
            Recibo? recibo;

            using (MySqlConnection Conect = Conecta.ObtenerConexion())
            {
                try
                {

                    Conect.Open();
                    string Query = "SELECT * FROM Recibo";
                    MySqlCommand Comando = new MySqlCommand(Query, Conect);
                    MySqlDataReader read = Comando.ExecuteReader();
                    while (read.Read())
                    {
                        int id = read.GetInt32(0);
                        DateTime fecha = read.GetDateTime(1);
                        float total = read.GetFloat(2);
                        string metodo = read.GetString(3);
                        int idrenta = read.GetInt32(4);
                        recibo = new Recibo(id, fecha, total, metodo, idrenta);
                        ReciboLista.Add(recibo);
                        


                    }             
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Error en la Consulta {ex.Message}");
                }
                catch (System.Exception e)
                {
                    throw new Exception($"Error en el sistema {e.Message}");
                    throw;
                }
                

            }

            return ReciboLista;
        }



    }

}