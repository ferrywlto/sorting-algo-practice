using System;
using SortingAlgorithms;
using Xunit;

namespace SortingAlgorithm.Tests;

public class SortingAlgorithmTests
{
    private static int[] GetSorted() => SortingAlgorithmTestsHelper.GetSorted();
    private static int[] GetSortedDesc() => SortingAlgorithmTestsHelper.GetSortedDesc();
    private static int[] GetUnsorted() => SortingAlgorithmTestsHelper.GetUnsorted();

    [Theory]
    [InlineData(new int[0])]
    [InlineData(new[]{0,1,2})]
    [InlineData(new[]{-1,0,1})]
    public void OnePassShouldThrowNotImplementedException(int[] input) {
        var algo = new IntSortingAlgorithm(input);
        Assert.Throws<NotImplementedException>(() => algo.OnePass());
    }

    [Fact]
    public void IsSortedShouldReturnFalseOnUnsortedInput() {
        var algo = new IntSortingAlgorithm(GetUnsorted());
        Assert.False(algo.IsSorted());
    }
    
    [Fact]
    public void IsSortedShouldReturnTrueOnAscendingOnEmptyInput() {
        var algo = new IntSortingAlgorithm(Array.Empty<int>());
        Assert.True(algo.IsSorted());
    }
    
    [Fact]
    public void IsSortedShouldReturnTrueOnAscendingOnSortedInput() {
        var algo = new IntSortingAlgorithm(GetSorted());
        Assert.True(algo.IsSorted());
    }

    [Fact]
    public void IsSortedShouldReturnFalseOnDescendingSortedInput() {
        var algo = new IntSortingAlgorithm(GetSortedDesc());
        Assert.False(algo.IsSorted());
    }

    [Fact]
    public void IsSortedDescShouldReturnFalseOnAscendingSortedInput() {
        var algo = new IntSortingAlgorithm(GetSorted());
        Assert.False(algo.IsSortedDesc());
    }

    [Fact]
    public void IsSortedDescShouldReturnTrueOnDescendingSortedInput() {
        var algo = new IntSortingAlgorithm(GetSortedDesc());
        Assert.True(algo.IsSortedDesc());
    }

    [Fact]
    public void IsSortedDescShouldReturnFalseOnUnsortedInput() {
        var algo = new IntSortingAlgorithm(GetUnsorted());
        Assert.False(algo.IsSorted());
    }
}
