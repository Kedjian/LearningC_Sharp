namespace Exercises.methods
{
    internal class MethodsExercise03
    {
        public static void Execute()
        {
            int[] arr1 = { 1, 2, 2, 3, 4, 5, 1 };
            CheckIfEqual(arr1);

            static int CheckIfEqual(int[] arr1)
            {
                int last = arr1.Length - 1;
                if (arr1[0] == arr1[last])
                {
                    Console.Write("Equal.");
                    return 1;
                }
                Console.Write("Unequal.");
                return 0;
            }
        }
    }
}