namespace Exercises.conditions
{
    internal class ConditionsExercise15
    {
        public static void Execute()
        {
            double delta;
            double x0;
            double x1;
            double x2;

            double a;
            Console.WriteLine("Enter the A integer: ");
            a = Convert.ToDouble(Console.ReadLine());

            double b;
            Console.WriteLine("Enter the B integer: ");
            b = Convert.ToDouble(Console.ReadLine());

            double c;
            Console.WriteLine("Enter the C integer: ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a != 0)
            {
                delta = Math.Pow(b, 2) - 4 * a * c;

                if (delta > 0)
                {
                    x1 = -b - Math.Sqrt(delta) / 2 * a;
                    x2 = -b + Math.Sqrt(delta) / 2 * a;
                    Console.WriteLine("Delta has two square roots. x1 equals {0}, and x2 equals {1}.", x1, x2);
                    Console.ReadKey();
                } else if (delta == 0)
                {
                    x0 = -b / 2 * a;
                    Console.WriteLine("Delta has one square root, and it equals {0}.", x0);
                    Console.ReadKey();
                } else
                {
                    Console.WriteLine("Delta has no square roots.");
                    Console.ReadKey();
                }
            } else
            {
                Console.WriteLine("A cannot be a negative integer. Try again.");
                Console.ReadKey();
            }
        }
    }
}