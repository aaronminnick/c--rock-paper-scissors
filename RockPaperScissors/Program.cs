using System;
using RockPaperScissors.Models;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Choose rock, paper, or scissors");
    string playerThrow = Console.ReadLine();
    Random rnd = new Random();
    int intCompThrow = rnd.Next(1, 4);
    string stringCompThrow = "";
    if (intCompThrow == 1) 
    {
      stringCompThrow = "rock";
    }
    else if (intCompThrow == 2) 
    {
      stringCompThrow = "paper";
    }
    else if (intCompThrow == 3) 
    {
      stringCompThrow = "scissors";
    }
    Console.WriteLine("Player 2 chooses " + stringCompThrow);
    Console.WriteLine(Throw.ChooseWinner(playerThrow, stringCompThrow));
    Main();

  }
}