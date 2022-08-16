using CarrosAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CarrosAPI.Repositorio
{
    public class CarroRepositorio : ICarroRepositorio
    {
        private CarroContext Context;
        public CarroRepositorio(CarroContext context)
        {
            Context = context;
        }

        public async  Task AtualizarCarro(Carro carro)
        {
            try
            {
                Context.Entry(carro).State = EntityState.Modified;
                await Context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception($"Não foi possível atualizar carro - {ex}");
            }
            
        }

        public async Task<IEnumerable<Carro>> BuscarCarros()
        {
            try
            {
                return await Context.Carros.ToListAsync();
            }
            catch(Exception ex)
            {
                throw new Exception($"Não foi possível listar carros - {ex}");
            }
            
        }

        public async Task<Carro> BuscarCarros(int? id)
        {
            try
            {
                var carro = await Context.Carros.FindAsync(id);
                return carro;
            }
            catch(Exception ex)
            {
                throw new Exception($"Não foi possível encontrar carro - {ex}");
            }
           
        }

        public async Task<Carro> CriarCarro(Carro carro)
        {
            try
            {
                Context.Carros.Add(carro);
                await Context.SaveChangesAsync();
                return carro;
            }
            catch(Exception ex)
            {
                throw new Exception($"Não foi possível criar carro - {ex}");
            }
            
        }

        public async Task DeletarCarro(int id)
        {
            try
            {
                var deletar = await Context.Carros.FindAsync(id);
                Context.Carros.Remove(deletar);
                Context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception($"Não foi possível deletar carro - {ex}");
            }
        }
    }
}
