namespace Logica.Cancha
{
    using MySql.Data.MySqlClient;
    using Modelos.Entidades;
    using Conexion;

    public class CanchaConsulta
    {

       

        

        //Metodos de Consultas Básicas

        /**** Consulta de todo sin where ****/
        public List<Cancha> ConsultaTotal()
        {
            List<Cancha> CanchaLista = new ();
            Cancha? Estadio;
            using (MySqlConnection Conect = Conecta.ObtenerConexion())
            {
                try
                {
                    Conect.Open();
                    string Query = "SELECT * FROM Cancha";
                    MySqlCommand Comando = new MySqlCommand(Query, Conect);
                    MySqlDataReader read = Comando.ExecuteReader();
                    while (read.Read())
                    {
                        int Id = read.GetInt32(0);
                        int Numero = read.GetInt32(1);
                        bool Estado = read.GetBoolean(2);
                        float Precio = read.GetFloat(3);
                        Estadio = new Cancha(Id, Numero, Estado, Precio);
                        CanchaLista.Add(Estadio);

                    }


                    return CanchaLista;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Error en la consulta {ex.Message}");
                }

                catch (System.Exception e)
                {
                    throw new Exception ($"Error ->{e.Message}");
                    
                }

            }
    }



}

}