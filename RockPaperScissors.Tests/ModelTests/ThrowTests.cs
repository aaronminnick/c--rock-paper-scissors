using Microsoft.VisualStudio.TestTools.UnitTesting;

using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class ThrowTests
  {
    [TestMethod]
    public void ChooseWinner_P1RockBeatsP2Scissors_String()
    {
      Assert.AreEqual("Player 1 wins with rock!", Throw.ChooseWinner("rock", "scissors"));
    }

    [TestMethod]
    public void ChooseWinner_P1PaperBeatsP2Rock_String()
    {
      Assert.AreEqual("Player 1 wins with paper!", Throw.ChooseWinner("paper", "rock"));
    }

    [TestMethod]
    public void ChooseWinner_P1ScissorsBeatsP2Paper_String()
    {
      Assert.AreEqual("Player 1 wins with scissors!", Throw.ChooseWinner("scissors", "paper"));
    }

    [TestMethod]
    public void ChooseWinner_P2RockBeatsP1Scissors_String()
    {
      Assert.AreEqual("Player 2 wins with rock!", Throw.ChooseWinner("scissors", "rock"));
    }

    [TestMethod]
    public void ChooseWinner_P2PaperBeatsP1Rock_String()
    {
      Assert.AreEqual("Player 2 wins with paper!", Throw.ChooseWinner("rock", "paper"));
    }

    [TestMethod]
    public void ChooseWinner_P2ScissorsBeatsP1Paper_String()
    {
      Assert.AreEqual("Player 2 wins with scissors!", Throw.ChooseWinner("paper", "scissors"));
    }

    [TestMethod]
    public void ChooseWinner_SameMoveReturnsDraw_String()
    {
      Assert.AreEqual("Draw!", Throw.ChooseWinner("rock", "rock"));
      Assert.AreEqual("Draw!", Throw.ChooseWinner("paper", "paper"));
      Assert.AreEqual("Draw!", Throw.ChooseWinner("scissors", "scissors"));
    }

    [TestMethod]
    public void ChooseWinner_NonRockPaperScissorsInputsRejected_String()
    {
      Assert.AreEqual("Bad input for player 1. rock, paper, or scissors expected.", Throw.ChooseWinner("puppies", "paper"));
      Assert.AreEqual("Bad input for player 2. rock, paper, or scissors expected.", Throw.ChooseWinner("paper", "puppies"));
      Assert.AreEqual("Bad input for both players. rock, paper, or scissors expected.", Throw.ChooseWinner("puppies", "puppies"));
    }
  }
}