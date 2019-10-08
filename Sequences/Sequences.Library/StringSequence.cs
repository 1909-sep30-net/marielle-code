using System;
using System.Collections.Generic;
using System.Text;

namespace Sequences.Library
{
    public class StringSequence
    {
        private readonly List<string> _list = new List<string>();
        public void Add(string item)
        {
            _list.Add(item);
        }
        public void Remove(string item)
        {
            _list.Remove(item);
        }
        public string Get(int index)
        {
            return _list[index];
        }
        public string Shortest(StringSequence seq)
        {
            string shortest = seq[0];
            foreach(string s in seq)
            {
                if(shortest.Length > s.Length)
                {
                    shortest = s;
                }
            }
            return shortest;
        }

        public string this[int index] 
        {
            get => _list[index];
            set => _list[index] = value;
        }
    }
}
