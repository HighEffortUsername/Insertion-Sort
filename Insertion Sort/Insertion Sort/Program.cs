﻿internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = { 1, 8, 94, 2, 5, 12, 53, 91, 9};
        int[] sorted = Sort(nums);
        for(int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(sorted[i]);
        }
    }
    private static int[] Sort(int[] nums)
    {
        for(int i  = 1; i < nums.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[i] < nums[j])
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
        return nums;
    }
}