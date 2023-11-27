namespace Exercises.basics
{
    internal class BasicsExercise22
    {
        public static void Execute()
        {
            int n1, n2, n3, res;
            Console.WriteLine("Enter a first digit: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second digit: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a third digit: ");
            n3 = Convert.ToInt32(Console.ReadLine());
            res = n1 * n2 * n3;
            Console.WriteLine("{0} * {1} * {2} = {3}.", n1, n2, n3, res);
        }
    }
}