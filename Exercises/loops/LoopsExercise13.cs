namespace Exercises.loops
{
    internal class LoopsExercise13
    {
        public static void Execute()
        {
            Console.WriteLine("Enter a digit that's lower than 10.");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 10 & num > 0)
            {
                for (int i = 1; i < 10; i++)
                {
                    int temp = num;
                    temp *= i;
                    Console.WriteLine(num + "*" + i + "=" + temp);
                }
            }
            else
            {
                Console.WriteLine("You entered a wrong digit.");
            }
        }
    }
}