using System.Collections.Generic;
using System.Threading.Tasks;

namespace PokeApp.BusinessLogic
{
    public interface IRepository
    {
        // includes types
        Task<IEnumerable<Pokemon>> GetAllPokemonAsync();

        Task AddPokemonAsync(Pokemon p);
        void DeletePokemon(int id);
        object GetPokemon(int id);
    }
}
