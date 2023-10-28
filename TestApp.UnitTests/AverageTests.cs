using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    // TODO: finish the test
    [Test]
    public void Test_CalculateAverage_InputIsEmptyArray_ShouldThrowArgumentException()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act & Assert
        Assert.That(() => Average.CalculateAverage(emptyArray), Throws.ArgumentException);
       
    }

    // TODO: finish the test
    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] array = { 42 };

        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] possitiveArray = { 1, 2, 3 };
        // Act
        double result = Average.CalculateAverage(possitiveArray);
        // Assert
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] negativeArray = { -1, -2, -3 };
        // Act
        double result = Average.CalculateAverage(negativeArray);
        // Assert
        Assert.That(result, Is.EqualTo(-2));
    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] mixedArray = { -1, -2, 1, 2, 3 };
        // Act
        double result = Average.CalculateAverage(mixedArray);
        // Assert
        Assert.That(result, Is.EqualTo(0.6));
    }
}
