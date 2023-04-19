namespace LeetCodeTasks.Easy
{
    public class SolutionIsSubsequence
    {
        public bool IsSubsequence(string s, string t)
        {
            var indexS = 0;
            for (var i = 0; i < t.Length && indexS < s.Length; i++)
            {
                if (s[indexS] == t[i])
                {
                    indexS++;
                }
            }
            if (indexS == s.Length)
                return true;
            return false;
        }
    }
}
