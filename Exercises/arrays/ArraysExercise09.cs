namespace Exercises.arrays
{
    internal class ArraysExercise09
    {
        public static void Execute()
        {
            byte[] board = { 10, 5, 2, 7, 1, 8, 4, 3, 6, 9 };
            byte smallestElement = board[0];
            int position = 0;
            for (int i = 1; i < board.Length; i++)
            {
                if (board[i] < smallestElement)
                {
                    smallestElement = board[i];
                    position = i;
                }
            }
            Console.WriteLine("The smallest data in an array is: " + smallestElement + ".");
            Console.WriteLine("The position of the smallest element in an array is: " + position + ".");
        }
    }
}