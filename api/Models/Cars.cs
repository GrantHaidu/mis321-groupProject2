
namespace api.Models

{
    public class Cars
    {
        public int CarVIN { get; set; }

        public string carType { get; set; }

        public string carName { get; set; }

        public string carImage { get; set; }

        public string carPrice { get; set; }

        public int mpg { get; set; }

        public string shortDescrip { get; set; }

        public int carRange { get; set; }

        public int horsePower { get; set; }

        public string drive { get; set; }

        public string color { get; set; }
        public string transmission { get; set; }

        public int seat { get; set; }

        public string isDeleted { get; set; }

        static public int count { get; set; }
       

        public Cars()
        {

        }

        public override string ToString()
        {
            return $"CarVIN: {CarVIN}, carType: {carType}, carName: {carName}, carImage: {carImage}, carPrice: {carPrice}, mpg: {mpg}, shortDescrip: {shortDescrip}, carRange: {carRange}, horsePower: {horsePower}, drive: {drive}, color: {color}, transmission: {transmission}, seat: {seat}, isDeleted: {isDeleted}";
        }

    }
}