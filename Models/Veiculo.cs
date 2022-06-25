using ProjetoErr.Models.Enuns;

namespace ProjetoErr.Models
{
    public class Veiculo
    {
        public int Id { get; set; }

        public int IdMarca { get; set; } 

        public string Modelo { get; set; } //= "Corola";

        public ClasseEnum ClasseEnum{ get; set; } = ClasseEnum.Toyota;
    }
}