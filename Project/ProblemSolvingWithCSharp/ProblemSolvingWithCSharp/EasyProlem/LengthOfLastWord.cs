namespace ProblemSolvingWithCSharp.EasyProlem;

public static class LengthOfLastWord
{
    public static int SOL1(string s)
    {
        var str = s.Trim();
        var ary = str.Split(" ");
        return ary[ary.Length - 1].Length;
       
      
    }
}