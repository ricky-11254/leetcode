using System;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return "";
        }

        string prefix = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix.Length == 0)
                {
                    return "";
                }
            }
        }

        return prefix;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        string[] strs = Console.ReadLine().Split(' ');
        string result = solution.LongestCommonPrefix(strs);
        Console.WriteLine(result);
    }
}
