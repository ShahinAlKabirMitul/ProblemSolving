using System.Linq;

namespace ProblemSolvingWithCSharp.EasyProlem;

public static class SingleNumber
{
    public static int SingleNumber1(int[] nums)
    {
        int ans = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            ans ^= nums[i];
        }
        return ans;
    }
}