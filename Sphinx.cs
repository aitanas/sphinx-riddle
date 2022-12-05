using System;
using System.Collections.Generic;

namespace Sphinx {
  public class Program
  {
    public static void Main()
    {
      Random random = new Random();
      Dictionary<int, string> riddlesDict = new Dictionary<int, string>() { {1, "'I create my lair with earthen string, and dispatch my prey with a biting sting.'"}, {2, "'Some try to hide, some try to cheat; but time will show, we always will meet. Try as you might to guess my name.'"}, {3, "'At night they come without being fetched, and by day they are lost without being stolen.'"}, {4, "'This thing all things devour: birds, beasts, trees, flowers; gnaws iron, bites steel; grinds hard stones to meal; slays kings, ruins towns; and beats high mountains down.'"} };
      Dictionary<int, string> answersDict = new Dictionary<int, string>() { {1, "spider"}, {2, "death"}, {3, "stars"}, {4, "time"} };

      int riddleSelector = random.Next(1,4);
      // riddlesDict[riddleSelector]; // pulls random riddle
      // answersDict[riddleSelector]; // pulls random riddle's answer

      Console.WriteLine("The Sphinx requires you to answer her riddle or be eaten.");
      Console.WriteLine(riddlesDict[riddleSelector]);
      string userResponse = Console.ReadLine();
      string responseLower = userResponse.ToLower();

      if (responseLower.Contains(answersDict[riddleSelector]))
      {
        Console.WriteLine("You have answered correctly! The Sphinx has been defeated!");
      }
      else
      {
        Console.WriteLine("Wrong Answer. The Sphinx eats you!");
      }
    }
  }
}