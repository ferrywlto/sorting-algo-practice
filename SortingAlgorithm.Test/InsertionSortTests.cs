using System.Linq;
using SortingAlgorithms;
using Xunit;

namespace SortingAlgorithm.Tests;

public class InsertionSortTests {
    private static int[] TestPassInput => new[] { 1, -3, 5, -7, 9, -10, 8, -6, 4, -2 };

    [Fact]
    public void TestOnePass() {
        var input = TestPassInput;
        var expected = new[] { -3, 1, 5, -7, 9, -10, 8, -6, 4, -2 };
        var algo = new InsertionSort(input);
        var actual = algo.OnePass();
        Assert.True(actual.SequenceEqual(expected));
    }

    [Fact]
    public void TestTwoPasses() {
        var input = TestPassInput;
        var expected = new[] { -3, 1, 5, -7, 9, -10, 8, -6, 4, -2 };
        var algo = new InsertionSort(input);
        algo.OnePass();
        var actual = algo.OnePass();
        Assert.True(actual.SequenceEqual(expected));
    }

    [Fact]
    public void TestThreePasses() {
        var input = TestPassInput;
        var expected = new[] { -7, -3, 1, 5, 9, -10, 8, -6, 4, -2 };
        var algo = new InsertionSort(input);
        algo.OnePass();
        algo.OnePass();
        var actual = algo.OnePass();
        Assert.True(actual.SequenceEqual(expected));
    }

    [Fact]
    public void TestIsSortedTrueOnSortedData() {
        var input = SortingAlgorithmTestsHelper.GetSorted();
        var algo = new InsertionSort(input);
        Assert.True(algo.IsSorted());
    }

    [Fact]
    public void AlgoWillNotBreakSortedDataWithSort() {
        var input = SortingAlgorithmTestsHelper.GetSorted();
        var algo = new InsertionSort(input);
        algo.Sort();
        Assert.True(algo.IsSorted());
    }

    [Fact]
    public void AlgoWillNotBreakSortedDataWithOnePass() {
        var input = SortingAlgorithmTestsHelper.GetSorted();
        var algo = new InsertionSort(input);
        algo.OnePass();
        Assert.True(algo.IsSorted());
    }

    [Fact]
    public void TestIsSortedFalseOnUnsortedData() {
        var input = SortingAlgorithmTestsHelper.GetSortedDesc();
        var algo = new InsertionSort(input);
        Assert.False(algo.IsSorted());
    }

    [Fact]
    public void IsSortedTrueAfterSortOnUnsortedData() {
        var input = SortingAlgorithmTestsHelper.GetSortedDesc();
        var algo = new InsertionSort(input);
        algo.Sort();
        Assert.True(algo.IsSorted());
    }
    
    [Fact]
    public void IsSortedFalseAfterOnePassOnUnsortedData() {
        var input = SortingAlgorithmTestsHelper.GetSortedDesc();
        var algo = new InsertionSort(input);
        algo.OnePass();
        Assert.False(algo.IsSorted());
    } 
    
    [Theory]
    [MemberData(nameof(SortingAlgorithmTestsHelper.TestData), MemberType = typeof(SortingAlgorithmTestsHelper))]
    public void TestSort(int[] input) {
        var expected = input.ToList();
        expected.Sort();
        var sortAlgo = new InsertionSort(input);
        var result = sortAlgo.Sort();
        Assert.True(result.SequenceEqual(expected));
    }
}
