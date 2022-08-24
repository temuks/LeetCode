namespace LeetCode.Solutions;

public class RomanToInteger
{
    public static int RomanToInt(string s)
    {
        int sum = 0;
        var romanNumbersDictionary = new Dictionary<char, int>
        {
            {'I', 1 },
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100}, 
            {'D', 500}, 
            {'M', 1000}
        };

        for (int i = 0; i < s.Length; i++)
        {
            char currentRomanChar = s[i];
            if (!romanNumbersDictionary.ContainsKey(currentRomanChar))
            {
                Console.WriteLine("That's not a roman number. Write it correct!");
                return 0;
            }

            romanNumbersDictionary.TryGetValue(currentRomanChar, out int num);
            
            if (i > 0) {
                if (num > romanNumbersDictionary[s[i-1]]) {
                    sum += num - 2 * romanNumbersDictionary[s[i-1]];
                } else {
                    sum += num;
                }
            } else {
                sum += num;
            }
        }

        return sum;
    }
}
