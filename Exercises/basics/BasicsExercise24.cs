namespace Exercises.basics
{
    internal class BasicsExercise24
    {
        public static void Execute()
        {
            int n1;
            bool check;
            Console.WriteLine("Enter a digit: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 >= 20 && 100 >= n1 || n1 == 200)
            {
                check = true;
                Console.WriteLine(check);
            }
            else
            {
                check = false;
                Console.WriteLine(check);
            }
        }
    }
}