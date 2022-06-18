namespace DubberwangCoreTests;

public class ColorProviderShould
{
    [Theory]
    [InlineData(0, "")]
    [InlineData(3, HexColors.Grey)]
    [InlineData(16, HexColors.Blue)]
    [InlineData(23, HexColors.Pink)]
    [InlineData(38, HexColors.Green)]
    [InlineData(46, HexColors.Yellow)]
    public void ReturnExpectedHexColourBasedOnInputValue(uint input, string expectedValue)
    {
        string outputColor = ColorProvider.GetHexColorByNumber(input);
        outputColor.Should().BeEquivalentTo(expectedValue);
    }
}