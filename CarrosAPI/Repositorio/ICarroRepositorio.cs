using CarrosAPI.Models;

namespace CarrosAPI.Repositorio
{
    public interface ICarroRepositorio
    {
        Task<IEnumerable<Carro>> BuscarCarros();
        Task<Carro> BuscarCarros(int? id);
        Task<Carro> CriarCarro(Carro carro);
        Task AtualizarCarro(Carro carro, int id);
        Task DeletarCarro(int id);
    }
}
