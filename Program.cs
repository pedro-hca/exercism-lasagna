using System;

namespace Lasagna
{
    class Lasagna
    {
        public static void Main(string[] args)
        {
            Lasagna lasagna = new Lasagna();

            int expectedMinutesInOven = lasagna.ExpectedMinutesInOven();
            Console.WriteLine(expectedMinutesInOven);
            // Saída: 40

            int remainingMinutesInOven = lasagna.RemainingMinutesInOven(20);
            Console.WriteLine(remainingMinutesInOven);
            // Saída: 20 (40 - 20)

            int preparationTime = lasagna.PreparationTimeInMinutes(3);
            Console.WriteLine(preparationTime);
            // Saída: 6 (3 * 2)

            int elapsedTime = lasagna.ElapsedTimeInMinutes(3, 20);
            Console.WriteLine(elapsedTime);
            // Saída: 26 (20 + 6)
        }

        public int ExpectedMinutesInOven()
        {
            return 40;
        }

        public int RemainingMinutesInOven(int minutesInOven)
        {
            return ExpectedMinutesInOven() - minutesInOven;
        }

        public int PreparationTimeInMinutes(int layers)
        {
            return layers * 2;
        }

        public int ElapsedTimeInMinutes(int layers, int minutesInOven)
        {
            return minutesInOven + PreparationTimeInMinutes(layers);
        }

    }


}


