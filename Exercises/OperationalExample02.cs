namespace Exercises
{
    internal class OperationalExample02
    {
        public static void Execute()
        {
            int x = 2, y = 3;
            x *= y * 2;
            // The whole thing up here equals: (3 * 2) x *. That's the whole philosophy of "*=".
            Console.WriteLine(x);
        }
    }
}