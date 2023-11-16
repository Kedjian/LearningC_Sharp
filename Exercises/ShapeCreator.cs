namespace Exercises
{
    internal class ShapeCreator
    {
        public static void Execute()
        {
            string sym = "*";
            char choice;
            
            Console.WriteLine("Enter 1 for a triangle, 2 for its horizontally swapped version, 3 for its inverted version, and 4 for a 0 figure.");
            choice = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("");

            switch (choice)
            {
                case '1':
                    for (int i = 5; i != 0; --i)
                    { 
                        Console.Write("\n");
                        for (int n = 5; n != i; --n)
                        {
                            Console.Write(sym);
                        }
                    }
                    break;
                case '2':
                    for (int i = 0; i != 4; ++i)
                    { 
                        Console.Write("\n");
                        for (int n = 4; n != i; --n)
                        {
                            Console.Write(sym);
                        }
                    }
                    break;
                
                default:
                    Console.WriteLine("You fricked that up mate.");
                    break;
            }
            Console.ReadKey();
        }
    }
}