using DubberwangInterfaces.Core;

namespace DubberwangCore;

public class LotteryGenerator : ILotteryGenerator
{
    public List<ILotteryBall> GetNewLotteryBalls(int count, int bonus = 0)
    {
        // Defensive measures, not elegant but appropriate for MVP
        if (count is < 6 or > 49)
        {
            throw new Exception("Count must be greater than or equal to 6, and less than or equal to 49!");
        }
        
        // Duplicates would be unavoidable here.
        if (count == 49)
        {
            bonus = 0;
        }

        List<ILotteryBall> lotteryBalls = new List<ILotteryBall>();
        
        lotteryBalls.AddRange(GenerateLotteryBalls(count));
        lotteryBalls.AddRange(GenerateLotteryBalls(bonus, true));

        return lotteryBalls;
    }

    private List<ILotteryBall> GenerateLotteryBalls(int count, bool bonus = false)
    {
        List<ILotteryBall> lotteryBalls = new List<ILotteryBall>();

        foreach (int _ in Enumerable.Range(0, count))
        {
            while (lotteryBalls.Count() < count)
            {
                ILotteryBall ball = GenerateLotteryBall(bonus);
                if (lotteryBalls.All(b => b.Value != ball.Value))
                {
                    lotteryBalls.Add(ball);
                }
            }
        }
        // Sort them numerically in ascending order
        lotteryBalls.Sort((x, y) => x.Value.CompareTo(y.Value));
        return lotteryBalls;
    }

    private ILotteryBall GenerateLotteryBall(bool bonus = false)
    {
        // This will always be non-negative, but we cast nonetheless for ease of use later
        uint result = uint.Parse(Random.Shared.Next(1, 50).ToString());
        return new LotteryBall(result, bonus);
    }

}