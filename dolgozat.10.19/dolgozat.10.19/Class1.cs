using System;

public class NumberGuesser
{
    private int targetNumber;
    private int attempts = 0;

    public NumberGuesser()
    {
        Random random = new Random();
        targetNumber = random.Next(10, 100);
    }

    public bool Guess(int number)
    {
        attempts++;

        if (number == targetNumber)
        {
            Console.WriteLine($"Gratulálok! Kitaláltad a számot ({targetNumber}) {attempts} próbálkozás után.");
            return true;
        }
        else if (number < targetNumber)
        {
            Console.WriteLine($"A kitalálandó szám nagyobb mint{}.");
        }
        else
        {
            Console.WriteLine($"A kitalálandó szám kisebb{}.");
        }

        if (attempts >= 5)
        {
            Console.WriteLine($"Elfogytak a próbálkozásaid. A keresett szám: {targetNumber}");
            return true;
        }

        return false;
    }
}