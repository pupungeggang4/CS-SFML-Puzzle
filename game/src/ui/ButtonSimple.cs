using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace PlanterPuzzle;

public class ButtonSimple : Button
{
    public RectangleShape Background {set; get;}
    public Text Label {set; get;}

    public ButtonSimple(List<float> rect, Color color, String str) : base(rect)
    {
        Background = new RectangleShape((rect[2], rect[3]));
        Background.Position = new Vector2f(rect[0], rect[1]);
        Background.FillColor = color;

        Label = new Text(Asset.Neodgm, str, 32);

        float baseOffset = -Label.GetLocalBounds().Position.Y;
        Label.Position = new Vector2f(rect[0] + 20.0f, rect[1] + rect[3] / 2.0f - Label.CharacterSize / 2.0f + baseOffset);
        Label.FillColor = Color.Black;
    }

    public void Render(Game game)
    {
        game.Window.Draw(Background);
        game.Window.Draw(Label);
    }
}
