namespace Exercises.loops
{
    internal class LoopsExercise08
    {
        public static void Execute()
        {
            int input;
            int inpSum = 0;
            int inpCounter = -1;

            do
            {
                inpCounter++;
                Console.WriteLine("Enter an input: ");
                input = Convert.ToInt32(Console.ReadLine());
                inpSum += input;
            } while (input != 0);
            Console.WriteLine("Digits summarized: {0}. \nNumber of inputs: {1}.", inpSum, inpCounter);
        }
    }
}