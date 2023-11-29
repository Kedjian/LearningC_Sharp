namespace Exercises.conditions
{
    internal class ConditionsExercise24
    {
        public static void Execute()
        {
            int n1, n2;
            Console.WriteLine("Enter a first digit: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second digit: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            bool check;
            if (n1 == 20 | n2 == 20 | n1 + n2 == 20)
            {
                check = true;
                Console.WriteLine(check);
            }else 
            {
                check = false;
                Console.WriteLine(check);
            }
        }
    }
}