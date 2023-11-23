namespace Exercises
{
    internal class MultipleFactorNumberComparison
    {
        public static void Execute()
        {
            int num = 0;
            int numSum = 0;

            int digit1;
            int digit2;
            
            Console.WriteLine("Enter a first digit: ");
            digit1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second digit: ");
            digit2 = Convert.ToInt32(Console.ReadLine());

            do
            {
                num++;
                if (num / 2 >= digit1 & num <= digit2)
                {
                    numSum++;
                    Console.WriteLine("{0} and {1}.", numSum, num);
                }
                else
                {
                    Console.WriteLine("x");
                }
            } while (num < 100);
        }
    }
}