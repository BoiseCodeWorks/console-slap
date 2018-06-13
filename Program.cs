using System;
using System.Collections.Generic;
using csharp_intro.Models;

namespace csharp_intro
{
  class Program
  {
    static void Main(string[] args)
    {
      var playing = true;

      var game = new BatmanGame();
      while (playing)
      {
        game.Play();
        Console.WriteLine("Gotham still needs you keep fighting? Y/n");
        if (Console.Read() == 'n') { playing = false; };
      }



    }
  }
}
