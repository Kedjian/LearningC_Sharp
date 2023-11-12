namespace Exercises
{
    internal class NumberComparison
    {
        public static void Execute()
        {
            double result1 = Math.Pow(Math.Sqrt(2), Math.Sqrt(3));
            double result2 = Math.Pow(Math.Sqrt(3), Math.Sqrt(2));

            if (result1 > result2)
            {
                Console.WriteLine(result1 + "is bigger than: " + result2);
            }
            else if (result2 > result1)
            {
                Console.WriteLine(result2 + "is bigger than: " + result1);
            }
            else
            {
                Console.WriteLine(result2 + "is the same as " + result1);
            }
            
            Console.ReadKey();
        }
    }
}