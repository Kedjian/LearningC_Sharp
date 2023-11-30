namespace Exercises.loops
{
    internal class LoopsExercise23
    {
        public static void Execute()
        {
            int n1 = 0;
            int n2 = 0;
            for (int i = 0; i < 100; i++)
            {
                n1++;
                if (n1 % 2 != 0)
                {
                    ++n2;
                    Console.WriteLine("{0} - the {1} odd number.", n1, n2);
                }
            }
        }
    }
}