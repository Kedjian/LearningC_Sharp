namespace Exercises.conditions
{
    internal class ConditionsExercise11
    {
        public static void Execute()
        {
            Console.WriteLine("Enter a digit from 1 to 999: ");
            int num = Convert.ToInt32(Console.ReadLine()); 
            
            int hundreds = num / 100;
            num -= hundreds * 100;
            int tens = num / 10;
            num -= tens * 10;
            int units = num;

            int summary = hundreds + tens + units;
            if (summary % 3 == 0)
            {
                Console.WriteLine("The digit is divisible by 3.");
            }
            else
            {
                Console.WriteLine("The digit is not divisible by 3.");
            }
        }
    }
}