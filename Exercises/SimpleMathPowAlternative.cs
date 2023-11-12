namespace Exercises
{
    internal class SimpleMathPowAlternative
    {
        public static void Execute()
        {
            Console.WriteLine("Enter a positive exponent: ");
            int exponent = Convert.ToInt16(Console.ReadLine());
            if (exponent > 0)
            {
                int power = 1;
                for (int i = 1; i <= exponent; i++)
                {
                    power *= 2;
                    Console.WriteLine("2 to {0,2} equals {1,2}.", i, power);
                }
            }
            Console.ReadKey();
        }
    }
}