namespace Logica.Cancha
{
   
    using MySql.Data.MySqlClient;
    using Modelos.Entidades;
    using Conexion;

    public class CanchasInsert
    {
        readonly Cancha Estadio;
        bool Resultado;

        //Contructor

        public CanchasInsert(Cancha Estadio) { this.Estadio = Estadio; }

        public CanchasInsert(){}


        //Metodo de Inserccion

        public bool InsertarCanchas()
        {

            using (MySqlConnection Conect = Conecta.ObtenerConexion())
            {
                try
                {
                    Conect.Open();
                    string Query = "INSERT INTO Canchas (Can_Numero, Can_Estado, Can_Precio) VALUES (@Numero, @Estado, @Precio)";

                    MySqlCommand Comando = new MySqlCommand(Query, Conect);
                    Comando.Parameters.AddWithValue("@Numero", Estadio.GetNumero());
                    Comando.Parameters.AddWithValue("@Estado", Estadio.GetEstado());
                    Comando.Parameters.AddWithValue("@Precio", Estadio.GetPrecio());
                    return Resultado = Comando.ExecuteNonQuery() > 0;


                }
                catch (MySqlException ex)
                {
                    throw new($"Comprobar error{ex.Message}");
                }
                catch (System.Exception)
                {

                    throw;
                }
            }



        }

    }

}