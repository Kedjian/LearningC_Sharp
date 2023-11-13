namespace Exercises
{
    internal class LeapYearEnumenatorAlternative
    {
        public static void Execute()
        {
            int year;
            Console.WriteLine("Enter a chosen year: ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("The year " + year + " is indeed a leap one.");
            }
            else
            {
                Console.WriteLine("The year " + year + " is not a leap one.");
            }

            Console.ReadKey();
        }
    }
}