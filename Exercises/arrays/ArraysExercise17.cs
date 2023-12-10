namespace Exercises.arrays
{
    internal class ArraysExercise17
    {
        public static void Execute()
        {
            int num;
            int[] arr1 = new int[] {-5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5};
            int[] arr2 = new int[11];

            for (num = 0; num < arr1.Length; num++)
            {
                if (arr1[num] >= 0)
                {
                      Array.Copy(arr1, num, arr2, num, 1);
                }
            }
            foreach (int element in arr2)
            {
                Console.WriteLine(element);
            }

        }
    }
}