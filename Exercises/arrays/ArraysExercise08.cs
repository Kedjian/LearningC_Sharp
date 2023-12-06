namespace Exercises.arrays
{
    internal class ArraysExercise08
    {
        public static void Execute()
        {
            int size;
            int iter;
            Console.Write("\n\nWrite the size of your array: \n");
            Console.Write("-----------------------------\n");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.Write("Input {0} elements in the array: \n", size);  
            for(iter=0; iter<size; iter++)  
            {  
                Console.Write("Element {0}: ",iter);
                arr[iter] = Convert.ToInt32(Console.ReadLine());          
            } 
            Console.Write("\nElements in the array are: ");  
            for(iter=0; iter<size; iter++)  
            {  
                Console.Write("{0} ", arr[iter]);  
            } 
            Console.Write("\n");
        }
    }
}