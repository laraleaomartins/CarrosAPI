using CarrosAPI.Models.Base;

namespace CarrosAPI.Models
{
    public class Carro : BaseEntity
    {
        public string Cor { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public bool Disponivel { get; set; }
    }
}
