using System;

namespace GuessingGame
{
  class Program
  {
    // Here are our game varables and global varables that we'll need.

    // Below will be our Methods (Main Included)
    static void Main(string[] args)
    {
      Welcome();
      StartGame();
    }

    static void Welcome()
    {
      Console.WriteLine("P K Sperts - It's TECHNICALLY a game");
      Console.WriteLine("");
      Console.WriteLine("Welcome to");
      Console.WriteLine("Guessing Game 2K20!");
      Console.WriteLine("");
    }

    static int selectDifficulty()
    {
      Console.WriteLine("Select a difficulty. (easy, normal, hard).");
      int allowedAttempts = 0;
      string userChoice = Console.ReadLine();
      switch (userChoice)
      {
        case "easy":
          allowedAttempts = 8;
          break;
        case "normal":
          allowedAttempts = 6;
          break;
        case "hard":
          allowedAttempts = 4;
          break;
      }
      return allowedAttempts;
    }

    static void StartGame()
    {
      Console.WriteLine("");
      int allowedAttempts = selectDifficulty();
      int secretNumber = new Random().Next(1, 101);
      Console.Write("Guess a number between 1 and 100: ");
      Console.WriteLine("");

      int guessAttempts = 0;
      while (guessAttempts < allowedAttempts)
      {
        string userGuess = Console.ReadLine();
        int userGuessNumber;
        Int32.TryParse(userGuess, out userGuessNumber);
        Console.WriteLine($"You guessed {userGuessNumber}.");
        if (userGuessNumber != secretNumber)
        {
          Console.WriteLine("Nope that wasn't it!");
          guessAttempts++;

          if (guessAttempts != allowedAttempts)
          {
            if (userGuessNumber > secretNumber)
            {
              Console.WriteLine("Your Guess was too high!");
            }
            else
            {
              Console.WriteLine("Your Guess was too low!");
            }
            Console.WriteLine($"You have {allowedAttempts - guessAttempts} left!");
            Console.WriteLine("Guess again: ");
          }
          else
          {
            Console.WriteLine("OH NO, You're out of guesses!");
            Console.WriteLine($"The Secret Number was {secretNumber}");
          }
        }
        else
        {
          Console.WriteLine("THAT'S IT! Good job!");
          Console.WriteLine($"And it only took you {guessAttempts} tries!");
          break;
        }
      }
    }
  }
}
