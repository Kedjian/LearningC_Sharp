namespace Exercises
{
    internal class ArithmeticAverage
    {
        public static void Execute()
        {
            double number1, number2, arithmeticAverage;
            
            Console.WriteLine("Enter the first number: ");
            number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            number2 = double.Parse(Console.ReadLine());
            arithmeticAverage = (number1 + number2) / 2;
            
            Console.WriteLine("Arithmetic average from the numbers you've provided equals: " + arithmeticAverage);
            Console.ReadKey();
        }
    }
}