namespace Exercises
{
    internal class DayGuesser
    {
        public static void Execute()
        {
            Console.WriteLine("Enter the number of the day of the week:");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Monday is your choice, and it is the first day of a week.");
                    break;
                case 2:
                    Console.WriteLine("Tuesday is your choice, and it is the second day of a week.");
                    break;
                case 3:
                    Console.WriteLine("Wednesday is your choice, and it is the third day of a week.");
                    break;
                case 4:
                    Console.WriteLine("Thursday is your choice, and it is the fourth day of a week.");
                    break;
                case 5:
                    Console.WriteLine("Friday is your choice, and it is the fifth day of a week.");
                    break;
                case 6:
                    Console.WriteLine("Saturday is your choice, and it is the sixth day of a week.");
                    break;
                case 7:
                    Console.WriteLine("Sunday is your choice, and it is seventh day of a week.");
                    break;
                default:
                    Console.WriteLine("I didn't ask you to enter this.");
                    break;
            }
            Console.ReadKey();
        }
    }
}