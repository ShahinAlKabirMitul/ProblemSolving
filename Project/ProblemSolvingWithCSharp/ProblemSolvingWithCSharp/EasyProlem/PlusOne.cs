namespace ProblemSolvingWithCSharp.EasyProlem;

public static class PlusOne
{
    public static int[] SOl1(int[] digits)
    {
        for (int i = digits.Length-1; i >=0; i--)
        {
            if (digits[i]<9)
            {
                digits[i]++;
                return digits;
            }

            digits[i] = 0;
        }

        int[] result = new int[digits.Length + 1];
         result[0] = 1;
         return result;
    }
  
    public static void SortArray(int[] arr)
    {
        if (arr.Length <= 1)
        {
            return; // Base case: array is already sorted
        }

        int mid = arr.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        for (int i = 0; i < mid; i++)
        {
            left[i] = arr[i];
        }

        for (int i = mid; i < arr.Length; i++)
        {
            right[i - mid] = arr[i];
        }

        SortArray(left);
        SortArray(right);

        Merge(arr, left, right);
    }

    public static void Merge(int[] arr, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                arr[k] = left[i];
                i++;
            }
            else
            {
                arr[k] = right[j];
                j++;
            }
            k++;
        }

        while (i < left.Length)
        {
            arr[k] = left[i];
            i++;
            k++;
        }

        while (j < right.Length)
        {
            arr[k] = right[j];
            j++;
            k++;
        }
    }

}