namespace Exercises
{
    internal class RangeChecker
    {
        public static void Execute()
        {
            Console.WriteLine("Enter a digit that's not smaller than -10, and not bigger than 10.");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 10 & num >= -10)
            {
                Console.WriteLine("Congratulations! You've entered a correct number.");
            }
            else
            {
                Console.WriteLine("That's a wrong number.");
            }
        }
    }
}