using LeetCode.Solutions;

Console.WriteLine("Welcome, this is my app with LeetCode problem solutions.\tIf you want to quit, than write Q and press Enter.");

start:

Console.WriteLine("Available options:");
Console.WriteLine("1. Two Sum (Easy)");
Console.WriteLine("9. Palindrome Number (Easy)");
Console.WriteLine("13. Roman to Integer (Easy level)");
Console.WriteLine("Longest Common Prefix (Easy level)");

var val = Console.ReadLine();

while (string.IsNullOrWhiteSpace(val))
{
    val = Console.ReadLine();
}

switch (val)
{
    case "1":
        Console.WriteLine("Two Sum (Easy level) selected. https://leetcode.com/problems/two-sum/");
        Console.WriteLine($"Indexes of two numbers that will sum 9: {string.Join(", ", TwoSum.Result(new [] {2,7,11,15}, 9))}");
        goto start;
    case "9":
        Console.WriteLine("Palindrome Number (Easy level) selected. https://leetcode.com/problems/palindrome-number/");
palindromeStart:
        Console.WriteLine("Please write the number. \tIf you want quit write Q and press Enter.");
        var checkString = Console.ReadLine();
        Console.WriteLine();
        var checkNumber = 0;
        if (!string.IsNullOrWhiteSpace(checkString))
        {
            if (checkString is "q" or "Q")
                goto start;

            if (int.TryParse(checkString, out checkNumber))
            {
                var str = PalindromeNumber.IsPalindrome(checkNumber) ? "Palindrome" : "not Palindrome";
                Console.WriteLine($"Number {checkNumber} is {str}");
                goto palindromeStart;
            }
        }
        Console.WriteLine("Invalid input. Needs integer.");
        goto palindromeStart;
    case "13":
        Console.WriteLine("Roman to Integer (Easy level) selected. https://leetcode.com/problems/roman-to-integer/");
romanStart:
        Console.WriteLine("Please write Roman number. \tIf you want to quit write Q and press Enter.");
        var checkRString = Console.ReadLine();
        Console.WriteLine();
        if (!string.IsNullOrWhiteSpace(checkRString))
        {
            if (checkRString is "q" or "Q")
                goto start;

            var int32 = RomanToInteger.RomanToInt(checkRString.ToUpper());

            if (int32 == 0)
            {
                Console.WriteLine("Invalid input. Needs Roman number.");
                goto romanStart;
            }

            Console.WriteLine(checkRString.ToUpper() + " is " + int32);
        }
        Console.WriteLine("Invalid input. Needs Roman number.");
        goto romanStart;
        
    case "14":
        Console.WriteLine("Longest Common Prefix (Easy level) selected. https://leetcode.com/problems/longest-common-prefix/");
lcpStart:
        Console.Write("Input strings using space as a separator or write Q to quit: ");
        var lcpStr = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(lcpStr))
        {
            Console.WriteLine("Incorrect input.");
            goto lcpStart;
        }
        
        if (lcpStr is "Q" or "q")
            goto start;

        string[] strings = lcpStr.Split(' ').ToArray();
        
        string ans = LongestCommonPrefix.Result(strings);
 
        if (ans.Length > 0)
        {
            Console.WriteLine("The longest common " +
                          "prefix is - " + ans);
        }
        else
        {
            Console.WriteLine("There is no common prefix");
        }
        goto start;
    case "q" or "Q":
        Console.WriteLine("Bye!");
        break;
    default:
        Console.WriteLine("Wrong input. There is no task with this code number yet.");
        goto start;
}