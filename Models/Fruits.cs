using System.ComponentModel.DataAnnotations;

namespace personWebApp.Models
{
    public class Fruits
    {

        public int Id { get; set; }
        
        public string name { get; set; }
        
        public int count { get; set; }
        public string country { get; set; }
        public string taste { get; set; }
    }
}
