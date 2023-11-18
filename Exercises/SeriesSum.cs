namespace Exercises
{
    internal class SeriesSum
    {
        public static void Execute()
        {
            int n;
            int nSum = 0;
            Console.WriteLine("Enter the N factor: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                { 
                    nSum -= i;
                }
                else
                {
                    nSum += i;
                }
            }
            Console.WriteLine(nSum);
        }
    }
}