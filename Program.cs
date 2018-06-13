using System;
using csharp_intro.Models;

namespace csharp_intro
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.DarkBlue;
      Console.ForegroundColor = ConsoleColor.Yellow;

      Target joker = new Target("The Joker", 100);
      Target scarecrow = new Target("Scarecrow", 87);
      Target bane = new Target("Bane", 150);

      Console.WriteLine("Hello The Batman.... who would you like to fight?");
      Console.WriteLine(joker.Name);
      Console.WriteLine(scarecrow.Name);
      Console.WriteLine(bane.Name);
      var choice = Console.ReadLine();

      Target currentTarget = joker;

      if (choice == joker.Name)
      {
        currentTarget = joker;
      }

      if (choice == bane.Name)
      {
        currentTarget = bane;
      }

      if (choice == scarecrow.Name)
      {
        currentTarget = scarecrow;
      }
      Console.Clear();
      while (currentTarget.Alive)
      {
        Console.WriteLine("The Batman is fighting " + currentTarget.Name + " remaining health: " + currentTarget.Health);
        Console.WriteLine("What do you do? (fight, flee)");
        var action = Console.ReadLine();
        Console.Clear();
        if(action == "fight"){
          currentTarget.Attack();
          Console.Beep();
          Console.WriteLine(currentTarget.GetOuchWord());
        }else if(action == "flee"){
          Console.WriteLine("The Batman never flees");
        }else{
          Console.WriteLine("Stop joking around >;}");
        }
      }

      Console.WriteLine("You have defeated " + currentTarget.Name);
      Console.WriteLine("Goodbye");


    }
  }
}
