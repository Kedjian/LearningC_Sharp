namespace Exercises
{
    internal class SimpleNumberComparison
    {
        public static void Execute()
        {
            int num;
            Console.WriteLine("Enter a chosen digit: ");
            num = Convert.ToInt32(Console.ReadLine());

            int num1;
            Console.WriteLine("Enter a second chosen digit: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            int num2;
            Console.WriteLine("Enter a third chosen digit: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num > num1 && num > num2)
            {
                Console.WriteLine("The biggest number is: {0}.",num);
            }
            else if (num1 > num && num1 > num2)
            {
                Console.WriteLine("The biggest number is: {0}.",num1);
            }
            else
            {
                Console.WriteLine("The biggest number is: {0}.",num2);
            }
        }
    }
}