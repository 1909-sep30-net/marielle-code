using Project2Prototype.Data.Entities;
using Project2Prototype.Library;
using System.Collections.Generic;
using System.Linq;

namespace Project2Prototype.Data
{
    public class Repository : IRepository
    {
        private readonly Project2PrototypeContext _context;
        private IMapper _map;

        public Repository(Project2PrototypeContext context, IMapper map)
        {
            _context = context;
            _map = map;
        }

        public void AddCreator(Library.Customer c)
        {
            _context.Creator.Add(_map.ParseCreator(c));
            _context.SaveChanges();
        }

        public List<Library.Customer> GetCreators()
        {
            List<Entities.Customer> allCreators = _context.Creator.Select(c => c).ToList();
            List<Library.Customer> allCreatorsfromDB = new List<Library.Customer>();
            foreach (Entities.Customer item in allCreators)
            {
                allCreatorsfromDB.Add(_map.ParseCreator(item));
            }
            return allCreatorsfromDB;
        }
    }
}