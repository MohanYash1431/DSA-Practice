public class MaxSubArrayOptimalUsingKadensAlgo
{
    public int MaxSubArray(int[] nums)
    {
        int currSum = 0;
        int maxSum = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            currSum += nums[i];

            maxSum = Math.Max(maxSum, currSum);

            if (currSum < 0)
            {
                currSum = 0;
            }
        }

        return maxSum;
    }
}