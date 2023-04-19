namespace LeetCodeTasks.Easy
{
    public class SolutionMaxConsecutiveOnes
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            var maxOnesCount = 0;
            int currOnesCount = 0;
            for (var i = 0; i < nums.Length; i++)
            {

                if (nums[i] == 1)
                    currOnesCount++;
                else
                {
                    maxOnesCount = Math.Max(maxOnesCount, currOnesCount);
                    currOnesCount = 0;
                }
            }
            maxOnesCount = Math.Max(maxOnesCount, currOnesCount);
            return maxOnesCount;
        }
    }
}
