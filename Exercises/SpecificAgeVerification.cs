namespace Exercises
{
    internal class SpecificAgeVerification
    {
        public static void Execute()
        {
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18 && age <= 30)
            {
                switch (age)
                {
                    case 18:
                        Console.WriteLine("You're considered an adult.");
                        break;
                    
                    case 19:
                    case 20:
                    case 21:
                    case 22:
                    case 23:
                    case 24:
                    case 25:
                        Console.WriteLine("Your age is somewhere in between 19-25 years old.");
                        break;
                    default:
                        Console.WriteLine("Your age is bigger than 25, but less then 31.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Your age is not in the brackets asked for.");
            }
        }
    }
}