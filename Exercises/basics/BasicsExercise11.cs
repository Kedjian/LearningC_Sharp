namespace Exercises.basics
{
    internal class BasicsExercise11
    {
        public static void Execute()
        {
            int kg = 0;
            int perKg = 10;
            Console.WriteLine("Enter your weight in kilograms: ");
            kg = Convert.ToInt32(Console.ReadLine());

            int dose = kg * perKg;
            Console.WriteLine("The maximum dose of Ibuprofen you could safely take equals to " + dose + "mg.");
        }
    }
}