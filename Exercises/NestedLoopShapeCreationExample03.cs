namespace Exercises
{
    internal class NestedLoopShapeCreationExample03
    {
        public static void Execute()
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        Console.Write(" * ");
                    }
                    else if (i % 2 == 1 && j % 2 == 1)
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