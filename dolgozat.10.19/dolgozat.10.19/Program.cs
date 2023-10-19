using System;

class Program
{

    static void Main()
    {
        var Guesser = new NumberGuesser();
        Random random = new Random();
        Guesser.targetNumber = random.Next(10, 99);

       

        Console.WriteLine("Üdv a számkitaláló játékban!");
        Console.WriteLine("A szám egy kétjegyű szám 10 és 99 között van.");
        Console.WriteLine("Összesen 5 próbálkozás áll a rendelkezésére");

        bool gameOver = false;

        while (!gameOver)
        {
            Console.Write("Tippeld meg a számot: ");
            if (int.TryParse(Console.ReadLine(), out int guess))
            {
                if ( guess >= 10 && guess <= 99)
                {
                    gameOver = Guesser.Guess(guess);
                }
                else
                {
                    Console.WriteLine("Kérlek adj meg egy kétjegyű számot.");
                }
            }
            else
            {
                Console.WriteLine("Érvénytelen bemenet. Kérlek adj meg egy számot.");
            }
        }

        Console.WriteLine("Köszönjük, hogy játszottál!");
    }
}