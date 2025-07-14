namespace Logica.Login
{
    using MySql.Data.MySqlClient;
    
    using Conexion;
    public class LoginInsert
    {
        //Creacion de Usuario -> Rol CLiente
        public bool InsertarNewLogger(string email, string password, long Cliente_Cedula)
        {
            bool Resultado;
            using (MySqlConnection Conect = Conecta.ObtenerConexion())
            {

                try
                {
                    Conect.Open();
                    string Query = "INSERT INTO Login (Login_Email, Login_Password, Cliente_Cli_Cedula) VALUES (@Email, @Password, @Cliente_Cedula );";
                    MySqlCommand Comando = new MySqlCommand(Query, Conect);
                    Comando.Parameters.AddWithValue("@email", email);
                    Comando.Parameters.AddWithValue("@password", password); 
                    Comando.Parameters.AddWithValue("@Cliente_Cedula",  Cliente_Cedula);
                    Resultado = Comando.ExecuteNonQuery() > 0;
                }
                catch (MySqlException e)
                {
                    throw new Exception($"Usuario ya registrado ->  {e.Message}");
                }
                catch (System.Exception ex)
                {

                    throw new Exception($"Error en sistema -> {ex.Message}");
                }

            }
            return true;
        }
    }
}