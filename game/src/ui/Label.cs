using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace PlanterPuzzle;

public class Label
{
    public Text Text {get; set;}

    public Label(string str, uint size, List<float> pos)
    {
        Text = new Text(Asset.Neodgm, str, size);
        Text.Position = new Vector2f(pos[0], pos[1]);
        Text.FillColor = Color.Black;
    }

    public void Render(Game game)
    {
        game.Window.Draw(Text);
    }
}
