public class SmallerNumbersThanCurrentOptimal {
    public int[] SmallerNumbersThanCurrent(int[] nums) {

        int[] sortedArray = (int[])nums.Clone();

        Array.Sort(sortedArray);

        Dictionary<int, int> dic = new Dictionary<int, int>();

        int[] res = new int[sortedArray.Length];

        for(int i = 0; i < sortedArray.Length; i++)
        {

            if(!dic.ContainsKey(sortedArray[i]))
            {
                dic.Add(sortedArray[i], i);
            }
        }

        for(int i = 0; i < nums.Length; i++)
        {
            res[i] = dic[nums[i]];
        }
        
        return res;
    }
}