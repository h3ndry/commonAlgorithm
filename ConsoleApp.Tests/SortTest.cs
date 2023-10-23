
public class SortTest
{
    SortingAlgorithm sorting = new();

    [Fact]
    public void Test1()
    {
        Assert.Equal(4, sorting.Add(5, 4));
    }
}
