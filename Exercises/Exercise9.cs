namespace Exercises
{
    internal class Exercise9
    {
        public static void Execute()
        {
            double a, b, c;
            
            Console.WriteLine("Enter the first number: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            c = double.Parse(Console.ReadLine());

            if (a == b | a == c | b == c)
            {
                Console.WriteLine("The numbers are no different from each other.");
            }
            else
            {
                if (a > c && a < b)
                {
                    Console.WriteLine("The middle number is: " + a);
                }

                if (a < c && a > b)
                {
                    Console.WriteLine("The middle number is: " + a);
                }
                if (b > a && b < c)
                {
                    Console.WriteLine("The middle number is: " + b);
                }
                if (b < a && b > c)
                {
                    Console.WriteLine("The middle number is: " + b);
                }
                if (c > a && c < b)
                {
                    Console.WriteLine("The middle number is: " + c);
                }
                if (c < a && c > b)
                {
                    Console.WriteLine("The middle number is: " + c);
                }
            }
            
            Console.ReadKey();
        }
    }
}