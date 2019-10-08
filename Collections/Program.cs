using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays();
        }
        static void Arrays()
        {
            int[] intArray = new int[4];
            intArray[0] = 3;
            intArray[1] = 5;
            //collection initializer
            int[] intArray = new int[] { 1, 2, 3, 4, 12 } //inferred to be size 5

            Console.WriteLine("Enter Length: ");
            string input = Console.ReadLine();
            int length = int.Parse(input);
            int[] array3 = new int[length];

            //jagged array
            int[][] twoD = new int[3][];
            twoD[0] = new int[] { 1, 2 };
            twoD[1] = new int[] { 1, 2, 3 };

            //multi dimensiona array
            int[,] twoDmulti = new int[3, 5];
            twoDmulti[0] = 3;

        }
        static void Lists()
        {
            //Arraylist
            ArrayList list = new ArrayList();
            list.Add(3);
            list.Add(3.1);

            Console.WriteLine(list[0]);
            int number = (int) list[0];

            List<int> intList = new List<int>();
            intList.Add(1);
            int num = intList[0];

            list2 = new List<int>{1};
            
        }
        static void OtherCollections()
        {
            var set = new HashSet<string> {"a", "b", "a"};
            Console.WriteLine(set.Count);
            //checking for membership in a list is slow, faster in a set
            //also insert and remove in a set is faster

            var dict = new Dictionary<int, int>
            {
                [1] = 1,
                [3] = 9,
                [2] = 4,
                [10] = 100
            };
            var hundred = dict[10];
            var dict2 = new Dictionary<string, string>
            {
                [abc] = "def";
                [def] = "qwe";
            };
            var que = dict2["def"];
            

        }
    }
}
