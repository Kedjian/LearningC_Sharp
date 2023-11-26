namespace Exercises.conditions
{
    internal class ConditionsExercise19
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
                    Console.WriteLine(a + " + " + b + " equals to: " + result);
                    break;
                
                case '-':
                    result = a - b;
                    Console.WriteLine(a + " - " + b + " equals to: " + result);
                    break;
                
                case '*':
                    result = a * b;
                    Console.WriteLine(a + " * " + b + " equals to: " + result);
                    break;
                
                case '/':
                    if (b != 0)
                    {
                        result = a / b;
                        Console.WriteLine(a + " / " + b + " equals to: " + result);
                    }
                    else
                    {
                        Console.WriteLine("It's not possible to divide by zero.");
                    }
                    break;
                    
                case '^':
                    result = Math.Pow(a, b);
                    Console.WriteLine(a + "^" + b + " equals to: " + result);
                    break;
                
                default:
                    Console.WriteLine("There is no operator like the one you entered.");
                    break;
            }

            Console.ReadKey();
        }
    }
}