using System;
using System.Collections.Generic;
using System.Text;
using Project2Prototype.Data.Entities;
using Project2Prototype.Library;

namespace Project2Prototype.Data
{
    public class Mapper : IMapper
    {
        public Entities.Customer ParseCreator(Library.Customer creator)
        {
            return new Entities.Customer()
            {
                FirstName = creator.FirstName,
                LastName = creator.LastName,
                PhoneNumber = creator.PhoneNumber
            };
        }

        
        public Library.Customer ParseCreator(Entities.Customer item)
        {
            return new Library.Customer()
            {
                FirstName = item.FirstName,
                LastName = item.LastName,
                PhoneNumber = item.PhoneNumber
            };
        }
    }
}
