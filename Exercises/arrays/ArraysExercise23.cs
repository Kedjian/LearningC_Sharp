namespace Exercises.arrays
{
    internal class ArraysExercise23
    {
        public static void Execute()
        {
            Console.Write("_______________________________\n\tDni tygodnia\n     w różnych językach.\n\nPolski / Angielski / Niemiecki.\n");
            string[,] weekDays = new string[7,3];
            weekDays[0, 0] = "Poniedzialek";
            weekDays[0, 1] = "Monday";
            weekDays[0, 2] = "Montag";
            weekDays[1, 0] = "Wtorek";
            weekDays[1, 1] = "Tuesday";
            weekDays[1, 2] = "Dienstag";
            weekDays[2, 0] = "Środa";
            weekDays[2, 1] = "Wednesday";
            weekDays[2, 2] = "Mittwoch";
            weekDays[3, 0] = "Czwartek";
            weekDays[3, 1] = "Thursday";
            weekDays[3, 2] = "Donnerstag";
            weekDays[4, 0] = "Piątek";
            weekDays[4, 1] = "Friday";
            weekDays[4, 2] = "Freitag";
            weekDays[5, 0] = "Sobota";
            weekDays[5, 1] = "Saturday";
            weekDays[5, 2] = "Samstag";
            weekDays[6, 0] = "Niedziela";
            weekDays[6, 1] = "Sunday";
            weekDays[6, 2] = "Sonntag";
            for (int i = 0; i < 7; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(weekDays[i,j]);
                    if (j < 2)
                    {
                        Console.Write(" / ");
                    }
                    if (j == 2)
                    {
                        Console.Write(".");
                    }
                }
            }
            Console.Write("\n_______________________________");
        }
    }
}