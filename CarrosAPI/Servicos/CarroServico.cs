using CarrosAPI.Models;
using CarrosAPI.Repositorio;

namespace CarrosAPI.Servicos
{
    public class CarroServico : ICarroServico
    {
        private readonly IRepositorio<Carro> Repositorio;

        public CarroServico(IRepositorio<Carro> repositorio)
        {
            Repositorio = repositorio;
        }

        public Task AtualizarCarro(Carro carro)
        {
            return Repositorio.Atualizar(carro);
        }

        public Task<IEnumerable<Carro>> BuscarCarros()
        {
            return Repositorio.BuscarTodos();
        }

        public Task<Carro> BuscarCarros(int? id)
        {
            return Repositorio.Buscar(id);
        }

        public Task<Carro> CriarCarro(Carro carro)
        {
            return Repositorio.Criar(carro);
        }

        public Task DeletarCarro(int id)
        {
            return Repositorio.Deletar(id);
        }
    }
}
