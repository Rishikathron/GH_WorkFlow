namespace WorkflowSample.Tests;

public class CalculatorTests
{
    [Theory]
    [InlineData(5, 3, 8)]
    [InlineData(-5, 3, -2)]
    [InlineData(0, 0, 0)]
    public void Add_ReturnsSum(int first, int second, int expected)
    {
        Assert.Equal(expected, Calculator.Add(first, second));
    }

    [Theory]
    [InlineData(5, 3, 2)]
    [InlineData(3, 5, -2)]
    [InlineData(-5, -3, -2)]
    public void Subtract_ReturnsDifference(int first, int second, int expected)
    {
        Assert.Equal(expected, Calculator.Subtract(first, second));
    }
}
