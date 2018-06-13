using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using csharp_intro.Models;

namespace csharp_intro
{
  public class BatmanGame
  {
    private List<Target> _targets = new List<Target>();

    private void Setup()
    {
      Console.BackgroundColor = ConsoleColor.DarkBlue;
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Clear();
      CreateEnemies();
    }

    private void CreateEnemies()
    {
      _targets.Clear();
      _targets.Add(new Target("The Joker", 100));
      _targets.Add(new Target("Scarecrow", 87));
      _targets.Add(new Target("Bane", 150));
      _targets.Add(new Target("ScaryFace", 99.9m));
      _targets.Add(new Target("SupermanWeak", 1000000000m));
      _targets.Add(new Target("Superman", 9999999999999999999m));

    }

    public void Play()
    {
      Setup();
      Target currentTarget = EnemySelect();
      BattleTarget(currentTarget);
    }

    private void BattleTarget(Target currentTarget)
    {
      Console.Clear();
      var t = new Stopwatch();
      t.Start();
      while (currentTarget.Alive)
      {
        if (currentTarget.Name == "SupermanWeak")
        {
          currentTarget.Attack();
          continue;
        }
        Console.WriteLine("The Batman is fighting " + currentTarget.Name + " remaining health: " + currentTarget.Health);
        Console.WriteLine("What do you do? (fight, flee)");
        var action = Console.ReadLine();
        Console.Clear();
        if (action == "fight")
        {
          currentTarget.Attack();
          Console.Beep();
          Console.WriteLine(currentTarget.GetOuchWord());
        }
        else if (action == "flee")
        {
          Console.WriteLine("The Batman never flees");
        }
        else
        {
          Console.WriteLine("Stop joking around >;}");
        }
      }
      t.Stop();
      Console.Clear();
      Console.WriteLine("that took: " + t.ElapsedMilliseconds /1000 + " seconds" );
      Console.WriteLine("You have defeated " + currentTarget.Name);
      Console.WriteLine("Goodbye");
    }

    private Target EnemySelect()
    {
      Target currentTarget = null;
      while (currentTarget == null)
      {
        Console.Clear();
        Console.WriteLine("Hello The Batman.... who would you like to fight?");
        _targets.ForEach(t => Console.WriteLine(t.Name));
        var choice = Console.ReadLine();
        currentTarget = _targets.Find(t => t.Name == choice);
      }

      return currentTarget;
    }
  }
}