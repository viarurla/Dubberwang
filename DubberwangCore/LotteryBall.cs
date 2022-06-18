using System.Net.Mail;
using DubberwangInterfaces.Core;

namespace DubberwangCore;

public class LotteryBall : ILotteryBall
{
    public uint Value { get; set; }
    public string HexColor { get; }
    public bool IsBonus { get; set; }
    
    public LotteryBall(uint value, bool isBonus = false)
    {
        Value = value;
        HexColor = ColorProvider.GetHexColorByNumber(value);
        IsBonus = isBonus;
    }
    
}