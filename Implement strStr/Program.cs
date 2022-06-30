public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (needle == null) return 0;
        if (haystack == null) return 0;


        return haystack.IndexOf(needle);

    }


    static void Main()
    {
        string haystack = "hello", needle = "ll";
        Solution solution = new Solution();
        int x = solution.StrStr(haystack, needle);
        Console.ReadLine();
    }
}