namespace Exercises
{
    internal class LeapYearEnumenator
    {
        public static void Execute()
        {
            int year;
            Console.WriteLine("Enter a chosen year: ");
            year = int.Parse(Console.ReadLine());
            
            if (year % 4 == 0)
            {
                if (year % 100 != 0)
                {
                    Console.WriteLine("{0} is a leap year.", year);   
                }
            }
            else
            {
                Console.WriteLine("{0} is not a leap year.", year);
            }
        }
    }
}