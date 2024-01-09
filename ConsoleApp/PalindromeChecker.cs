public class PalindromeChecker
{
    public bool IsPalindrome(int number)
    {
        if (number <= 0 || number % 10 == 0)
        {
            return false;
        }

        int reversed = 0;
        while (number > reversed)
        {
            int lastNumber = number % 10;
            reversed = reversed * 10 + lastNumber;
            number /= 10;
        }

        return number == reversed / 10;
    }
}
