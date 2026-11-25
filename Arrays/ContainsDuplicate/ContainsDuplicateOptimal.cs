public class ContainsDuplicateOptimal
{
    //Time Complexity: O(n)
    //Space Complexity: O(n)

    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        foreach (int num in nums)
        {
            if (set.Contains(num))
            {
                return true;
            }
            set.Add(num);
        }
        return false;
    }
}