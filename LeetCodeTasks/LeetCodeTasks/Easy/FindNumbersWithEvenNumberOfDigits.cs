namespace LeetCodeTasks.Easy
{
    public class SolutionFindNumbersWithEvenNumberOfDigits
    {
        public int FindNumbers(int[] nums)
        {
            int evenDigitsCount = 0;
            string numberToStr;
            for (var i = 0; i < nums.Length; i++)
            {
                numberToStr = nums[i].ToString();
                if (numberToStr.Length % 2 == 0)
                    evenDigitsCount++;
            }
            return evenDigitsCount;
        }
    }
}
