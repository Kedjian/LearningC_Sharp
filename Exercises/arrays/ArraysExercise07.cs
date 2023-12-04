namespace Exercises.arrays
{
    internal class ArraysExercise07
    {
        public static void Execute()
        {
            int[] arr = new int [3];
            int[] rra = new int [arr.Length];
            int i;
            Console.Write("\n\nRead 3 elements and print them in reverse:\n");
            Console.Write("---------------------------------------\n");	
            
            for (i=0; i<3; i++)
            {
                Console.Write("Element {0}: ", i);
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            for (i=arr.Length-1; i>=0; i--)
            {
                rra[arr.Length-i-1] = arr[i];
            }
            Console.Write("---------------------------------------\n");	
            for (i=0; i<rra.Length; i++)
            {
                Console.WriteLine("Reverted element {0}: {1}", i, rra[i]);
            }
        }
    }
}