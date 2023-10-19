using System;

class Program
{

    static void Main(string[] args)
    {
        {
            Random random = new Random();
            int targetNumber = random.Next(10, 100);
        }

        NumberGuesser guesser = new NumberGuesser();

        Console.WriteLine("Üdv a számkitaláló játékban!");
        Console.WriteLine("A szám egy kétjegyű szám 10 és 99 között van.");

        bool gameOver = false;

        while (!gameOver)
        {
            Console.Write("Tippeld meg a számot: ");
            if (int.TryParse(Console.ReadLine(), out int guess))
            {
                if (guess >= 10 && guess <= 99)
                {
                    gameOver = guesser.Guess(guess);
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