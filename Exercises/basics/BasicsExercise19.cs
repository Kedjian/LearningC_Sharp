namespace Exercises.basics
{
    internal class BasicsExercise19
    {
        public static void Execute()
        {
            double F, C;
            Console.WriteLine("Please enter temperature in Celsius: ");
            C = double.Parse(Console.ReadLine());
            F = 32 + 9 / 5 / C;
            Console.WriteLine(F);
            Console.ReadKey();
        }
    }
}