namespace Exercises.arrays
{
    internal class ArraysExercise21
    {
        public static void Execute()
        {
            int i;
            int j;
            int diagSum = 0;
            Random rand = new Random();
            int[,] arr = new int[5,5];
            Console.Write("\nRandomized two dimensional array: \n--------------");
            for (i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("\n");
                for (j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(1, 9);
                    if (i == j)
                    {
                        diagSum += arr[i,j];
                    }
                    Console.Write("{0}  ", arr[i,j]);
                }
            }
            Console.Write("\n--------------\nMain diagonal sum: {0}.\n", diagSum);
        }
    }
}