namespace Exercises.basics
{
    internal class BasicsExercise01
    {
        public static void Execute()
        {
            double number1, number2, arithmeticAverage;
            
            Console.WriteLine("Enter the first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            arithmeticAverage = (number1 + number2) / 2;
            
            Console.WriteLine("Arithmetic average from the numbers you've provided equals: " + arithmeticAverage);
            Console.ReadKey();
        }
    }
}