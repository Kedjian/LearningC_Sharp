namespace Exercises.methods
{
    internal class MethodsExercise01
    {
        public static void Execute()
        {
            static void Substract(int x, int y)
            {
                int substracted = x - y;
                Console.Write("{0} - {1} equals to {2}.", x, y, substracted);
            } 
            Substract(27, 4);
            Console.ReadKey();
        }
    }
}