namespace Exercises
{
    internal class ShapeCreator
    {
        public static void Execute()
        {
            int rzedy = 5;
            int wiersze = 5;
            
            string sym = "*";
            int i;
            int a;
            char choice;
            
            Console.WriteLine("Enter 1 for a triangle, 2 for its horizontally swapped version, 3 for its inverted version, and 4 for a 0 figure.");
            choice = Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
                case '1':
                    for (i = rzedy; i >= 0; --i)
                    {
                        for (a = i; a < wiersze; a++)
                        {
                            Console.Write(sym);
                        }
                    }
                    break;
                
                default:
                    Console.WriteLine("You fricked that up mate.");
                    break;
            }
        }
    }
}