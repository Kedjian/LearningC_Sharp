namespace Exercises
{
    internal class ScholarshipQualificator
    {
        public static void Execute()
        {
            Console.WriteLine("Enter your GPA (grade point average):");
            double gpa = Convert.ToDouble(Console.ReadLine());
            
            if (gpa < 2)
            {
                Console.WriteLine("What were you doing with your education? Don't you wish to turn back sometimes?");
            }
            if (gpa >= 2.0 & gpa <= 3.99)
            {
                Console.WriteLine("You do not qualify for a scholarship. Sorry.");
            }
            
            if (gpa >= 4.0 & gpa <= 4.79)
            {
                Console.WriteLine("You qualify for a scholarship of 350,0 PLN monthly. Congratulations!");
            }
            
            if (gpa >= 4.8 & gpa <= 5.0)
            {
                Console.WriteLine("You qualify for a scholarship of 550,0 PLN monthly. Congratulations!");
            }
            if (gpa > 5)
            {
                Console.WriteLine("That's too high of a number.");
            }
        }
    }
}