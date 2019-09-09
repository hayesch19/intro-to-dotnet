using System;

namespace intro_to_dotnet
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("I Can Guess Your Number!.");
      System.Threading.Thread.Sleep(2000);
      Console.ResetColor();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Think Of A Number Between 1-100 Then Hit 'Enter'");
      // user input
      while (Console.ReadKey().Key != ConsoleKey.Enter) { }
      var min = 1;
      var max = 100;
      var lower = min;
      var upper = max;
      var guess = 50;
      var guessing = true;
      while (guessing == true)
      {
        // Starting Guess
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Is Your Number, {guess}?");
        var input = Console.ReadLine();
        // Guessed Correct
        if (input == "yes")
        {
          Console.ResetColor();
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine($"Haha Your Number is {guess}");
          System.Threading.Thread.Sleep(1000);
          Console.ForegroundColor = ConsoleColor.Magenta;
          Console.WriteLine("Want To Play Again?");
          var playAgain = Console.ReadLine();
          if (playAgain == "yes")
          {
            guess = 50;
            guessing = true;
          }
          if (playAgain == "no")
          {
            guessing = false;
            Console.ResetColor();
          }
        }
        // If Higher
        else
        {
          Console.ResetColor();
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.WriteLine("Is It Higher or Lower?");
          var high = Console.ReadLine();
          if (high == "higher")
          {
            min = guess;
            guess = (min + max) / 2;
          }
          // If Lower
          else
          {
            max = guess;
            guess = (min + max) / 2;
          }
        }
      }
    }
  }
}
