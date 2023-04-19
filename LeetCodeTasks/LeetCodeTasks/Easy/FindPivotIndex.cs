namespace LeetCodeTasks.Easy
{
    public class SolutionFindPivotIndex
    {
        public int PivotIndex(int[] nums)
        {
            int totalSum = 0, leftSum = 0;
            foreach (var x in nums)
                totalSum += x;
            for (var i = 0; i < nums.Length; i++)
            {
                if (leftSum == totalSum - nums[i])
                    return i;
                leftSum += nums[i];
                totalSum -= nums[i];
            }
            return -1;
        }
    }
}
