public class SortingApproach
{
    public bool IsAnagram(string s, string t)
    {
        //Covert TO Char Arrays
        // Sort Them
        // Cinvert Back to Strings
        // Compare if they are equal.

         char[] sArr = s.ToCharArray();
         char[] tArr = t.ToCharArray();

         Array.Sort(sArr);
         Array.Sort(tArr);

         string sString = new string(sArr);
         string tString = new string(tArr);

         if(sString == tString)
         {
            return true;
         } 
           else
         {
            return false;
         }
    }
}