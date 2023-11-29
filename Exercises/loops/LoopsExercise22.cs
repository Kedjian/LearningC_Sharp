namespace Exercises.loops
{
    internal class LoopsExercise22
    {
        public static void Execute()
        {
            Console.WriteLine("Enter a digit: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < 3; j++)
                {
                    if (i == 1 | i == 4)
                    { 
                        Console.Write("{0}", n1);   
                    }
                    else
                    {
                        Console.Write("{0} {0}", n1);
                        break;
                    }
                }
            }
        }
    }
}