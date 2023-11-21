namespace Exercises
{
    internal class StarsShapeExample01
    {
        public static void Execute()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i > 2 && j == 2 | j == 4 | j == 7 | j == 8) 
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}