using System;
using System.Collections.Generic;
using System.Text;
using Project2Prototype.Data.Entities;
using BL = Project2Prototype.Library;

namespace Project2Prototype.Data
{
    public interface IMapper
    {
        public Entities.Creator ParseCreator(BL.Creator creator);
        public BL.Creator ParseCreator(Creator item);
    }
}
