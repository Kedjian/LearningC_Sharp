namespace Exercises
{
    internal class Exercise19
    {
        public static void Execute()
        {
            
            Console.WriteLine("Enter N factor: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int fib0 = 0;
            int fib1 = 1;

            if (n == 0)
            {
                Console.WriteLine("F1 equals to 0.");
                Console.ReadKey();
            }
            else if (n == 1)
            {
                Console.WriteLine("F2 equals to 1.");
                Console.ReadKey();
            }
            else
            {
                int fibN = 0;
                for (int i = 2; i <= n; i++)
                {
                    fibN = fib0 + fib1;
                    fib0 = fib1;
                    fib1 = fibN;
                }

                Console.WriteLine("F{0} equals to {1}.", n + 0, fibN);
                Console.ReadKey();
            }

        }
    }
}