class BetterApproach
{
    //Time Complexity: O(n)
    //Space Complexity: O(n)

    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
           int num = nums[i];
           int bal = target - num;

           if (map.ContainsKey(bal))
           {
               return new int[] { map[bal], i };
           }

          map[num] = i;
        }
        
        return new int[] { -1, -1 };
    }
}