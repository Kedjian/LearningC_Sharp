namespace Exercises
{
    internal class InputCounter
    {
        public static void Execute()
        {
            int digit;
            int sum = 0;
            int numSum = 1;

            do
            {
                Console.WriteLine("Enter a digit: ");
                digit = Convert.ToInt32(Console.ReadLine());
                
                digit += sum;
                
                // Doesn't work, it needs a fix.
                
                Console.WriteLine("{0} {1}", digit, numSum);
            } while (digit == 0);
            Console.WriteLine("{0} was the amount of digits entered.", numSum);
        }
    }
}