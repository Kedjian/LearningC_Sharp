namespace Exercises.conditions
{
    internal class ConditionsExercise02
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

            if (bmi < 16)
            {
                Console.WriteLine("You're underweight (severe thinness).");
            }

            if (bmi > 16 & bmi < 16.9)
            {
                Console.WriteLine("You're underweight (moderate thinness).");
            }

            if (bmi > 17 & bmi < 18.4)
            {
                Console.WriteLine("You're underweight (mild thinness).");
            }

            if (bmi > 18.5 & bmi < 24.9)
            {
                Console.WriteLine("You're in the normal range.");
            }
            
            if (bmi > 25.0 & bmi < 29.9)
            {
                Console.WriteLine("You're overweight (pre-obese).");
            }
            
            if (bmi > 30.0 & bmi < 34.9)
            {
                Console.WriteLine("You're obese (class I).");
            }
            
            if (bmi > 30.0 & bmi < 34.9)
            {
                Console.WriteLine("You're obese (class I).");
            }
            
            if (bmi > 35.0 & bmi < 39.9)
            {
                Console.WriteLine("You're obese (class II).");
            }
            
            if (bmi > 40.0)
            {
                Console.WriteLine("You're obese (class III).");
            }
            Console.ReadKey();
        }
    }
}