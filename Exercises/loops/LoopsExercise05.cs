namespace Exercises.loops
{
    internal class LoopsExercise05
    {
        public static void Execute()
        {
            int i, number, fact;
            Console.WriteLine("Enter a digit: ");
            number = int.Parse(Console.ReadLine());
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact *= i;
            }
            Console.WriteLine("The factorial of given number equals to: " +fact+".");
        }
    }
}