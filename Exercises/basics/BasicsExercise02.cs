namespace Exercises.basics
{
    internal class BasicsExercise02
    {
        public static void Execute()
        {
            double height, weight, bmi;
            Console.WriteLine("Specify your height in square meters. Please use a dot, e.g. 1.90, and not 1,90: ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Specify your weight in kilograms: ");
            weight = Convert.ToDouble(Console.ReadLine());
            bmi = weight / (height * height);
            Console.WriteLine("Your BMI is: {0,0:F0}", bmi);
            Console.ReadKey();
        }
    }
}