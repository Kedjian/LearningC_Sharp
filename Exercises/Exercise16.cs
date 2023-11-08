namespace Exercises
{
    internal class Exercise16
    {
        public static void Execute()
        {
            int wantedNum;
            int sum = 0;
            int countNum = 0;

            Console.WriteLine("Type any positive number you choose: ");
            wantedNum = int.Parse(Console.ReadLine());

            do
            {
                countNum++;
                sum += countNum;
            } while (sum < wantedNum);
            
            Console.WriteLine("The summary of numbers needed to sum equals to: " + countNum);
            Console.ReadKey();
        }
    }
}