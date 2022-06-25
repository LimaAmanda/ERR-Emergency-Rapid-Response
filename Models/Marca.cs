using System.ComponentModel.DataAnnotations;

namespace ProjetoErr.Models
{
    public class Marca
    {
        [Key]
        public int IdMarca { get; set; }
        public string dsMarca { get; set; }

        
    }
}