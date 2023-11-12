namespace Exercises
{
    internal class AdditionalExercise09eg6
    {
        public static void Execute()
        {
            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 | ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            // wynik = true, x = 1, y = 4, z = 5
        }
    }
}