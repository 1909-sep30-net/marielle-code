using System.Collections.Generic;

namespace Project2Prototype.Library
{
    public interface IRepository
    {
        public List<Customer> GetCreators();

        public void AddCreator(Customer c);
    }
}