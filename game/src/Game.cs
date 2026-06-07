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

    public Scene Scene {get; set;}

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
        ViewUI = new View(new FloatRect((0, 0), (1280, 720)));
        Window.SetView(ViewUI);
        Window.Closed += (sender, e) => Window.Close();
        Window.MouseButtonReleased += (sender, e) => MouseUp(sender, e);
    }

    public void Run()
    {
        Scene = new SceneTitle(this);
        Loop();
    }

    public void Loop()
    {
        while (Window.IsOpen)
        {
            Window.DispatchEvents();
            Scene.Update(this);
            Window.Clear(Color.White);
            Scene.Render(this);
            Window.Display();
        }
    }

    public void KeyDown()
    {

    }

    public void KeyUp()
    {

    }

    public void MouseUp(Object sender, MouseButtonEventArgs e)
    {
        Vector2f pos = new Vector2f(e.Position.X * 1280 / Width, e.Position.Y * 720 / Height);
        Scene.MouseUp(this, pos, e.Button);
    }
}
