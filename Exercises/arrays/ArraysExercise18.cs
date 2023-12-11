namespace Exercises.arrays
{
    internal class ArraysExercise18
    {
        public static void Execute()
        {
            int size;
            double sum = 0;
            int positives = 0;
            do
            {
                Console.WriteLine("Enter the size of an array (should be greater than 1): ");
                size = Convert.ToInt32(Console.ReadLine());
                if (size <= 1)
                {
                    Console.WriteLine("Array size should be greater than 1. Please try again.");
                }
            }
            while (size <= 1);
            int[] arr1 = new int[size];
            for (int iter = 0; iter < arr1.Length; iter++)
            {
                Console.Write("Enter element {0}: ", iter);
                arr1[iter] = Convert.ToInt32(Console.ReadLine());
            }
            int currentMax = arr1[0];
            int currentMin = arr1[0];
            int maxPos = 0;
            int minPos = 0;
            for (int iter = 0; iter < arr1.Length; iter++)
            {
                sum += arr1[iter];
                if (arr1[iter] > 0)
                {
                    positives++;
                }
                if (currentMax < arr1[iter])
                {
                    currentMax = arr1[iter];
                    maxPos = iter;
                }
                if (currentMin > arr1[iter])
                {
                    currentMin = arr1[iter];
                    minPos = iter;
                }
            }
            Console.WriteLine("The biggest integer is: {0} at position {1}.", currentMax, maxPos);
            Console.WriteLine("The smallest integer is: {0} at position {1}.", currentMin, minPos);
            Console.WriteLine("The arithmetic average of the array is: {0}.", sum / size);
            Console.WriteLine("The number of positive integers in the array is: {0}.", positives);
        }
    }
}