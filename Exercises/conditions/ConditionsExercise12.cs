namespace Exercises.conditions
{
    internal class ConditionsExercise12
    {
        public static void Execute()
        {
            int a, b, c;
            int temporary;
            Console.WriteLine("Enter the A factor: ");
            a = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the B factor: ");
            b = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the C factor: ");
            c = System.Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                temporary = a;
                a = b;
                b = temporary;
            }

            if (b > c)
            {
                temporary = b;
                b = c;
                c = temporary;
            }

            if (a > b)
            {
                temporary = a;
                a = b;
                b = temporary;
            }
            Console.WriteLine("The number order from the smallest to the biggest is: " + a + "\t" + b + "\t" + c);
        }
    }
}