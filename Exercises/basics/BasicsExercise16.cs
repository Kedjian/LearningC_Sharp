namespace Exercises.basics
{
    internal class BasicsExercise16
    {
        public static void Execute()
        {
            int x, y = 4;
            x = (y -= 2);
            // x = 2 / y = 2
            x = y++;
            // x = 2 / y = 3
            x = y--; 
            // x = 3 / y = 2
            Console.WriteLine("Integer x has a value of: " + x);
            Console.WriteLine("Integer y has a value of: " + y);
        }
    }
}