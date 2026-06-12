using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace PlanterPuzzle;

public class ButtonSimple : Button
{
    public RectangleShape Background {set; get;}
    public Text Label {set; get;}

    public ButtonSimple(List<float> rect, Color color, String str, uint size = 32) : base(rect)
    {
        Background = new RectangleShape((rect[2], rect[3]));
        Background.Position = new Vector2f(rect[0], rect[1]);
        Background.FillColor = color;

        Label = new Text(Asset.Neodgm, str, size);

        float baseOffset = -Label.GetLocalBounds().Position.Y;
        Label.Position = new Vector2f(rect[0] + 20.0f, rect[1] + rect[3] / 2.0f - Label.CharacterSize / 2.0f + baseOffset);
        Label.FillColor = Color.Black;
    }

    public override void Render(Game game)
    {
        game.Window.Draw(Background);
        game.Window.Draw(Label);
    }
}
