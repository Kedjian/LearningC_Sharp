namespace Exercises
{
    internal class BoolPostPreIncrementationExample03
    {
        public static void Execute()
        {
            int x = 1, y = 4, z = 2;
            bool result = (x++ > 1 & y++ == 4 & z-- > 0);
            Console.WriteLine("Result={0} x={1} y={2} z={3}", result, x, y, z);
            //Result = false, x = 2, y = 5, z = 1
        }
    }
}