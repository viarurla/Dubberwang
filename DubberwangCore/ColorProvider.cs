using DubberwangInterfaces.Constants;

namespace DubberwangCore;

/// <summary>
/// Static class to handle color assignments.
/// </summary>
public static class ColorProvider
{
    /// <summary>
    /// Using the supplied number, return the corresponding color.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
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