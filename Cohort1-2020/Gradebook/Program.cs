using System;
using System.Collections.Generic;
using System.Linq;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            string answer = string.Empty;
            Dictionary<string, string> gradeBook = new Dictionary<string, string>();


            do
            {
                Console.WriteLine("Enter a student name.");
                name = Console.ReadLine();
                Console.WriteLine("Enter the student's grades");
                string grades = Console.ReadLine();

                gradeBook.Add(name, grades);

                Console.WriteLine("Do you want to add another student? Enter quit to stop");
                answer = Console.ReadLine().ToLower();

            } while (!answer.Equals("quit"));

            int lowestGrade = 0;
            int highestGrade = 0;
            double average = 0.00;
            foreach (var item in gradeBook)
            {
                Console.WriteLine($"{item.Key}\n");

                try
                {
                    int[] singleGrades = Array.ConvertAll<string, int>(gradeBook[item.Key].Split(), Convert.ToInt32);
                    lowestGrade = singleGrades.Min();
                    highestGrade = singleGrades.Max();
                    average = singleGrades.Average();

                }
                catch
                {
                    throw;
                }

                Console.WriteLine($"Highest grade = {highestGrade} Lowest grade = {lowestGrade} Average = {average}");
            } 

        }
    }
}
