namespace Exercises
{
    internal class HighestNumberPrinter
    {
        public static void Execute()
        {
            double number1, number2, number3, highestNumber;
            
            Console.WriteLine("Enter the first number: ");
            number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            number3 = double.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                if (number1 > number3)
                {
                    highestNumber = number1;
                }
                else
                {
                    highestNumber = number3;
                }
            }
            else
            {
                if (number2 > number3)
                {
                    highestNumber = number2;
                }
                else
                {
                    highestNumber = number3;
                }
            }
            Console.WriteLine("The highest number is: " + highestNumber);
            Console.ReadKey();
        }
    }
}