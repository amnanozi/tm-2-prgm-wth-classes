using System;

class Program
{
    static void Main(string[] args)
    {
       Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 102);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine(" Too higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Too lower");
            }
            else
            {
                Console.WriteLine("You guessed it right!");
            }

        }                    

    }

}