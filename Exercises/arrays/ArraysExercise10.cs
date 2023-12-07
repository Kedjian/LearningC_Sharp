namespace Exercises.arrays
{
    internal class ArraysExercise10
    {
        public static void Execute()
        {
            int size;
            int iter;
            Console.Write("\nWrite the size of your array: \n");
            Console.Write("-----------------------------\n");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for(iter=0; iter<size; iter++)  
            {  
                Console.Write("Element {0}: ",iter);
                arr[iter] = Convert.ToInt32(Console.ReadLine());          
            }
            Console.Write("\nElements in the array are: ");
            foreach (int x in arr)
            {
                Console.Write("{0} ", x);
            }
            Console.Write("\nReversed elements in the array are: ");
            Array.Reverse(arr);
            foreach (int x in arr)
            {
                Console.Write("{0} ", x);
            }
            
        }
    }
}