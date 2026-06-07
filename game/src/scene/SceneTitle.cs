using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace PlanterPuzzle;

public class SceneTitle : Scene
{
    public Text TextTitle {get; set;} = new Text(Asset.Neodgm, "Garden Defense", 32);
    public ButtonSimple ButtonExit {get; set;} = new ButtonSimple([160, 160, 960, 80],  Color.Cyan, "Quit Game");

    public SceneTitle(Game game)
    {
        TextTitle.Position = new Vector2f(20, 20);
        TextTitle.FillColor = Color.Black;
    }

    public override void Update(Game game)
    {
        
    }

    public override void Render(Game game)
    {
        game.Window.Draw(TextTitle);
        ButtonExit.Render(game);
    }

    public override void KeyDown(Game game)
    {

    }

    public override void KeyUp(Game game)
    {

    }

    public override void MouseUp(Game game, Vector2f pos, Mouse.Button button)
    {
        if (button == Mouse.Button.Left)
        {
            if (ButtonExit.Contains(pos))
            {
                game.Window.Close();
            }
        }
    }
}
