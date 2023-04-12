namespace repos.mis321_groupProject2.api.Models
{
  
    public class Admin
     {
        public int adminID { get; set; }
        public string adminPass{ get; set; }
   
        static public int count { get; set; }
        

        public Admin()
        {
            
        }
        
        public string ToStringAdmin()
        {
            return $"{this.adminID}\t{this.adminPass}";
        }
     }
 }
