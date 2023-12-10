namespace Exercises.arrays
{
    internal class ArraysExercise16
    {
        public static void Execute()
        {
            string text;
            Console.WriteLine("Enter a string of your choice: ");
            text = Console.ReadLine();
            
            int spaces = 1; 
            foreach (char space in text)
                if (space == ' ') spaces++;
            Console.WriteLine("Number of words in the sentence: {0}.", spaces);
        }
    }
}