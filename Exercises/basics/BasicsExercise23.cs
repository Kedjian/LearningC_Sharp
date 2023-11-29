namespace Exercises.basics
{
    internal class BasicsExercise23
    {
        public static void Execute()
        {
            Console.WriteLine(remove_char("w3resource", 1)); // removes character at index 1
            Console.WriteLine(remove_char("w3resource", 9)); // removes character at index 9 (if exists)
            Console.WriteLine(remove_char("w3resource", 0)); // removes character at index 0
        }

        // function to remove a character at the specified index
        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1); // using remove method to eliminate the character at index n
        }
    }
}