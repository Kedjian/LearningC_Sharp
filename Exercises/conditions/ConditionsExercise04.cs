namespace Exercises.conditions
{
    internal class ConditionsExercise04
    {
        public static void Execute()
        {
            int num;
            Console.WriteLine("Enter a first chosen digit: ");
            num = Convert.ToInt32(Console.ReadLine());
            
            int num1;
            Console.WriteLine("Enter a second chosen digit: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 == 0)
            {
                Console.WriteLine("You cannot divide by zero.");
            }

            else if (num % num1 == 0)
            {
                Console.WriteLine("{0} is a divider of {1}.", num1, num);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("{0} is not a divider of {1}.", num1, num);
                Console.ReadKey();
            }
        }
    }
}