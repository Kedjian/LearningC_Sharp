namespace Exercises
{
    internal class NumberPiApproximator
    {
        public static void Execute()
        {
            int iterations = 1000;
            double sum = 0;

            for (int n = 0; n <= iterations; n++)
            {
                double term = Math.Pow(-1, n) / (2 * n + 1);
                sum += term;
            }
            double result = sum * 4;
            Console.WriteLine("In approximation number Pi would be: " + result);
        }
    }
}