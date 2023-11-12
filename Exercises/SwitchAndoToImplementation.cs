namespace Exercises
{
    internal class SwitchAndoToImplementation
    {
        public static void Execute()
        {
            double price = 0.0;
            Console.WriteLine("Enter any of the following (S / M / L): ");
            string portion = Console.ReadLine();
            switch (portion)
            {
                case "S":
                    price += 4.5;
                    break;
                case "M":
                    price += 2.0;
                    goto case "S";
                case "L":
                    price += 3.0;
                    goto case "S";
                default:
                    Console.WriteLine("You did not enter what was asked for.");
                    break;
            }
            Console.WriteLine("The price is: " + price + ".");
            Console.ReadKey();
        }
    }
}