namespace Exercises
{
    internal class LimitChecker
    {
        public static void Execute()
        {
            int numSum = 0;
            int currentNum = 0;
            do
            {
                currentNum++;
                Console.WriteLine("{0} + {1} = {2}", numSum, currentNum, numSum+currentNum);
                numSum += currentNum;
            } while (numSum <= 100);
            Console.Write("{0} \t {1}", currentNum, numSum);
        }
    }
}