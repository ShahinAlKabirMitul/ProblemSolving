namespace ProblemSolvingWithCSharp.EasyProlem;

public static class RemoveElement
{
    public static int SOL1(int[] nums, int value)
    {
        
        
        int i = 0;
        int count = 0;
        foreach (int num in nums)
        {
            if (num!=value)
            {
                
                nums[count++] = nums[i];
            }

            i++;
        }

        return count;
    }
}