namespace LeetCodeTasks.Easy
{
    public class SolutionLongestPalindrome
    {
        public int LongestPalindrome(string s)
        {
            var grouping = s.GroupBy(x => x);
            var summary = grouping.Sum(x => x.Count() / 2 * 2);
            return summary == s.Length ? s.Length : summary + 1;
        }
    }
}
