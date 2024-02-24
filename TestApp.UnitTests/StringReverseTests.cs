using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string emptyString = string.Empty;

        // Act
        string actualResult = StringReverse.Reverse(emptyString);

        // Assert
        Assert.AreEqual(string.Empty, actualResult);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string character = "d";

        // Act
        string actualResult = StringReverse.Reverse(character);

        // Assert
        string expectedResult = "d";
        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string text = "didika";

        // Act
        string actualResult = StringReverse.Reverse(text);

        // Assert
        string expectedResult = "akidid";
        Assert.AreEqual(expectedResult, actualResult);
    }
}
