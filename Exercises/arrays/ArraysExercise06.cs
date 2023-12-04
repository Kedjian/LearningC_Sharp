namespace Exercises.arrays
{
    internal class ArraysExercise06
    {
        public static void Execute()
        {
            int[] arr = new int[11];
            int i;
            Console.Write("\n\nRead and print elements of an array:\n");
            Console.Write("------------------------------------\n");	
            
            for (i=1; i<=10; i++)
            {
                Console.Write("Element {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nElements in the array are: ");  
            for(i=0; i<=10; i++)  
            {
                if (i < 9)
                { 
                    Console.Write("{0}, ", arr[i]);   
                }
                else
                {
                    Console.Write("{0}. ", arr[i]); 
                }
            } 
            Console.Write("\n");	
        }
    }
}