namespace Logica.Cliente
{

    using Modelos.Entidades;
    using Conexion;
    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;


    public class ClienteConsulta
    {

        Modelos.Entidades.Clientes? Usuario;
        List<Clientes> ListaClientes = new List<Clientes>();


        // Consultar todos los clientes

        public List<Clientes> ConsultarCliente()
        {

            using (MySqlConnection Conect = Conecta.ObtenerConexion())
            {


                try
                {
                    Conect.Open();
                    string Query = "SELECT * FROM Clientes";

                    MySqlCommand Comando = new MySqlCommand(Query, Conect);

                    MySqlDataReader Reader = Comando.ExecuteReader();




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

        // Consultar todos los clientes por nombre
        public List<Clientes> ConsultarNombre(string Nombre)
        {

            using (MySqlConnection Conect = Conecta.ObtenerConexion())
            {
                try
                {
                    Conect.Open();
                    string Query = "SELECT * FROM  Clientes WHERE Cli_Nombre = @Nombre";
                    MySqlCommand Comando = new MySqlCommand(Query, Conect);
                    Comando.Parameters.AddWithValue("@Nombre", Nombre);

                    Comando.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Error al consultar los clientes {ex.Message}");

                }

                catch (System.Exception e)
                {

                    throw new Exception("Error al consultar los clientes: " + e.Message);

                }
            }

            return ListaClientes;
        }


    }

}