using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokeApp.BusinessLogic;

namespace PokeApp.Data
{
    public class Repository : IRepository
    {
        private readonly PokemonDbContext _context;

        public Repository(PokemonDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BusinessLogic.Pokemon>> GetAllPokemonAsync()
        {
            List<Pokemon> entities = await _context.Pokemon
                .Include(p => p.PokemonTypeJoins)
                    .ThenInclude(pt => pt.Type)
                .ToListAsync();

            return entities.Select(e => new BusinessLogic.Pokemon
            {
                Id = e.Id,
                Name = e.Name,
                Height = e.Height,
                Weight = e.Weight,
                Types = e.PokemonTypeJoins.Select(j => new BusinessLogic.PokemonType
                {
                    Id = j.Type.Id,
                    Name = j.Type.Name,
                }).ToHashSet()
            });
        }

        
        public Task AddPokemonAsync(BusinessLogic.Pokemon pokemon)
        {
            _context.Pokemon.Add(new Pokemon()
            {
                Name = pokemon.Name,
                Height = pokemon.Height,
                Weight = pokemon.Weight
            });
            _context.SaveChangesAsync();
            return Task.FromResult<object>(null);
        }

        public void DeletePokemon(int id)
        {
            _context.Pokemon.Remove(_context.Pokemon.Single(p => p.Id == id));
            _context.SaveChanges();
        }

        public object GetPokemon(int id)
        {
            return new BusinessLogic.Pokemon()
            {
                Name = _context.Pokemon.Single(p => p.Id == id).Name,
                Height = _context.Pokemon.Single(p => p.Id == id).Height,
                Weight = _context.Pokemon.Single(p => p.Id == id).Weight,
            };
        }
    }
}
