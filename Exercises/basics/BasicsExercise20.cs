namespace Exercises.basics
{
    internal class BasicsExercise20
    {
        public static void Execute()
        {
            string name;
            Console.WriteLine("Enter your name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hello " + name + ".");
            Console.ReadKey();
        }
    }
}