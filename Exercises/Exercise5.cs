namespace Exercises
{
    internal class Exercise5
    {
        public static void Execute()
        {
            double result;
            
            result = 6.2 / 0.31;
            result -= 5.0 / 6.0 * 0.9;
            result *= 0.2;
            result += 0.15;
            result /= 0.02;
            result *= result * result;
            
            Console.WriteLine($"The result of {{[(6,2:0,31-5/9*0,9)*0,2+0,15]:0,02}}^3 is: {result}");
            Console.ReadKey();
        }
    }
}