namespace Exercises.loops
{
    internal class LoopsExercise04
    {
        public static void Execute()
        {
            int number = 100;

            do
            {
                do
                {
                    if (number % 2 == 0 || number % 3 != 0 || number % 7 != 0)
                    {
                        number++;
                        continue;
                    }
                    Console.WriteLine("Number {0} is an odd number and is divisable by 3 and 7.", number);
                    number++;
                } while (number <= 100);
            } while (number <= 200);
        }
    }
}