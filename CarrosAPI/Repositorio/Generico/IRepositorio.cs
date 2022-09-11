using CarrosAPI.Models;
using CarrosAPI.Models.Base;

namespace CarrosAPI.Repositorio
{
    public interface IRepositorio<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> BuscarTodos();
        Task<T> Buscar(int? id);
        Task<T> Criar(T item);
        Task Atualizar(T item);
        Task Deletar(int id);
        bool Existe(int id);
    }
}
