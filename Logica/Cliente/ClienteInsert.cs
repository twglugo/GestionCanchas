namespace Logica.Cliente
{
    using MySql.Data.MySqlClient;
    using Conexion;
    using System;
    

    public static class ClienteInsert
    {

        


        //Insertar un cliente

        public static bool InsertarCliente(int Cedula, string Nombre, int Telefono)
        {
            bool resultado = false;
            using(MySqlConnection Conectar = Conecta.ObtenerConexion())
            {
                try
                {
                    Conectar.Open();
                    string Query = "INSERT INTO Clientes (Cli_Cedula, Cli_Nombre, Cli_Telefono) VALUES (@Cedula, @Nombre, @Telefono)";
                    MySqlCommand Comando = new MySqlCommand(Query, Conectar);
                    Comando.Parameters.AddWithValue("@Cedula", Cedula);
                    Comando.Parameters.AddWithValue("@Nombre", Nombre); 
                    Comando.Parameters.AddWithValue("@Telefono", Telefono);
                    bool Resultado = Comando.ExecuteNonQuery() >  0;
                    
                    
                    
                    
                    

                }
                catch(MySqlException e)
                {
                    throw new Exception("Error al insertar el cliente: " + e.Message);

                }

                catch (System.Exception e )
                {
                    throw new Exception("Error al insertar el cliente: " + e.Message);
                    throw;
                }
                    




            }


            
            return resultado; 
        }


    }


}