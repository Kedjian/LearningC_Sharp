namespace Exercises.arrays
{
    internal class ArraysExercise13
    {
        public static void Execute()
        {
            string[] names = { "Rob", "Bob", "Sara", "Alex", "Tom" };
            Console.WriteLine(Array.IndexOf(names, "Bob"));
            Console.WriteLine(Array.IndexOf(names, "Tom"));
            Console.ReadKey();
        }
    }
}