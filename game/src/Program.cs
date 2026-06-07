using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace PlanterPuzzle;

public class Program
{
    static void Main(string[] args)
    {
        Asset.LoadAsset();
        Game game = new Game();
        game.Run();
    }
}
