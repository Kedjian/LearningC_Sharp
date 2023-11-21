namespace Exercises
{
    internal class NestedLoopShapeCreationExample01
    {
        public static void Execute()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if ((i == 2 | i == 4 | i == 7 | i == 9) & (j == 2 | j == 4 | j == 7 | j == 9))
                    {
                        Console.Write(" * ");
                    }
                    else if ((i == 3 | i == 5 | i == 6 | i == 8) & (j == 3 | j == 5 | j == 6 | j == 8))
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}