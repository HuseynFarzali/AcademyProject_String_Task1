using System;

namespace AcademyProject_String_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the sentence: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);


            Console.WriteLine("Detected words are:");
            foreach (string word in words)
            {
                Console.Write(" " + word);
            }
            Console.WriteLine('\n');

            Console.WriteLine("Total number of words in the sentence: " + words.Length);
        }
    }
}
