namespace Exercises
{
    internal class HighFeverIbuprofenDosingAssistant
    {
        public static void Execute()
        {
            int kg = 0;
            int perKg = 10;
            Console.WriteLine("Enter your weight in kilograms: ");
            kg = Convert.ToInt32(Console.ReadLine());

            int dose = kg * perKg;
            Console.WriteLine("The maximum dose of Ibuprofen you could safely take equals to " + dose + "mg. But don't take it too seriously if the dose is higher than 800mg.");
        }
    }
}