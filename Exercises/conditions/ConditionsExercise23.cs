namespace Exercises.conditions
{
    internal class ConditionsExercise23
    {
        public static void Execute()
        {
            double n1, n2, result;
            Console.WriteLine("Enter a first digit: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a second digit: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            result = Math.Abs(n1 - n2);
            if (n1 > n2)
            {
                result *= 2;
                Console.WriteLine("Absolute value doubled: {0}.", result);
            }
            else
            {
                Console.WriteLine("Absolute value, but standard: {0}.", result);
            }
        }
    }
}