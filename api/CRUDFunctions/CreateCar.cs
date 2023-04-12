using api.Database;
using api.Models;
using MySql.Data.MySqlClient;
namespace api.CRUDFunctions
{
    public class CreateCar
    {
        private string cs;
        public CreateCar()
        {
            ConnectionString connectionString = new ConnectionString();
            cs = connectionString.cs;
        }
        public void CreateOne(Cars myCars)
        {
            System.Console.WriteLine("creating Car ....");
            System.Console.WriteLine(myCars.ToString());
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO cars(VIN,Make,Model,Year,Price,MpgE,ShortDescrip,eCar,Mile_Range) VALUES (@VIN, @Make, @Model, @Year, @Price, @MpgE, @ShortDescrip, @eCar, @Mile_Range)";
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
