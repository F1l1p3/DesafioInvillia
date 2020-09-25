using System.ComponentModel.DataAnnotations;

namespace DesafioDotNet.Models
{
    public class Amigo 
    {
        [Key]
        public int Id {get;set;}

        public string Nome {get;set;}
    }
}