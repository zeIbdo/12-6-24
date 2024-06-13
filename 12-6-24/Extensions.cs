namespace _12_6_24;

public static class Extensions
{
    public static bool IsOdd(this int num)
    {
        if (num % 2 != 0)
        {
            return true;
        }
        return false;
    }
    public static bool IsEven(this int num)
    {
        if (num % 2 == 0)
            return true;
        return false;
    }
    public static bool IsContainsDigit(this string word)
    {
        foreach(char character in word)
        {
            if (char.IsDigit(character))
                return true;
        }
            return false;
    }
}
