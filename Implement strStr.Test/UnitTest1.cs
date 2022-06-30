namespace Implement_strStr.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("hello", "ll",2)]
        [InlineData("aaaaa", "bba", -1)]
        public void XUnitTest1(string haystack, string needle, int expected)
        {

            Solution solution = new Solution();
            int result = solution.StrStr(haystack, needle);
            Assert.Equal(expected, result);
        }
    }
}