using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace PlanterPuzzle;

public class Asset
{
    public static Font Neodgm {get; set;}
    public static Texture Arrow {get; set;}
    public static Texture Placeholder {get; set;}

    public static Texture ButtonLong {get; set;}

    public static void LoadAsset()
    {
        Neodgm = new Font("asset/font/neodgm.ttf");
        Neodgm.SetSmooth(true);
        Placeholder = new Texture("asset/image/placeholder.png");
        Arrow = new Texture("asset/image/arrow.png");
        ButtonLong = new Texture("asset/image/button_long.png");
    }
}
