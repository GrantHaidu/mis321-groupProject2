using api.Models;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using api.Database;
namespace api.CRUDFunctions
{
    public class ReadAdmin
    {
        public List<Admin> GetAdmins()
        {

            System.Console.WriteLine("getting cars ....");
            List<Admin> AllAdmins = new List<Admin>();
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT adminid, admin_pass FROM admin ;";
            using var cmd = new MySqlCommand(stm, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();

            System.Console.WriteLine("about to query ....");
            try
            {
                while (rdr.Read())
                {
                    Admin admins = new Admin()
                    {

                        adminID = rdr.GetInt32(0),

                        adminPass = rdr.GetString(1),

                    };

                    AllAdmins.Add(admins);
                    System.Console.WriteLine(admins.ToString());

                }
                System.Console.WriteLine("query sucessful");
            }
            catch
            {
                System.Console.WriteLine("query unsuccessful");
            }

            con.Dispose();
            return AllAdmins;
        }
    }
}