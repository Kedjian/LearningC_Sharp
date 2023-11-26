namespace Exercises.conditions
{
    internal class ConditionsExercise06
    {
        public static void Execute()
        {
            double number1, number2, number3, highestNumber;
            
            Console.WriteLine("Enter the first number: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            number3 = Convert.ToDouble(Console.ReadLine());
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