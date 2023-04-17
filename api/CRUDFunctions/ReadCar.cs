using api.Models;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using api.Database;
namespace api.CRUDFunctions
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

            string stm = @"SELECT VIN, carName, carImage, Price, Mpg, ShortDescrip, Mile_Range, horse_power, drive, transmission, color,seat, isDeleted FROM cars ;";
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

                        carName = rdr.GetString(1),

                        carImage = rdr.GetString(2),

                        carPrice = rdr.GetDouble(3),

                        mpg = rdr.GetInt32(4),

                        shortDescrip = rdr.GetString(5),

                        carRange = rdr.GetInt32(6),

                        horsePower = rdr.GetInt32(7),

                        drive = rdr.GetString(8),

                        transmission = rdr.GetString(9),

                        color = rdr.GetString(10),

                        seat = rdr.GetInt32(11),

                        isDeleted = rdr.GetBoolean(12)
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

