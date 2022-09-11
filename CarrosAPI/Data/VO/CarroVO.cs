using CarrosAPI.Models;
using CarrosAPI.Models.Base;

namespace CarrosAPI.Data.VO
{
    public class CarroVO
    {
        public int Id { get; set; }
        public string Cor { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public bool Disponivel { get; set; }
    }
}
