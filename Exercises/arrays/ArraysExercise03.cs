namespace Exercises.arrays
{
    internal class ArraysExercise03
    {
        public static void Execute()
        {
            int[] participants = { 19, 34, 23, 54, 31 };
            int sum = 0;
            double arithmeticAverage;
            Console.WriteLine("Ages of participants: ");
            foreach (int participant in participants)
            {
                Console.Write(participant + ", ");
                sum += participant;
            }
            arithmeticAverage = (double)sum / participants.Length;
            Console.WriteLine();
            Console.WriteLine("Age arithmetic average of all participants: " + arithmeticAverage + ".");
        }
    }
}