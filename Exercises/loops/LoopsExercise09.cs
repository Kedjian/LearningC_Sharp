namespace Exercises.loops
{
    internal class LoopsExercise09
    {
        public static void Execute()
        {
            decimal baseDeposit = 10000m;
            decimal loan = 0.05m;
            decimal interest = 0;
            int months = 12;

            for (int i = 0; i < months; i++)
            {
                decimal monthlyInterest = (baseDeposit * loan) / 12;
                interest += monthlyInterest;
                baseDeposit += monthlyInterest;
            }
            Console.WriteLine("A: " + baseDeposit);
            Console.WriteLine("B: " + interest);
        }
    }
}