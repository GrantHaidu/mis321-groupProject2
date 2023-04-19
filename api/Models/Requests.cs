namespace api.Models
{
    public class Requests
    {
        public int car { get; set; }
        public string customerFirstName { get; set; }
        public string customerLastName { get; set; }
        public string customerEmail { get; set; }
        public string? carName { get; set; }
        public DateTime expDate { get; set; }

        static public int count { get; set; }
        public Requests()
        {

        }
        public override string ToString()
        {
            return $"First Name: {customerFirstName}, Last Name: {customerLastName}, Email: {customerEmail}, Car Name: {carName}, Expiration Date: {expDate.ToString("MM/dd/yyyy")}";
        }

    }
}