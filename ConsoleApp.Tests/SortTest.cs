public class SortTest
{
    SortingAlgorithm sorting = new();

    [Theory]
    [InlineData(new int[] { 4, 56, 3, 1, 0 }, new int[] { 0, 1, 3, 4, 56 })]
    [InlineData(new int[] { 8 }, new int[] { 8 })]
    [InlineData(new int[] { 21, 20, 8, 9 }, new int[] { 8, 9, 20,21 })]
    public void selectonSortTest(int[] input, int[] output)
    {
        sorting.SelectionSort(input);
        Assert.Equal(output, input);

    }
}

public class PalindromeCheckerCheck
{
    PalindromeChecker palindromeChecker  = new ();
    [Theory]

    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(123, true)]
    public void IsPalindromeTest(int input, bool output)
    {
        bool isIt = palindromeChecker.IsPalindrome(input);
        Assert.Equal(output, isIt);
    }
}
