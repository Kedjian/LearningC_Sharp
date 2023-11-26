namespace Exercises.basics
{
    internal class BasicsExercise07
    {
        public static void Execute()
        {
            int x = 1, y = 3, z = 4;
            bool result = (x == 1 || y++ > 2 || ++z > 0);
            Console.WriteLine("Result={0} x={1} y={2} z={3}", result, x, y, z);
            // result = true, x = 1, y = 3, z = 4
        }
    }
}