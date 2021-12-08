
namespace RockPaperScissors.Models
{
  public class Throw
  {
    public Throw()
    {

    }

    public static string ChooseWinner(string playerOneMove, string playerTwoMove)
    {
      string result = "";
      if (playerOneMove == playerTwoMove) 
      {
        result = "Draw!";
      }
      else if (playerOneMove == "rock") 
      {
        if (playerTwoMove == "paper")
        {
          result = "Player 2 wins with paper!";
        }
        else if (playerTwoMove == "scissors")
        {
          result = "Player 1 wins with rock!";
        }
        else
        {
          result = "Bad input for player 2. rock, paper, or scissors expected.";
        }
      }
      else if (playerOneMove == "paper")
      {
        if (playerTwoMove == "rock") 
        {
          result = "Player 1 wins with paper!";
        }
        else if (playerTwoMove == "scissors") 
        {
          result = "Player 2 wins with scissors!";
        }
        else
        {
          result = "Bad input for player 2. rock, paper, or scissors expected.";
        }
      }
      else if (playerOneMove == "scissors")
      {
        if (playerTwoMove == "paper")
        {
          result = "Player 1 wins with scissors!";
        }
        else if (playerTwoMove == "rock")
        {
          result = "Player 2 wins with rock!";
        }
        else
        {
          result = "Bad input for player 2. rock, paper, or scissors expected.";
        }
      }
      else
      {
        result = "Bad input for player 1. rock, paper, or scissors expected.";
      }
      return result;
    }
  }
}