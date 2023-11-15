namespace Exercises
{
    internal class ShapeCreator
    {
        public static void Execute()
        {
            string sym = "*";
            char choice;
            int i;
            int n;
            
            Console.WriteLine("Enter 1 for a triangle, 2 for its horizontally swapped version, 3 for its inverted version, and 4 for a 0 figure.");
            choice = Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
                case '1':
                    for (i = 5; i >= 5; i--)
                    {
                            Console.Write(sym);
                            //Work in progress. 
                    }
                    break;
                
                default:
                    Console.WriteLine("You fricked that up mate.");
                    break;
            }
        }
    }
}