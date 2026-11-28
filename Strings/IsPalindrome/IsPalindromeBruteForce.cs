using System.Text;

public class IsPalindromeBruteForce
{
    public bool IsPalindrome(string s) {
        //Clean the string and append to Stringbuilder
        //Convert StringBuilder to String
        //Make ti CharArray and Reverse it and make it rev string
        // Compare rev string with Cleaned String.

        StringBuilder cleaned = new StringBuilder();

        foreach(char c in s)
        {
            if(char.IsLetterOrDigit(c))
            {
                cleaned.Append(char.ToLowerInvariant(c));
            }
        }

        string str = cleaned.ToString();

        char[] arr = str.ToCharArray();

        Array.Reverse(arr);

        string rev = new string(arr);

        if(str == rev)
        {
           return true;
        }

      return false;

    }
}