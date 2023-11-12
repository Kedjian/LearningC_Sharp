namespace Exercises
{
    internal class SimpleCalculator
    {
        public static void Execute()
        {
            double a, b;
            double result;
            char oper;
            
            Console.WriteLine("Enter the first number: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter an operator (+, -, *, /, ^)");
            oper = Convert.ToChar(Console.ReadLine());

            switch (oper)
            {
                case '+':
                    result = a + b;
                    Console.WriteLine("{0} + {1} equals to {2}.", a, b, result);
                    Console.ReadKey();
                    break;
                case '-':
                    result = a - b;
                    Console.WriteLine("{0} - {1} equals to {2}.", a, b, result);
                    Console.ReadKey();
                    break;
                case '*':
                    result = a * b;
                    Console.WriteLine("{0} * {1} equals to {2}.", a, b, result);
                    Console.ReadKey();
                    break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("You cannot divide by zero.");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        result = a / b;
                        Console.WriteLine("{0} / {1} equals to {2}.", a, b, result);
                        Console.ReadKey();
                        break; 
                    }
                case '^':
                    result = Math.Pow(a, b);
                    Console.WriteLine("{0} ^ {1} equals to {2}.", a, b, result);
                    Console.ReadKey();
                    break;
            }
        }
    }
}