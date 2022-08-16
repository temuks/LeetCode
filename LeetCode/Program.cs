using LeetCode.Solutions;

Console.WriteLine("Welcome, this is my app with LeetCode problem solutions.\tIf you want to quit, than write Q and press Enter.");

start:

Console.WriteLine("Available options:");
Console.WriteLine("1. Two Sum (Easy)");

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
    case "q" or "Q":
        Console.WriteLine("Bye!");
        break;
    default:
        Console.WriteLine("Wrong input. There is no task with this code number yet.");
        goto start;
}