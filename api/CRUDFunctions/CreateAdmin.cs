using api.Database;
using api.Models;
using MySql.Data.MySqlClient;
namespace api.CRUDFunctions
{
    public class CreateAdmin
    {
        private string cs;
        public CreateAdmin()
        {
            ConnectionString connectionString = new ConnectionString();
            cs = connectionString.cs;
        }
        public void CreateOne(Admin myAdmins)
        {
            System.Console.WriteLine("creating Admin ....");
            System.Console.WriteLine(myAdmins.ToString());
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO admin(adminid,admin_pass) VALUES (@adminid, @admin_pass)";
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