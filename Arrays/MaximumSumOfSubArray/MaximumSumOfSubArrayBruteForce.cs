public class MaximumSumOfSubArrayBruteForce {
    public int MaxSubArray(int[] nums) {

        int maxSum = nums[0];

        for(int i = 0; i < nums.Length; i++)
        {
            int sum = 0;

            for(int j = i; j < nums.Length; j++)
            {
                sum += nums[j];
                maxSum = Math.Max(maxSum, sum);
            }
        }

     return maxSum;
        
    }
}