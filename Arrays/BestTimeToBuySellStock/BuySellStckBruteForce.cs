public class BuySellStckBruteForce
{
    //Time Complexity: O(n)
    //Space Complexity: O(1)

    public int stockBuySell(int[] arr, int n)
    {
       int maxProfit = 0;

       int minimum = arr[0];

       for(int i = 0; i < arr.Length; i++)
       {
         int currentProfit = arr[i] - minimum;

         maxProfit = Math.Max(maxProfit, currentProfit);

         minimum = Math.Min(minimum, arr[i]);

       }

       return maxProfit;
    }
}