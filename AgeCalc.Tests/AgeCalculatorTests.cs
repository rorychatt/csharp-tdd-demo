using FluentAssertions;

namespace AgeCalc.Tests;

public class AgeCalculatorTests
{
    [Theory]
    [InlineData(2023, 2023, 0)]
    [InlineData(2021, 1971, 50)]
    [InlineData(2023, 1973, 50)]
    [InlineData(2072, 1972, 100)]
    public void Returns_the_age_for_a_year(int currentYear, int birthYear, int expectedAge)
    {
        var age = AgeCalculator.GetAge(currentYear, birthYear);
        age.Should().Be(expectedAge);
    }
}