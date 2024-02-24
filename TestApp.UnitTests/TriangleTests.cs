﻿using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        // Act
        string actualResult = Triangle.PrintTriangle(0);

        // Assert
        Assert.AreEqual("", actualResult);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        // Arrange
        string expectedResult =
            "1" + Environment.NewLine
            + "1 2" + Environment.NewLine
            + "1 2 3" + Environment.NewLine
            + "1 2" + Environment.NewLine
            + "1";

        // Act 
        string actualResult = Triangle.PrintTriangle(3);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        string expectedResult =
           "1" + Environment.NewLine
           + "1 2" + Environment.NewLine
           + "1 2 3" + Environment.NewLine
           + "1 2 3 4" + Environment.NewLine
           + "1 2 3 4 5" + Environment.NewLine
           + "1 2 3 4" + Environment.NewLine
           + "1 2 3" + Environment.NewLine
           + "1 2" + Environment.NewLine
           + "1";

        // Act 
        string actualResult = Triangle.PrintTriangle(5);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}
