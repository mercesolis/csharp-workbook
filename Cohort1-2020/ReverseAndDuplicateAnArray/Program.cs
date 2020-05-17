using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndDuplicateAnArray
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };

            // take in an array and return it in reverse order.
            // print in order.
            Console.WriteLine("Original array: ");
            foreach (int element in intArray)
            {
                Console.WriteLine(element + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Array reversed: ");

            // print in reverse order.
            for (int i = intArray.Length; i > 0; i--)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();


            // duplicate([1,2,3,4,5]); // ([1,2,3,4,5,1,2,3,4,5])

            // the hard way
            int[] newArray = new int[intArray.Length * 2];

            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < intArray.Length)
                {
                    newArray[i] = intArray[i];
                }
                else
                {
                    newArray[i] = intArray[i - 5];
                }
            }

            Console.WriteLine();
            Console.WriteLine("FOR loop:");
            foreach (var element in newArray)
            {
                Console.WriteLine(element + " ");
            }

            // an easier way
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ToList method:");
            List<int> list = new List<int>();
            list = intArray.ToList();
            list.AddRange(intArray.ToList());

            // convert to an array
            int[] secondArray = list.ToArray();

            foreach (var element in secondArray)
            {
                Console.WriteLine(element + " ");
            }
        }
    }
}
