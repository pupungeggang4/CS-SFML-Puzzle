using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using static SFML.Window.Keyboard;

namespace PlanterPuzzle;

public class SceneTitle : Scene
{
    public Text TextTitle {get; set;} = new Text(Asset.Neodgm, "Planter Puzzle", 32);
    public ButtonSimple ButtonExit {get; set;} = new ButtonSimple([160, 160, 960, 80],  Color.Cyan, "Quit Game");
    public int SelectedTitle {get; set;}
    public Sprite Arrow {get; set;} = new Sprite(Asset.Arrow);

    public SceneTitle(Game game)
    {
        TextTitle.Position = new Vector2f(20, 20);
        TextTitle.FillColor = Color.Black;

        SelectedTitle = 0;
    }

    public override void Update(Game game)
    {
    }

    public override void Render(Game game)
    {
        game.Window.Draw(TextTitle);
        Arrow.Position = new Vector2f(80, 160 + 80 * SelectedTitle);
        game.Window.Draw(Arrow);
        ButtonExit.Render(game);
    }

    public override void KeyDown(Game game, Key key)
    {
        if (key == Key.Escape)
        {
            game.Window.Close();
        }
        if (key == Key.Up || key == Key.W)
        {
            SelectedTitle = (SelectedTitle + 2) % 3;
        }
        else if (key == Key.Down || key == Key.S)
        {
            SelectedTitle = (SelectedTitle + 1) % 3;
        }
        else if (key == Key.Enter)
        {
            if (SelectedTitle == 0)
            {

            }
            else if (SelectedTitle == 1)
            {

            }
            else if (SelectedTitle == 2)
            {
                game.Window.Close();
            }
        }
    }

    public override void KeyUp(Game game, Key key)
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
