namespace Exercises
{
    internal class BoardExample01
    {
        public static void Execute()
        {
            int[] participants = new int[] {19, 34, 23, 54, 31};
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(participants[i]);
            }
            Console.ReadKey();
        }
    }
}