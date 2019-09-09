using System;

namespace intro_to_dotnet
{
  class Program
  {
    static void Main(string[] args)
    {
      var min = 1;
      var max = 100;
      var lower = min;
      var upper = max;
      var guess = 50;
      var guessing = true;
      Console.WriteLine("Think Of A Number Between 1-100");
      while (guessing == true)
      {
        // Starting Guess
        Console.WriteLine($"Is Your Number, {guess}?");
        var input = Console.ReadLine();
        // Guessed Correct
        if (input == "yes")
        {
          guessing = false;
        }
        // If Higher
        else
        {
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
      Console.WriteLine($"Congrats Your Number is {guess}");
    }
  }
}
