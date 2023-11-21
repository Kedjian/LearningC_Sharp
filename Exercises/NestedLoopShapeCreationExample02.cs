namespace Exercises
{
    internal class NestedLoopShapeCreationExample02
    {
        public static void Execute()
        {
            for (int i = 0; i <= 16; i++)
            {
                for (int j = 0; j <= 16; j++)
                {
                    if (i % 2 == 0 | j % 2 == 0)
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