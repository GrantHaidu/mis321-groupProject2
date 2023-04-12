using api.Models;
using api.Database;
using MySql.Data.MySqlClient;

namespace repos.mis321_groupProject2.api.CRUDFunctions
{
    public class ReadCustomer
    {
        public List<Customers> GetCustomers()
        {

            System.Console.WriteLine("getting customers ....");
            List<Customers> AllCustomers = new List<Customers>();
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT id, fName, lName, phone, email, expDate FROM customers ";
            using var cmd = new MySqlCommand(stm, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();

            System.Console.WriteLine("about to query ....");
            try
            {
                while (rdr.Read())
                {
                    Customers customer = new Customers()
                    {
                        custID = rdr.GetInt32(0),

                        customerFirstName = rdr.GetString(1),

                        customerLastName = rdr.GetString(2),

                        customerPhone = rdr.GetString(3),

                        customerEmail = rdr.GetString(4),

                        expDate = rdr.GetDateTime(5)
                    };

                    AllCustomers.Add(customer);
                    System.Console.WriteLine(customer.ToString());

                }
                System.Console.WriteLine("query sucessful");
            }
            catch
            {
                System.Console.WriteLine("query unsuccessful");
            }

            con.Dispose();
            return AllCustomers;
        }
    }
}