namespace CarrosAPI.Models
{
    public class Carro
    {
        public int CarroId { get; set; }
        public string Cor { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public bool Disponivel { get; set; }
    }
}
