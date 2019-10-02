using System;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i<1001; i++){
                if(i%15 == 0){
                    Console.WriteLine("Fizzbuzz");
                    
                } else if(i%3 == 0){
                    Console.WriteLine("Fizz");
                    
                } else if (i%5 == 0){
                    Console.WriteLine("Buzz");
                    
                } else {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Total number of Fizz: " + (1000/3 - 1000/15));
            Console.WriteLine("Total number of Buzz: " + (1000/5 - 1000/15));
            Console.WriteLine("Total number of FizzBuzz: " + 1000/15);
        }
    }
}
