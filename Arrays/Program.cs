// BruteForce bf = new BruteForce();
// int[] nums = { 2, 7, 11, 15 };
// int target = 9;
// int[] result = bf.TwoSum(nums, target);
// Console.WriteLine($"[{result[0]}, {result[1]}]");

// BetterApproach ba = new BetterApproach();
// int[] nums = { 2, 7, 11, 15 };
// int target = 9;
// int[] result = ba.TwoSum(nums, target);
// Console.WriteLine($"[{result[0]}, {result[1]}]");

// BuySellStckBruteForce bs = new BuySellStckBruteForce();
// int[] prices = { 7, 1, 5, 3, 6, 4 };
// int n = prices.Length;
// int maxProfit = bs.stockBuySell(prices, n);
// Console.WriteLine(maxProfit);

RunningSumOf2dArray rs = new RunningSumOf2dArray();
int[] nums = { 1, 2, 3, 4 };
int[] runningSum = rs.RunningSum(nums);
Console.WriteLine($"[{string.Join(", ", runningSum)}]");
