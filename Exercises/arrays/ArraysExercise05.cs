namespace Exercises.arrays
{
    internal class ArraysExercise05
    {
        public static void Execute()
        {
            int[,] board2d = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            for (int a = 0; a < board2d.GetLength(0); a++)
            {
                for (int b = 0; b < board2d.GetLength(1); b++)
                {
                    Console.Write("{0,3}", board2d[a, b]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}