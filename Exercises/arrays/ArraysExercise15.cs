namespace Exercises.arrays
{
    internal class ArraysExercise15
    {
        public static void Execute()
        {
            string text = "w3resource.com";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i] + " ");
            }
        }
    }
}