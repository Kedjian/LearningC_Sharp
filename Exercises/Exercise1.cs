using System;

namespace LearningBox
{
    internal class Exercise1
    {
        static void Main(string[] args)
        {
            string text;

            Console.WriteLine("Enter your name: ");
            text = Console.ReadLine();
            text = "Hello " + text + "!";
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}