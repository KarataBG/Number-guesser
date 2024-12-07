// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");
Console.WriteLine("Guess a number between 1 and 10000");

bool stillGuessing = true;
int guessNumber = new Random().Next(1, 10001);
int guess = 0;

while (stillGuessing)
{
    Console.WriteLine("Guess the number");
    String line = Console.ReadLine();
    if (line == null)
    {
        Console.WriteLine("Please enter a value");
    }
    else if (!Regex.IsMatch(line, @"\d"))
    {
        if (line.Equals("stop")) stillGuessing = false;
        else Console.WriteLine("Please guess a number or stop the game");

    }
    else
    {

        int.TryParse(line, out guess);

        if (guess > guessNumber)
        {
            Console.WriteLine("Go lower");

        }
        else if (guess < guessNumber)
        {
            Console.WriteLine("Go Higher");
        }
        else
        {
            Console.WriteLine("Correct");
            stillGuessing = false;
            Console.WriteLine("Thank you for playing");

        }


    }
}



