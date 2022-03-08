using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithm.Tests;

public static class SortingAlgorithmTestsHelper {
    public static int[] GetSorted() => Enumerable.Range(-1, 10).ToArray();
    public static int[] GetSortedDesc() => GetSorted().Reverse().ToArray();
    public static int[] GetUnsorted() => new[] { -1, 3, -5, 7, -9, 10, -8, 6, -4, 2 };
    public static int[] GetUnsortedDesc() => new[] { 10, -8, 6, -4, 2, -1, 3, -5, 7, -9 };

    public static IEnumerable<object[]> TestData() {
        var testData = new List<int[]> {
            GetSorted(),
            GetSortedDesc(),
            GetUnsorted(),
            GetUnsortedDesc(),
        };

        yield return new object[] { testData[0] };
        yield return new object[] { testData[1] };
        yield return new object[] { testData[2] };
        yield return new object[] { testData[3] };
    }
}
