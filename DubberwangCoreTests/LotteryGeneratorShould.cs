using DubberwangInterfaces.Core;

namespace DubberwangCoreTests;

/// <summary>
/// Test class to cover a range of tests pertaining to the <see cref="LotteryGenerator"/> class.
/// </summary>
public class LotteryGeneratorShould
{
    /// <summary>
    /// Helper class to speed up mocking.
    /// </summary>
    private readonly AutoMocker _mocker;
    
    /// <summary>
    /// Constructor
    /// </summary>
    public LotteryGeneratorShould()
    {
        _mocker = new AutoMocker();
    }
    
    /// <summary>
    /// Ensure that the balls returned via the generator are all unique and that the size
    /// does not exceed the expected maximum.
    /// </summary>
    /// <param name="max"></param>
    [Theory]
    [InlineData(6)]
    public void ProvideUniqueBallsWithMaxSize(int max)
    {
        ILotteryGenerator generator = _mocker.CreateInstance<LotteryGenerator>();
        List<ILotteryBall> lotteryBalls = generator.GetNewLotteryBalls(max);

        lotteryBalls.Count.Should().Be(max);
        lotteryBalls.Distinct().Count().Should().Be(max);
    }

    /// <summary>
    /// Ensure that the balls returned via the generator are sorted by ascending numerical value.
    /// </summary>
    [Fact]
    public void ReturnBallsSortedNumerically()
    {
        ILotteryGenerator generator = _mocker.CreateInstance<LotteryGenerator>();
        // Larger sample size to ensure validity
        List<ILotteryBall> lotteryBalls = generator.GetNewLotteryBalls(49);

        // Bare minimum check
        lotteryBalls.Count.Should().Be(49);

        List<ILotteryBall> sortedBalls = lotteryBalls.ToList();
        sortedBalls.Sort((x, y) => x.Value.CompareTo(y.Value));

        lotteryBalls.Should().ContainInOrder(sortedBalls);
    }
}