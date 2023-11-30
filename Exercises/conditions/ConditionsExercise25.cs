namespace Exercises.conditions
{
    internal class ConditionsExercise25
    {
        public static void Execute()
        {
            int n1, n2, result;
            Console.WriteLine("Enter a first digit: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second digit: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            result = n1 + n2;
            if (result >= 10 & 20 >= result)
            {
                result = 30;
                Console.WriteLine("{0}", result);
            }
            else
            {
                Console.WriteLine("{0}", result);
            }
        }
    }
}