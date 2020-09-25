

using System.ComponentModel.DataAnnotations;

namespace DesafioDotNet.Models
{
    public class Jogo
    {
        [Key]
        public int Id {get;set;}
        public string NomeJogo {get;set;}
    }
}