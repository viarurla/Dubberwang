using DubberwangInterfaces.Constants;

namespace DubberwangCore;

public static class ColorProvider
{
    public static string GetHexColorByNumber(uint value)
    {
        return value switch
        {
            // We already know it must be at least one
            > 49 or < 1 => string.Empty,
            <= 9 => HexColors.Grey,
            <= 19 => HexColors.Blue,
            <= 29 => HexColors.Pink,
            <= 39 => HexColors.Green,
            _ => HexColors.Yellow
        };
    }
}