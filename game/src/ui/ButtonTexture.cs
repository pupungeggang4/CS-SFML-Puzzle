using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace PlanterPuzzle;

public class ButtonTexture : Button
{
    public Sprite Sprite {get; set;} = new Sprite(Asset.Placeholder);
    public Text Label {get; set;}

    public ButtonTexture(List<float> rect, Texture tex, String str, uint size = 32) : base(rect)
    {
        if (tex != null)
        {
            Sprite.Texture = tex;
        }

        Vector2f texSize = (Vector2f)Sprite.Texture.Size;
        Sprite.TextureRect = new IntRect((0, 0), ((int)texSize.X, (int)texSize.Y));
        Sprite.Scale = new Vector2f(rect[2] / texSize.X, rect[3] / texSize.Y);
        Sprite.Position = new Vector2f(rect[0], rect[1]);

        Label = new Text(Asset.Neodgm, str, size);

        float baseOffset = -Label.GetLocalBounds().Position.Y;
        Label.Position = new Vector2f(rect[0] + 20.0f, rect[1] + rect[3] / 2.0f - Label.CharacterSize / 2.0f + baseOffset);
        Label.FillColor = Color.Black;
    }

    public override void Render(Game game)
    {
        game.Window.Draw(Sprite);
        game.Window.Draw(Label);
    }
}
