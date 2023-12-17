namespace Exercises.methods
{
    internal class MethodsExercise02
    {
        public static void Execute()
        {
            static double Divide(double x, int y)
            {
                if (y == 0)
                {
                    throw new Exception("Undefined");
                }
                double divided = x / y;
                Console.Write("{0} / {1} equals to ", x, y);
                return divided;
            }
            Console.Write(Divide(11,2));
        }
    }
}