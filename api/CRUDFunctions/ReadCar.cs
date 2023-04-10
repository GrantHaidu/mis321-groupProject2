using api.Models;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using api.Database;
namespace repos.mis321_groupProject2.api.CRUDFunctions
{
    public class ReadCar
    {


        public List<Cars> GetCars()
        {

            System.Console.WriteLine("getting songs ....");
            List<Cars> AllCars = new List<Cars>();
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();
            string stm = @"SELECT id, title, artist, DATE_FORMAT(date, '%M %e, %Y %h:%i %p' ) AS format_currentdate, favorited, deleted FROM songs WHERE deleted LIKE 'n' ORDER BY date DESC;";
            using var cmd = new MySqlCommand(stm, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();

            System.Console.WriteLine("about to query ....");
            try
            {
                while (rdr.Read())
                {
                    Songs song = new Songs()
                    {

                        SongID = rdr.GetInt32(0),

                        SongTitle = rdr.GetString(1),

                        Artist = rdr.GetString(2),

                        Date = rdr.GetString(3),

                        Favorited = rdr.GetString(4),

                        Deleted = rdr.GetString(5)

                    };
                    AllSongs.Add(song);
                    System.Console.WriteLine(song.ToString());

                }
                System.Console.WriteLine("query sucessful");
            }
            catch
            {
                System.Console.WriteLine("query unsuccessful");
            }

            con.Dispose();
            return AllSongs;
        }
    }
}

