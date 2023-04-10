using System.Data;
using api.Database;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace api.Database
{
    public class database

    {
        private string cs { get; }

        private string stm { get; set; }

        public database()

        {
            ConnectionString connectionString = new ConnectionString();
            cs = connectionString.cs;

        }

        //test connection to deployed mysql database by selecting database version

 public void TestConnection()

        {

            using var con = new MySqlConnection(cs);

            con.Open();

            stm = "select VERSION()";

            using var cmd = new MySqlCommand(stm, con);

            string version = cmd.ExecuteScalar().ToString();

            System.Console.WriteLine($"Connection Successful.\nMySql Version: {version}");

            //con.Close();

}

        //make sure database cn be queried properly

        public void TestSongQuery()

        {
            using var con = new MySqlConnection(cs);

            con.Open();

            stm = "SELECT id, title, artist, date, favorited, deleted FROM Cars";

            using var cmd = new MySqlCommand(stm, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

        }
    }
}