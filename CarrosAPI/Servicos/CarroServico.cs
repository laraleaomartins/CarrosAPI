using AutoMapper;
using CarrosAPI.Data.VO;
using CarrosAPI.Models;
using CarrosAPI.Repositorio;

namespace CarrosAPI.Servicos
{
    public class CarroServico : ICarroServico
    {
        private readonly IRepositorio<Carro> Repositorio;
        private readonly IMapper Mapper;

        public CarroServico(IRepositorio<Carro> repositorio, IMapper mapper)
        {
            Repositorio = repositorio;
            Mapper = mapper;
        }

        public Task AtualizarCarro(CarroVO carroVO)
        {
            var carro = Mapper.Map<Carro>(carroVO);
            return Repositorio.Atualizar(carro);
        }

        public async Task<IEnumerable<CarroVO>> BuscarCarros()
        {
           var carro =  await Repositorio.BuscarTodos();
            var carroVO = Mapper.Map<IEnumerable<CarroVO>>(carro);
            return carroVO;
        }

        public async Task<CarroVO> BuscarCarros(int? id)
        {
            var carro = await Repositorio.Buscar(id);
            var carroVO = Mapper.Map<CarroVO>(carro);
            return carroVO;
        }

        public async Task<CarroVO> CriarCarro(CarroVO carroVO)
        {
            var carro = Mapper.Map<Carro>(carroVO);
            var carroDominio = await Repositorio.Criar(carro);
            return Mapper.Map<CarroVO>(carroDominio);
        }

        public Task DeletarCarro(int id)
        {
            return Repositorio.Deletar(id);
        }
    }
}
