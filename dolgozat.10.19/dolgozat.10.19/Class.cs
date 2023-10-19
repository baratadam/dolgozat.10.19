using System;

public class NumberGuesser
{
    public int targetNumber;
    private int attempts;
    
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
            Console.WriteLine($"A kitalálandó szám nagyobb mint {number}.");
        }
        else
        {
            Console.WriteLine($"A kitalálandó szám kisebb mint {number}.");
        }

        if (attempts >= 5)
        {
            Console.WriteLine($"Elfogytak a próbálkozásaid. A keresett szám: {targetNumber}");
            return true;
        }

        return false;
    }

}