namespace Exercises
{
    internal class Exercise6
    {
        public static void Execute()
        {
            int wiek;
            
            Console.WriteLine("Enter your age: ");
            wiek = int.Parse(Console.ReadLine());

            if (wiek >= 18)
            {
                Console.WriteLine("You're an adult.");
            }
            else
            {
                Console.WriteLine("You're not an adult.");
            }
            
            Console.ReadKey();
        }
    }
}