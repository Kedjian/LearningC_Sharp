namespace Exercises.basics
{
    internal class BasicsExercise03
    {
        public static void Execute()
        {
            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1);
            Console.WriteLine(x);
            Console.WriteLine(z);
            // x = true, x = 1, z = 2
        }
    }
}