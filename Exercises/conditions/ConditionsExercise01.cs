namespace Exercises.conditions
{
    internal class ConditionsExercise01
    {
        public static void Execute()
        {
            int wiek;
            
            Console.WriteLine("Enter your age: ");
            wiek = Convert.ToInt32(Console.ReadLine());

            if (wiek >= 18)
            {
                Console.WriteLine("You're an adult.");
            }
            else
            {
                Console.WriteLine("You're not an adult.");
            }
            
            Console.ReadKey();
        }
    }
}