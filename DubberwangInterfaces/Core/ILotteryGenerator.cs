namespace DubberwangInterfaces.Core;

/// <summary>
/// Interface to define the LotteryGenerator, a service that can provide lottery results to the calling
/// code.
/// </summary>
public interface ILotteryGenerator
{
    /// <summary>
    /// Generates a new list instance of <see cref="ILotteryBall"/>
    /// </summary>
    /// <param name="count">The amount of balls to generate, with a maximum of 49</param>
    /// <param name="bonus">The amount of bonus balls to generate, will be ignored if count is 49</param>
    /// <returns></returns>
    List<ILotteryBall> GetNewLotteryBalls(int count, int bonus = 0);
}