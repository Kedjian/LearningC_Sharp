namespace Exercises
{
    internal class AdditionalExercise04
    {
        public static void Execute()
        {
            int x = 2, y = 3;
            x *= y * 2;
            Console.WriteLine("x in x *= y * 2 is 12, because *= means that the program will start to calculate from the left side.");
            Console.WriteLine("Therefore, instead of prioritizing 3 * 2, it prioritizes 2 * 3, and then goes 6 * 2, which results in 12.");
            Console.WriteLine("To further prove it, the result of the problem up here is: " + x + ".");
        }
    }
}