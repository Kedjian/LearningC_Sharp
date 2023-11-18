namespace Exercises
{
    internal class BoardExample02
    {
        public static void Execute()
        {
            Console.WriteLine("How many names do you want to enter?");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[size];
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Enter the {0} name", i+1);
                names[i] = Console.ReadLine();
            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i] + ", ");
            }
            Console.ReadKey();
        }
    }
}