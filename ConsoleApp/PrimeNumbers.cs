public class PrimeNumbers
{
    public bool CheckPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }
        for (int x = 2; x <= Math.Sqrt(number); x++)
        {
            if (number % x == 0)
            {
                return false;
            }
        }
        return true;
    }
}
