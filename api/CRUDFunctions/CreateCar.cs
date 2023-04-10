using api.Database;
using api.Models;
using MySql.Data.MySqlClient;
namespace repos.mis321_groupProject2.api.CRUDFunctions
{
    public class CreateCar
    {
        private string cs;
        public CreateCar()
        {
            ConnectionString connectionString = new ConnectionString();
            cs = connectionString.cs;
        }

        //insert new song into database
        public void CreateOne(Cars myCars)
        {
            System.Console.WriteLine("creating song ....");
            System.Console.WriteLine(mySongs.ToString());
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO Cars(*******)";
            using var cmd = new MySqlCommand(stm, con);
            cmd.Prepare();
            try
            {
                cmd.ExecuteNonQuery();
                System.Console.WriteLine("succesful");
            }
            catch
            {
                con.Close();

                System.Console.WriteLine("unsuccessful");
            }

        }
    }
}
