namespace Exercises
{
    internal class AdditionalExercise2
    {
        public static void Execute()
        {
            double a, b, c, delta, x1, x2;
            Console.WriteLine("Specify the A factor: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Specify the B factor: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Specify the C factor: ");
            c = double.Parse(Console.ReadLine());
            delta = b * b -4 * a * c;
            x1 = -b - Math.Sqrt(delta) / 2 * a;
            x2 = b + Math.Sqrt(delta) / 2 * a;
            Console.WriteLine("Delta: " + delta);
            Console.WriteLine("x1: " + x1);
            Console.WriteLine("x2: " + x2);
            Console.ReadKey();
        }
    }
}