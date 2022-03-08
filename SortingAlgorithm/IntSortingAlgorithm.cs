namespace SortingAlgorithms;

public class IntSortingAlgorithm : ISortingAlgorithm<int> {
    protected readonly int[] Numbers;
    public IntSortingAlgorithm(int[] input) {
        Numbers = input;
    }

    public virtual int[] Sort() => throw new NotImplementedException();
    public virtual int[] OnePass() => throw new NotImplementedException();
    public bool IsSorted() => CheckSorted(LessThanPrevious);
    public bool IsSortedDesc() => CheckSorted(GreaterThanPrevious);
    
    private bool CheckSorted(Func<int, int, bool> falseStrategy) {
        for (var i = 1; i < Numbers.Length; i += 1) {
            if (falseStrategy(Numbers[i], Numbers[i-1])) return false;
        }
        return true;
    }
    
    private static bool GreaterThanPrevious(int current, int previous) => current > previous;
    private static bool LessThanPrevious(int current, int previous) => current < previous;
}
