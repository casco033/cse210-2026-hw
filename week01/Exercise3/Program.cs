using System;

class Program
{
    static void Main(string[] args)

     {
        // Console.Write("What is the magic number? ");
        // int number = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != randomNumber)
        {
            Console.Write("Guess the number I'm thinking... ");
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

        
            if (guess > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < randomNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

            

        }

    }
}