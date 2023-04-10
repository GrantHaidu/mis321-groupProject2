namespace api.Models
{
    public class Customers
     {
        public int custID{ get; set; }
        public string customerFirstName { get; set; }
        public string customerLastName{ get; set; }
        public int customerPhone{ get; set; }
        public string customerEmail{ get; set; }
        public DateTime expDate{ get; set; }

        static public int count { get; set; }
        public Customers()
        {
            
        }
        
        public override string ToStringCust()
        {
            return $"{this.custID}\t{this.customerFirstName}\t{this.customerLastName}\t{this.customerPhone}\t{this.customerEmail}\t{this.expDate}";
        }
     }
}