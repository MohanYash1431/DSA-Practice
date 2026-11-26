public class FindNumbersWithEvenDigitsFromArray {
    public int FindNumbers(int[] nums) {

        int evenNums = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            int digits = 0;

            while(nums[i] > 0)
            {
                nums[i] = nums[i] / 10;
                digits++;
            }

            if(digits % 2 == 0)
            {
                evenNums++;
            }
        }

        return evenNums;
        
    }
}