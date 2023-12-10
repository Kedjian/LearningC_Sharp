namespace Exercises.arrays
{
    internal class ArraysExercise18
    {
        public static void Execute()
        {
            
            int size;
            double sum = 0;
            double arithmetic = 0;
            int positives = 0;
            do
            {
                Console.WriteLine("\nEnter the size of an array: ");
                size = Convert.ToInt32(Console.ReadLine());
                if (size <= 1)
                {
                    Console.WriteLine("\nYou cannot pick negative integers, and 1 or 0.");
                }
            }
            while (size <= 1);
            int[] arr1 = new int[size];
            for (int iter = 0; iter < size; iter++)
            {
                Console.Write("Enter element {0}: ", iter);
                arr1[iter] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr1);
            Console.WriteLine("\nThe array got sorted, so integer positions changed! Have that in mind please.");
            /* It's definitely easier to 
             sort the array instead of 
             doing mental gymnastics. */
            Console.WriteLine("The smallest integer lies now in the position of {0} and is equal to {1}.", size-size, arr1[0]);
            /* Prints the smallest integer
             and its position as well */
            Console.WriteLine("The biggest integer lies now in the position of {0} and is equal to {1}.", size-1, arr1[size-1]);
            /* Prints the biggest integer
             and its position as well*/
            foreach (int num in arr1)
            {
                sum += num;
                arithmetic = sum / size;
            }
            Console.WriteLine("The arithmetic average of the array equals to: {0}.", arithmetic);
            foreach (int numCheck in arr1)
            {
                if (numCheck > 0)
                {
                    positives++;
                }
            }
            Console.WriteLine("The number of positive integers in the array equal to: {0}.", positives);
        }
    }
}