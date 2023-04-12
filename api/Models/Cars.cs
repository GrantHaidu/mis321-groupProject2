
namespace api.Models

{
    public class Cars
    {
        public int CarVIN { get; set; }

        public string carName { get; set; }

        public double carPrice { get; set; }

        public int mpg { get; set; }

        public string shortDescrip { get; set; }

        public int carRange { get; set; }

        public int horsePower { get; set; }

        public string drive { get; set; }

        public string color { get; set; }

        public int seat { get; set; }

        public bool isDeleted { get; set; }

        public string transmission { get; set; }

        static public int count { get; set; }
        // public ISaveSong Save {get; set;} 

        public Cars()
        {

        }

        public override string ToString()

        {
            return $"{this.CarVIN}\t{this.carName}\t{this.carPrice}\t{this.mpg}\t{this.shortDescrip}\t{this.carRange}\t{this.horsePower}\t{this.drive}\t{this.color}\t{this.seat}\t{this.transmission}\t{this.isDeleted}";

        }
    }
}