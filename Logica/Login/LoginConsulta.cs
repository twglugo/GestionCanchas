namespace Logica.Login
{
    using Conexion;
    using MySql.Data.MySqlClient;
    public class LoginConsulta
    {

        //Consultar si Email Existe  -> 

        public bool ConsultaEmailCliente(string email)
        {
            bool Resultado;
            using (MySqlConnection Conect = Conecta.ObtenerConexion())
            {
                try
                {
                    Conect.Open();
                    string Query = "Select email from Login Where Login_Email = @Email ;";
                    MySqlCommand Comando = new MySqlCommand(Query, Conect);
                    Comando.Parameters.AddWithValue("@Email", email);
                    Resultado = Comando.ExecuteNonQuery() > 0;
                    return Resultado;
                }
                catch (MySqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                catch (System.Exception e)
                {

                    throw new Exception(e.Message);
                }
            }

        }

        // Busqueda por Cedula_Cliente

        public bool ConsultaCedulaCliente(long Cedula)
        {
            bool Resultado;
            using (MySqlConnection Conect = Conecta.ObtenerConexion())
            {
                try
                {
                    Conect.Open();
                    string Query = "SELECT  a.Cliente_Cli_Cedula  from Login a  WHERE  a.Cliente_Cli_Cedula = @Cedula";
                    MySqlCommand Comando = new (Query, Conect);
                    Comando.Parameters.AddWithValue("@Cedula", Cedula);
                    Resultado = Comando.ExecuteNonQuery() > 0;
                    return Resultado;
                }
                catch (MySqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                catch (System.Exception e)
                {
                    throw new Exception(e.Message);

                }
            }


        }
    }
}