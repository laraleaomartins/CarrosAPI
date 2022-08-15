using CarrosAPI.Models;
using CarrosAPI.Repositorio;

namespace CarrosAPI.Servicos
{
    public class CarroServico : ICarroServico
    {
        private ICarroRepositorio Repositorio;

        public CarroServico(ICarroRepositorio repositorio)
        {
            Repositorio = repositorio;
        }

        public Task AtualizarCarro(Carro carro, int id)
        {
            return Repositorio.AtualizarCarro(carro, id);
        }

        public Task<IEnumerable<Carro>> BuscarCarros()
        {
            return Repositorio.BuscarCarros();
        }

        public Task<Carro> BuscarCarros(int? id)
        {
            return Repositorio.BuscarCarros(id);
        }

        public Task<Carro> CriarCarro(Carro carro)
        {
            return Repositorio.CriarCarro(carro);
        }

        public Task DeletarCarro(int id)
        {
            return Repositorio.DeletarCarro(id);
        }
    }
}
