using System;
using System.Collections.Generic;

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
        int maxLength = 0;
        int i = 0;
        int j = 0;
        HashSet<char> set = new HashSet<char>();

        while (j < n) {
            if (!set.Contains(s[j])) {
                set.Add(s[j]);
                maxLength = Math.Max(maxLength, j - i + 1);
                j++;
            } else {
                set.Remove(s[i]);
                i++;
            }
        }

        return maxLength;
    }
}

class Program {
    static void Main() {
        Solution solution = new Solution();
        string input = "abcabcbb";
        int result = solution.LengthOfLongestSubstring(input);
        Console.WriteLine("Length of longest substring without repeating characters: " + result);
    }
}

