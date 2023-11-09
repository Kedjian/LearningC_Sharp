namespace Exercises
{
    internal class Exercise20
    {
        public static void Execute()
        {
            int number;
            int power;
            int result = 1;
            int iterations = 0;

            Console.WriteLine("Enter A factor: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter N factor: ");
            power = Convert.ToInt32(Console.ReadLine());

            while (iterations < power)
            {
                result *= number;
                iterations++;
            }
            Console.WriteLine("{0}^{1} equals to: " + result + ".", number,power);
        }
    }
}