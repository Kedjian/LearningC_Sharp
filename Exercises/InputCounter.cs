namespace Exercises
{
    internal class InputCounter
    {
        public static void Execute()
        {
            int num = 0;
            int temp;
            int numSum = 0;

            do
            {
                Console.WriteLine("Enter a digit: ");
                temp = Convert.ToInt32(Console.ReadLine());
                
                temp = num;
                num += num;
                numSum++;
                
                // Doesn't work, it needs a fix.
                
                Console.Write("{0} {1} {2}", temp, num, numSum);
            } while (temp == 0);
            Console.WriteLine("{0} was the amount of digits entered.", numSum);
        }
    }
}