using System;
using System.Collections.Generic;
using System.Text;

namespace DogApplication
{
    internal class Dog
    {
        //access modifiers
        // public - everyone can see
        // internal - everyone in same assembly (aka project) can see
        // protected - everyone who is a subclass can see
        // private - only this class can see
        // protected internal, protected private

        //fields
        private string name;
        private int age;
       //auto-property
        //public int Age { get; set; }
        public int Age 
        {
            get 
            {
                return Age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                age = value;
            }
        }
        // constructor
        //  there is always at least one constructor

        public Dog(string name, int age) 
        {
            this.name = name ?? throw new ArgumentNullException("name");
            if (age < 0)
            {
                throw new ArgumentOutOfRangeException("age");
            }
            this.Age = age;
            //
        }

        public string GetName() 
        {
            return this.name;
        }
        public void SetName(string name) 
        {
            //validation goes here - this is public, field is private
            this.name = name;
        }
    }
}
