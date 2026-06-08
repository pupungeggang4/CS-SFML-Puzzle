namespace PlanterPuzzle;

public class UI
{
    public static List<float> TextTitle = [20, 20];
    public static Dictionary<string, List<float>> Title = new Dictionary<string, List<float>>
    {
        {"ButtonStart", [160, 160, 960, 80]}, {"ButtonErase", [160, 240, 960, 80]}, {"ButtonQuit", [160, 320, 960, 80]}
    };
    public static List<List<float>> ArrowTitle = [[80, 160], [80, 240], [80, 320]];
}
