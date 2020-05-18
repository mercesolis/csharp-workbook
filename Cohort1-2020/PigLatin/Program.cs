using System;

namespace PigLatin
{
    class Program
    {
        public static void Main(string[] args)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', };

            Console.WriteLine("Enter your word: ");
            string answer = Console.ReadLine();

            string firstLetter = answer.Substring(0, 1); // the first letter 
            string lastLetter = answer.Substring(answer.Length - 1, 1); // the last letter 
            int index = answer.IndexOfAny(vowels); // first occurence of a vowel
            string findFirstVowel = answer.Substring(0, index); //

            string pigLatin = answer.Substring(index) + findFirstVowel; // 

            // The "rules":
            if (answer.IndexOfAny(vowels) == -1) // no vowels
            {
                Console.WriteLine(pigLatin + "ay");
            }
            else if (firstLetter.IndexOfAny(vowels) == 0) // first letter is a vowel
            {
                if (lastLetter.IndexOfAny(vowels) == 0) // last letter is a vowel
                {
                    Console.WriteLine(answer + "yay");
                }
                else
                {
                    Console.WriteLine(answer + "ay"); 
                }
                
            }
            else // first letter is a consonant
            {
                Console.WriteLine(pigLatin + "ay");
            }
            Console.ReadKey();
            
            
        }
    }
}
