using System;
using System.Linq;

namespace CSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            bool a = true;
            string b = "Marielle Nolasco";
            int c = 1;
            a = false;
            b = "Marielle Carmina Nolasco";
            c++;
            Console.WriteLine(a + b + c);
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine(i);
            }
            while (!a)
            {
                Console.WriteLine(a);
                a = !a;
            }
            Random rnd = new Random();
            int n = rnd.Next(1, 4);
            switch (n)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("Goodbye");
                    break;
            }

            if (n == 1)
            {
                Console.WriteLine(" I'm");
            }
            else if (n == 2)
            {
                Console.WriteLine(" See");
            }
            else
            {
                Console.WriteLine(" Sir");
            }
            /*
            This 
            I hope 
            is 
            a 
            multi line 
            comment
             */

            greet("Marielle");
            string[] weekdays = { "monday", "tuesday", "wednesday", "thursday", "friday" };
            var wordQuery = from word in weekdays
                            where word[0] == 't'
                            select word;
            foreach (string s in wordQuery)
            {
                Console.WriteLine(s);
            }
        }
        static void greet(string s)
        {
            Console.WriteLine("Happy to meet you " + s);
        }
    }
}
