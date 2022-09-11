using CarrosAPI.Data.VO;
using CarrosAPI.Models;

namespace CarrosAPI.Servicos
{
    public interface ICarroServico
    {
        Task<IEnumerable<CarroVO>> BuscarCarros();
        Task<CarroVO> BuscarCarros(int? id);
        Task<CarroVO> CriarCarro(CarroVO carroVO);
        Task AtualizarCarro(CarroVO carroVO);
        Task DeletarCarro(int id);
    }
}
