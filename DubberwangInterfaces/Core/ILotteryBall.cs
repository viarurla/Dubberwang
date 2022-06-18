namespace DubberwangInterfaces.Core;

/// <summary>
/// Defines the characteristics of the LotteryBall
/// Which is what will be used to encapsulate the number values in API responses.
/// </summary>
public interface ILotteryBall
{
    /// <summary>
    /// The numerical value of the Lottery Ball, must be a positive int.
    /// </summary>
    uint Value { get; set; }
    
    /// <summary>
    /// The Hex representation of the ball color that should be displayed.
    /// </summary>
    string HexColor { get; }
    
    /// <summary>
    /// Determines if the ball is to be treated as a bonus ball.
    /// </summary>
    bool IsBonus { get; set; }
}