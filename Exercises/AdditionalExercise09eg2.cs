namespace Exercises
{
    internal class AdditionalExercise09eg2
    {
        public static void Execute()
        {
            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 & y++ == 4 && z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            //wynik = false, x = 2, y = 5, z = 2
        }
    }
}