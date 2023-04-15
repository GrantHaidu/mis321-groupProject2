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

            string stm = @"SELECT VIN, carName, Price, Mpg, ShortDescrip, Mile_Range, horse_power, drive, transmission, color,seat, isDeleted FROM cars ;";
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

                        carPrice = rdr.GetDouble(2),

                        mpg = rdr.GetInt32(3),

                        shortDescrip = rdr.GetString(4),

                        carRange = rdr.GetInt32(5),

                        horsePower = rdr.GetInt32(6),

                        drive = rdr.GetString(7),

                        transmission = rdr.GetString(8),

                        color= rdr.GetString(9),

                        seat = rdr.GetInt32(10),

                        isDeleted =  rdr.GetString(11)
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

