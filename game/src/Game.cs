using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace PlanterPuzzle;

public class Game
{
    public RenderWindow Window {get; set;}
    public View ViewUI {get; set;}
    public uint Width {get; set;} public uint Height {get; set;}

    public Game()
    {
        var monitor = VideoMode.DesktopMode;
        if (monitor.Size.X * 9 / 16 > monitor.Size.Y)
        {
            Height = (uint)(monitor.Size.Y * 0.8);
            Width = Height * 16 / 9;
        }
        else
        {
            Width = (uint)(monitor.Size.X * 0.8);
            Height = Width * 9 / 16;
        }
        var mode = new VideoMode((Width, Height));
        Window = new RenderWindow(mode, "Planter Puzzle");
        Window.Closed += (sender, e) => Window.Close();
    }

    public void Run()
    {
        Loop();
    }

    public void Loop()
    {
        while (Window.IsOpen)
        {
            Window.DispatchEvents();
            Window.Clear(Color.White);
            Window.Display();
        }
    }

    public void KeyDown()
    {

    }

    public void KeyUp()
    {

    }

    public void MouseUp()
    {

    }
}
