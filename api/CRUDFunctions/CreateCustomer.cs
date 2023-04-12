using api.Database;
using api.Models;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace repos.mis321_groupProject2.api.CRUDFunctions
{
    public class CreateCustomer
    {
        private string cs;
        public CreateCustomer()
        {
            ConnectionString connectionString = new ConnectionString();
            cs = connectionString.cs;
        }

        //insert new song into database
        public void CreateOne(Customers myCustomers)
        {
            System.Console.WriteLine("creating Customer ....");
            System.Console.WriteLine(myCustomers.ToString());
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO customers(id,fName,lName,phone,email,expDate) VALUES (@id, @fName, @lName, @phone, @email, @expDate)";
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