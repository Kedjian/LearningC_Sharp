namespace Exercises.loops
{
    internal class LoopsExercise21
    {
        public static void Execute()
        {
            Console.WriteLine("Enter a digit: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < 4; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("{0}", n1);
                    }
                    else
                    {
                        Console.Write("{0} ", n1); 
                    }
                }
            }
        }
    }
}