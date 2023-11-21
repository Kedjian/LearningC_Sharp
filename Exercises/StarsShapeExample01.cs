namespace Exercises
{
    internal class StarsShapeExample01
    {
        public static void Execute()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i >= 2 & i <= 9 & j >= 2 & j <= 9)
                        Console.Write(" * ");
                    else
                        Console.Write("   ");
                }
                Console.WriteLine();
            }
        }
    }
}