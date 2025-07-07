namespace Conexion {

    using MySql.Data.MySqlClient;

    public static class Conecta
    {
        private static string connectionString = "Server=localhost;Database=GestionCanchas;Uid=root;Pwd=1234;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(connectionString);
        }
    }




}