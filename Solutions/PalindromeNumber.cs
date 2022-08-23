namespace LeetCode.Solutions;

public class PalindromeNumber
{
    public static bool IsPalindrome(int x)
    {
        int total = 0;
        int temp = x;
        int reverse;

        while (x > 0)
        {
            reverse = x % 10;
            total = total * 10 + reverse;
            x /= 10;
        }

        return temp == total;
    }
}