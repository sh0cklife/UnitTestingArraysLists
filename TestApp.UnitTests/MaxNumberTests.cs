using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> nullList = null;

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(nullList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? emptyList = new();

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(emptyList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        List<int> oneElementList = new List<int>() { 42 };
        int result = MaxNumber.FindMax(oneElementList);
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        List<int> positiveElementList = new List<int>() { 42, 64, 86 };
        int result = MaxNumber.FindMax(positiveElementList);
        Assert.That(result, Is.EqualTo(86));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        List<int> negativeElementList = new List<int>() { -42, -64, -86, -1};
        int result = MaxNumber.FindMax(negativeElementList);
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        List<int> mixedElementList = new List<int>() { -42, -64, -86, -1, 1 };
        int result = MaxNumber.FindMax(mixedElementList);
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        List<int> mixedElementList = new List<int>() {42, 42, 1, 2, -42};
        int result = MaxNumber.FindMax(mixedElementList);
        Assert.That(result, Is.EqualTo(42));
    }
}
