namespace ProblemSolvingWithCSharp.EasyProlem;

public static class RemoveDuplicates
{
    public static int Sol1(int[] nums)
    {
        if (nums.Length==0)
        {
            return 0;
        }
        int index = 0;
        int previouesValue = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (previouesValue!= nums[i])
            {
                index++;
                nums[index] = nums[i];
               
                previouesValue = nums[i];
            }
        }
        return index;
    } 
}