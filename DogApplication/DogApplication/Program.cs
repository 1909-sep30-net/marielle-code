using System;

namespace DogApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog;
            Console.WriteLine("Hello World!");
            try
            {
                dog = new Dog(null, -4);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("error, recovering");
                dog = new Dog("spot", 3);
              
            }
            
            
        }
    }
}
