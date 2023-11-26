namespace Exercises.loops
{
    internal class LoopsExercise02
    {
        public static void Execute()
        {
            int num1;
            int summary = 0;
            int inputs = 0;

            while (summary < 100)
            {
                Console.WriteLine("Enter a digit: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                summary += num1;
                inputs += 1;
                Console.WriteLine("The summary of digits entered is: " + summary + ".");
                Console.WriteLine("The inputs you entered equal to: " + inputs + ".");
            }

            if (summary == 100)
            {
                Console.WriteLine("The digits summarized equal to 100.");
                Console.ReadKey();
            }
            
            if (summary > 100)
            {
                Console.WriteLine("The digits summarized are bigger than 100!");
                Console.ReadKey();
            }
        }
    }
}