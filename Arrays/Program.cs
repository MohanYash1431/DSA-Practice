

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

// RunningSumOf2dArray rs = new RunningSumOf2dArray();
// int[] nums = { 1, 2, 3, 4 };
// int[] runningSum = rs.RunningSum(nums);
// Console.WriteLine($"[{string.Join(", ", runningSum)}]");


// GetConcatenation gc = new GetConcatenation();
// int[] nums = { 1, 2, 3, 4 };
// int[] concatenated = gc.GetConcatenationMethod(nums);
// Console.WriteLine($"[{string.Join(", ", concatenated)}]");  

// SmallerNumbersThanCurrentOptimal snc = new SmallerNumbersThanCurrentOptimal();
// int[] nums = { 8, 1, 2, 2, 3 };
// int[] result = snc.SmallerNumbersThanCurrent(nums);
// Console.WriteLine($"[{string.Join(", ", result)}]");

// FindMaxConsecutiveOnesFromArray fmc = new FindMaxConsecutiveOnesFromArray();
// int[] nums = { 1, 1, 0, 1, 1, 1 };
// int maxConsecutive = fmc.FindMaxConsecutiveOnes(nums);
// Console.WriteLine(maxConsecutive);

// FindNumbersWithEvenDigitsFromArray fne = new FindNumbersWithEvenDigitsFromArray();
// int[] nums2 = { 12, 345, 2, 6, 7896 };
// int evenCount = fne.FindNumbers(nums2);
// Console.WriteLine(evenCount);

// ContainsDuplicateInArray cda = new ContainsDuplicateInArray();   
// int[] nums3 = { 1, 2, 3, 4, 1 };
// bool hasDuplicate = cda.ContainsDuplicate(nums3);
// Console.WriteLine(hasDuplicate);

// FindMissingNumber fmn = new FindMissingNumber();
// int[] nums4 = { 3, 0, 1 };
// int missingNumber = fmn.MissingNumber(nums4);
// Console.WriteLine(missingNumber);


// MoveZeroesToTheRightInArray mz = new MoveZeroesToTheRightInArray();
// int[] nums5 = { 0, 1, 0, 3, 12 };
// mz.MoveZeroes(nums5);
// Console.WriteLine($"[{string.Join(", ", nums5)}]"); 

// RemoveDuplicatesFromSortedArray rd = new RemoveDuplicatesFromSortedArray();
// int[] nums6 = { 1, 1, 2 };
// int newLength = rd.RemoveDuplicates(nums6);
// Console.WriteLine(newLength);
// Console.WriteLine($"[{string.Join(", ", nums6[..newLength])}]");    

// MaximumSumOfSubArrayBruteForce obj = new MaximumSumOfSubArrayBruteForce();
// int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
// int maxSubArray = obj.MaxSubArray(nums);
//  Console.WriteLine(maxSubArray);
// Console.WriteLine($"[{string.Join(", ", nums[..maxSubArray])}]");   


MaxSubArrayOptimalUsingKadensAlgo kadens = new MaxSubArrayOptimalUsingKadensAlgo();
int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
int maxSubArrayOptimal = kadens.MaxSubArray(nums);
Console.WriteLine(maxSubArrayOptimal);
Console.WriteLine($"[{string.Join(", ", nums[..maxSubArrayOptimal])}]");        

