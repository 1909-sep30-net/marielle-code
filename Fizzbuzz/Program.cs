using System;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int ctr1 = 0;
            int ctr2 = 0;
            int ctr3 = 0;
            for(int i = 1; i<1001; i++){
                if(i%15 == 0){
                    Console.WriteLine("Fizzbuzz");
                    ctr1++;
                } else if(i%3 == 0){
                    Console.WriteLine("Fizz");
                    ctr2++;
                } else if (i%5 == 0){
                    Console.WriteLine("Buzz");
                    ctr3++;
                } else {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Total number of Fizz: " + ctr2);
            Console.WriteLine("Total number of Buzz: " + ctr3);
            Console.WriteLine("Total number of FizzBuzz: " + ctr1);
        }
    }
}
