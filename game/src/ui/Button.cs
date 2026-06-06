using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace PlanterPuzzle;

public class Button
{
    public FloatRect Area {get; set;}

    Button(List<float> rect)
    {
        Area = new FloatRect((rect[0], rect[1]), (rect[2], rect[3]));
    }

    public virtual void Render(Game game)
    {

    }

    public virtual bool Contains(Vector2f pos)
    {
        return Area.Contains(pos);
    }
}
