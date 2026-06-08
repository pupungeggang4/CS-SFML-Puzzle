using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace PlanterPuzzle;

public class Asset
{
    public static Font Neodgm {get; set;}
    public static Texture Arrow {get; set;}

    public static void LoadAsset()
    {
        Neodgm = new Font("asset/font/neodgm.ttf");
        Neodgm.SetSmooth(true);
        Arrow = new Texture("asset/image/arrow.png");
    }
}
