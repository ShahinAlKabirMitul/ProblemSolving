using System;


namespace ProblemSolvingWithCSharp.EasyProlem;

public static class LongestPrefix
{
    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length==0)
        {
            return "";
        }

        string prefix = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(prefix)!=0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
            }
        }
        return prefix;
    }
}