namespace Exercises.basics
{
    internal class BasicsExercise13
    {
        public static void Execute()
        {
            int num1 = 6;
            int num2 = 10;
            int temp;
            
            Console.WriteLine("Integer called 'num1' has a value of {0}, while integer called 'num2' has a value of {1}.", num1, num2);
            Console.WriteLine("Press any key to swap their values.");
            Console.ReadKey();

            temp = num1;
            num1 = num2;
            num2 = temp;
            
            Console.WriteLine("Integer called 'num1' changed its value to {0}, and so did 'num2' which is now equal to {1}.", num1, num2);
            Console.WriteLine("Press any key to end the program.");
            Console.ReadKey();
        }
    }
}