namespace Exercises
{
    internal class DigitSummarizerBetweenNumbers
    {
        public static void Execute()
        {
            int n; 
            Console.WriteLine("Enter the N factor: ");
            n = Convert.ToInt16(Console.ReadLine());

            int sum = 0;
            int i = 1;

            while (i <= n)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("The summary of numbers from between 1 to {0} is: {1}.", n, sum);
        }
    }
}