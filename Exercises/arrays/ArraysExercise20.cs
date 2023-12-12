namespace Exercises.arrays
{
    internal class ArraysExercise20
    {
        public static void Execute()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = new int[10];
            Array.Copy(arr1,0,arr2,1,9);
            Array.Copy(arr1,9,arr2,0,1);
            foreach (int num in arr2)
            {
                Console.WriteLine(num);
            }
        }
    }
}