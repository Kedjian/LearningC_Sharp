namespace Exercises
{
    internal class RequirementChecker
    {
        public static void Execute()
        {
            double x;
            
            do
            {
                Console.WriteLine("Enter X integer fulfilling requirements of 2<|x|<3: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out x))
                {
                    if (Math.Abs(x) > 2 && Math.Abs(x) < 3)
                    {
                        Console.WriteLine("Correct.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not correct.");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect type of data entered.");
                }
            } while (true);
        }
    }
}