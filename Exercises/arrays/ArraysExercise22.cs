namespace Exercises.arrays
{
    internal class ArraysExercise22
    {
        public static void Execute()
        {
            int i;
            int j;
            int n = 0;
            int[,] arr1 = {{2,4,6},{8,10,12}};
            int[,] arr2 = {{14,16,18},{20,22,24}};
            int[,] arr3 = new int [2,3];
            for (i = 0; i < arr1.GetLength(0); i++)
            {
                for (j = 0; j < arr2.GetLength(1); j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            foreach (int num in arr3)
            { 
                Console.Write(num + " ");
                n++;
                if (n == 3)
                {
                    Console.Write("\n");
                }
            }
        }
    }
}