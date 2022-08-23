namespace LeetCode.Solutions;

public class LongestCommonPrefix
{
    public static string Result(string[] strs)
    {
        switch (strs.Length)
        {
            case 0: return "";
            case 1: return strs[0];
        }
        
        var str = strs[0];
        for (var i = 1; i < strs.Length - 1; i++)
        {
            var temp = "";
            
            int n1 = strs[i].Length,
                n2 = strs[i + 1].Length;

            for (int x = 0, y = 0; x <= n1 - 1 && y <= n2 - 1; x++, y++)
            {
                if (strs[i][x] != strs[i+1][y])
                {
                    break;
                }
                temp += strs[i][x];
            }

            str = temp;
        }

        return str;
    }
}