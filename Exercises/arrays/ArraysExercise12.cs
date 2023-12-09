namespace Exercises.arrays
{
    internal class ArraysExercise12
    {
        public static void Execute()
        {
            int[] arr = { 4, 2, 6, 23, 1, 3, 7, 0 };
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
            Console.ReadKey();
        }
    }
}