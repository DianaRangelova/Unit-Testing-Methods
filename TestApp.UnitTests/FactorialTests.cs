using NUnit.Framework;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        // Arrange
        int factorial = 0;

        // Act
        int actualResult = Factorial.CalculateFactorial(factorial);

        // Assert 
        int expectedResult = 1;
        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        // Arrange
        int factorial = 5; //5 * 4 * 3 * 2 * 1

        // Act
        int actualResult = Factorial.CalculateFactorial(factorial);

        // Assert 
        int expectedResult = 120;
        Assert.AreEqual(expectedResult, actualResult);
    }
}
