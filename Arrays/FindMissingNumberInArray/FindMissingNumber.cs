public class FindMissingNumber {
    public int MissingNumber(int[] nums) {

        //find Sum of all elements
        //Find Actual Sum of all integers using (n * n + 1)/2 formula
        //Missing num = Actual Sum - Sum

        int sum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        int n = nums.Length;

        int actualSum = (n * (n + 1))/2;

        int missingNumber = actualSum - sum;

        return missingNumber;
        
    }
}