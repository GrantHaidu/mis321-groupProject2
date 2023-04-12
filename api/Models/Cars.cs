
namespace api.Models

{
    public class Cars
    {
        public int CarVIN { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int  CarYear{ get; set; }
        public double CarPrice { get; set; }
        public int mpgE  { get; set; }
        public string ShortDescrip { get; set; }
        public bool eCar { get; set; }
         public int carRange { get; set; }
        static public int count { get; set; }
        // public ISaveSong Save {get; set;} 

        public Cars()
        {
            
        }
        
        public override string ToString()

        {
            return $"{this.CarVIN}\t{this.CarMake}\t{this.CarModel}\t{this.CarYear}\t{this.CarPrice}\t{this.mpgE}\t{this.ShortDescrip}\t{this.eCar}\t{this.carRange}";

        }
    }
}