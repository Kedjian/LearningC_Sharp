namespace Exercises
{
    internal class Exercise4
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
            highestNumber = number1;

            if (number2 > highestNumber && number2 > number3)
            {
                highestNumber = number3;
            }

            if (number3 > highestNumber)
            {
                highestNumber = number3;
            }
            
            Console.WriteLine("The highest number is: " + highestNumber);
            Console.ReadKey();
        }
    }
}