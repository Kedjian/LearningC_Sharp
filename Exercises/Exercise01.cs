namespace Exercises
{
    internal class Exercise01
    {
        public static void Execute()
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