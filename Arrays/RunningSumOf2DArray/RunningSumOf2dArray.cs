public class RunningSumOf2dArray {
    public int[] RunningSum(int[] nums) {

        if(nums == null || nums.Length ==0)
        {
            return null;
        }
        // return nums;

        for(int i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i-1];
        }

        return nums;
        
    }
}