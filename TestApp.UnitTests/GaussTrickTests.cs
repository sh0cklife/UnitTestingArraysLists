using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> single = new List<int>() { 42 };

        // Act
        List<int> result = GaussTrick.SumPairs(single);

        // Assert
        CollectionAssert.AreEqual(single, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> evenList = new List<int>() { 2, 4, 6, 8 };
        // Act
        List<int> result = GaussTrick.SumPairs(evenList);
        // Assert
        List<int> expected = new List<int>() { 10, 10 };
        CollectionAssert.AreEqual(result, expected);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> oddList = new List<int>() { 4, 6, 8 };
        // Act
        List<int> result = GaussTrick.SumPairs(oddList);
        // Assert
        List<int> expected = new List<int>() { 12, 6 };
        CollectionAssert.AreEqual(result, expected);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> largeList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // Act
        List<int> result = GaussTrick.SumPairs(largeList);
        // Assert
        List<int> expected = new List<int>() { 11, 11, 11, 11, 11 };
        CollectionAssert.AreEqual(result, expected);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        List<int> largeOddList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        // Act
        List<int> result = GaussTrick.SumPairs(largeOddList);
        // Assert
        List<int> expected = new List<int>() { 12, 12, 12, 12, 12, 6 };
        CollectionAssert.AreEqual(result, expected);
    }
}
