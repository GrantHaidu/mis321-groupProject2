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

            System.Console.WriteLine("getting cars ....");
            List<Cars> AllCars = new List<Cars>();
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT VIN, Make, Model, Year, Price, MpgE, ShortDescrip, eCar, Mile_Range FROM cars ;";
            using var cmd = new MySqlCommand(stm, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();

            System.Console.WriteLine("about to query ....");
            try
            {
                while (rdr.Read())
                {
                    Cars car = new Cars()
                    {

                        CarVIN = rdr.GetInt32(0),

                        CarMake = rdr.GetString(1),

                        CarModel = rdr.GetString(2),

                        CarPrice = rdr.GetDouble(3),

                        CarYear = rdr.GetInt32(4),

                        mpgE = rdr.GetInt32(6),

                        ShortDescrip = rdr.GetString(7),

                        eCar = rdr.GetBoolean(8),

                        carRange = rdr.GetInt32(9)
                    };

                    AllCars.Add(car);
                    System.Console.WriteLine(car.ToString());

                }
                System.Console.WriteLine("query sucessful");
            }
            catch
            {
                System.Console.WriteLine("query unsuccessful");
            }

            con.Dispose();
            return AllCars;
        }
    }
}

