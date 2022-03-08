namespace SortingAlgorithms;

public interface ISortingAlgorithm<out T> {
    T[] Sort();
    T[] OnePass();
    bool IsSorted();
}
