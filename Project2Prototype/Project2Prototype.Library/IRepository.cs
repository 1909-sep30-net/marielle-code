using System.Collections.Generic;

namespace Project2Prototype.Library
{
    public interface IRepository
    {
        public List<Creator> GetCreators();

        public void AddCreator(Creator c);
    }
}