namespace Exercises
{
    internal class BoardExample04
    {
        public static void Execute()
        {
            int[] participants = { 19, 34, 23, 54, 31 };
            int max = participants[0]; 
            for (int i = 1; i < participants.Length; i++)
            {
                if (participants[i] > max)
                {
                    max = participants[i];
                }
            }
            Console.WriteLine("The oldest participant is {0} years old.", max);
            Console.ReadKey();
        }
    }
}