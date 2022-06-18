namespace DubberwangInterfaces.Core;

public interface ILotteryBall
{
    uint Value { get; set; }
    string HexColor { get; }
    bool IsBonus { get; set; }
}