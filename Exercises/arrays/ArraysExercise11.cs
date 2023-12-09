namespace Exercises.arrays
{
    internal class ArraysExercise11
    {
        public static void Execute()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[5];
            Array.Copy(arr1, 0, arr2, 0, 5);
            foreach (int x in arr2)
            {
                Console.WriteLine(x);
            }
        }
    }
}