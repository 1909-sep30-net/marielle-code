using System;
using System.Collections.Generic;
using System.Text;
using Project2Prototype.Data.Entities;
using Project2Prototype.Library;

namespace Project2Prototype.Data
{
    public class Mapper : IMapper
    {
        public Entities.Creator ParseCreator(Library.Creator creator)
        {
            return new Entities.Creator()
            {
                FirstName = creator.FirstName,
                LastName = creator.LastName,
                PhoneNumber = creator.PhoneNumber
            };
        }

        
        public Library.Creator ParseCreator(Entities.Creator item)
        {
            return new Library.Creator()
            {
                FirstName = item.FirstName,
                LastName = item.LastName,
                PhoneNumber = item.PhoneNumber
            };
        }
    }
}
