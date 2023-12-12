namespace Exercises.arrays
{
    internal class ArraysExercise19
    {
        public static bool ChkPrime(int num1)
        {
            for (int i=2; i < num1; i++)
                if (num1 %i == 0) 
                    return false;
            return true;
        }
        public static void Execute()
        {
            int num2;
            int primeSum = 0;
            int[] arr = new int[100];
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                num2 = rand.Next(1, 999);
                arr[i] = num2;
                
                if (ChkPrime(num2))
                {
                    primeSum++;
                }
            }
            Console.Write("The amount of prime numbers randomly generated in an array: " + primeSum + ".");
        }
    }
}