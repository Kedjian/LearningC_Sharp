namespace Exercises
{
    internal class ComplexPostPreIncrementation
    {
        public static void Execute()
        {
            int x, y = 5;
            x = ++y * 2;
            //x = 12, y = 6
            x = y++;
            //x = 6, y = 6 
            x = y--;
            //x = 7, y = 7
            Console.WriteLine(++y);
            //y = 7
        }
    }
}