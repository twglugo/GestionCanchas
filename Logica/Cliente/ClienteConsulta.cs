namespace Logica.Cliente{

    using Modelos.*;
    using Conexion;
    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;

    public static class ClienteConsulta{

            Modelos.Entidades.Clientes Usuario ;


        // Consultar todos los clientes

        public static List<Clientes> ConsultarCliente()
        {
            
            using (MySqlConnection Conect = Conecta.ObtenerConexion()){

                
                try
                {
                    Conect.Open();
                    string Query = "SELECT * FROM Clientes";

                    MySqlCommand Comando = new MySqlCommand(Query, Conect);

                    MySqlDataReader Reader = Comando.ExecuteReader();
                    

                    List<Clientes> ListaClientes = new List<Clientes>();
                
                    while (Reader.Read())  
                    {
                        int Cedula = Reader.GetInt32("Cli_Cedula");
                        string Nombre = Reader.GetString("Cli_Nombre");
                        int Telefono = Reader.GetInt32("Cli_Telefono");

                        Usuario = new Clientes(Cedula, Nombre, Telefono);
                        ListaClientes.Add(Usuario);
                    }
                }
                catch (MySqlException e)
                {
                    throw new Exception("Error al consultar los clientes: " + e.Message);
                }
                catch (System.Exception)
                {
                    
                    throw;
                }
                
                



            }
            return ListaClientes;


        }


        public static List<Cliente> ConsultarNombre(){

            using (MySqlConnection Conect = Conecta.ObtenerConexion())
            {
                try
                {
                    
                }
                catch (System.Exception)
                {
                    
                    throw new Exception("Error al consultar los clientes: " + e.Message);
                    
                }
            }

        }


    }

}