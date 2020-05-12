using System;

namespace SortingWith0
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            

int[] array = new int[5] { 15, 3, 0, 23, 19 };

            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                    if (array[j] == 0)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }


            foreach (var number in array)
            {
                Console.WriteLine(number.ToString());
            }
        }
    }
}
