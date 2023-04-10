namespace repos.mis321_groupProject2.api.Models
{
  
    public class Admin
     {
        public int adminID { get; set; }
        public string adminPass{ get; set; }
   
        static public int count { get; set; }
        // public ISaveSong Save {get; set;} 

        public Admin()
        {
            
        }
        
        public override string ToStringAdmin()
        {
            return $"{this.adminID}\t{this.adminPass}";
        }
     }
 }
