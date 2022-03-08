namespace SortingAlgorithms;

public class InsertionSort : IntSortingAlgorithm {
    public InsertionSort(int[] input) : base(input) {}

    private int _currentIdx = 1;
    private readonly List<int[]> _history = new();

    public string GetPassesHistory() {
        var passes = _history.Select((h, idx) => $"pass {idx+1}: {string.Join<int>(",", h)}");
        return string.Join(Environment.NewLine, passes);   
    }

    private void RecordPass() {
        var temp = new int[Numbers.Length];
        Numbers.CopyTo(temp, 0);
        _history.Add(temp);
    }
    
    public override int[] Sort() {
        RecordPass();
        do {
            Console.WriteLine(string.Join(",", OnePass()));
            RecordPass();
        }
        while (_currentIdx < Numbers.Length);
        
        return Numbers;
    }
    
    public override int[] OnePass() {
        if (_currentIdx >= Numbers.Length) return Numbers;
        
        var keyElement = Numbers[_currentIdx];
        for (var j = _currentIdx-1; j >= 0; j -= 1) 
        {
            if (keyElement < Numbers[j]) {
                Numbers[j + 1] = Numbers[j];
                Numbers[j] = keyElement;
            }
            else break;
        }
        _currentIdx += 1;

        return Numbers;
    }
}
