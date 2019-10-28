using Project2Prototype.Data.Entities;
using Project2Prototype.Library;
using System.Collections.Generic;
using System.Linq;

namespace Project2Prototype.Data
{
    internal class Repository : IRepository
    {
        private readonly Project2PrototypeContext _context;
        private IMapper _map;

        public Repository(Project2PrototypeContext context, Mapper map)
        {
            _context = context;
            _map = map;
        }

        public void AddCreator(Library.Creator c)
        {
            _context.Creator.Add(_map.ParseCreator(c));
            _context.SaveChanges();
        }

        public List<Library.Creator> GetCreators()
        {
            List<Entities.Creator> allCreators = _context.Creator.Select(c => c).ToList();
            List<Library.Creator> allCreatorsfromDB = new List<Library.Creator>();
            foreach (Entities.Creator item in allCreators)
            {
                allCreatorsfromDB.Add(_map.ParseCreator(item));
            }
            return allCreatorsfromDB;
        }
    }
}