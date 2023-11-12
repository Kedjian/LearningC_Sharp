namespace Exercises
{
    internal class PopulationDensityEnumerator
    {
        public static void Execute()
        {
            double powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = osoby/powierzchnia;
            Console.WriteLine(gestoscZaludnienia);
            //The reason for which the program did not work was that int was used in line 9.
        }
    }
}