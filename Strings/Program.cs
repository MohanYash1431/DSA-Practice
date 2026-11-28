// SortingApproach sa = new SortingApproach();
// string s = "anagram";
// string t = "nagaram";
// bool isAnagram = sa.IsAnagram(s, t);
// Console.WriteLine(isAnagram);

IsPalindromeGivenString ipgs = new IsPalindromeGivenString();
string palindromeTest = "racecar";
bool isPalindrome = ipgs.IsPalindrome(palindromeTest);
Console.WriteLine(isPalindrome);

IsPalindromeBruteForce ipbf = new IsPalindromeBruteForce();
bool isPalindromeBruteForce = ipbf.IsPalindrome(palindromeTest);
Console.WriteLine(isPalindromeBruteForce);