using CarrosAPI.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace CarrosAPI.Repositorio.Generico
{
    public class RepositorioGenerico<T> : IRepositorio<T> where T : BaseEntity
    {
        private CarroContext Context;
        private DbSet<T> DataSet;
        public RepositorioGenerico(CarroContext context)
        {
            Context = context;
            DataSet = Context.Set<T>();
        }

        public async Task Atualizar(T item)
        {
            var resultado = DataSet.SingleOrDefault(c => c.Id.Equals(item.Id));
            if (resultado != null)
            {
                try
                {
                    Context.Entry(resultado).State = EntityState.Modified;
                    await Context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Não foi possível criar carro - {ex}");
                }
            }
        }

        public async Task<T> Buscar(int? id)
        {
            return DataSet.SingleOrDefault(c => c.Id.Equals(id));
        }

        public async Task<IEnumerable<T>> BuscarTodos()
        {
            return DataSet.ToList();
        }

        public async Task<T> Criar(T item)
        {
            try
            {
                DataSet.Add(item);
                await Context.SaveChangesAsync();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possível criar carro - {ex}");
            }
        }

        public async Task Deletar(int id)
        {
            var resultado = DataSet.SingleOrDefault(c => c.Id.Equals(id));
            if(resultado != null)
            {
                try
                {
                    DataSet.Remove(resultado);
                    await Context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Não foi possível criar carro - {ex}");
                }
            }
        }

        public bool Existe(int id)
        {
            return DataSet.Any(c => c.Id.Equals(id));
        }
    }
}
