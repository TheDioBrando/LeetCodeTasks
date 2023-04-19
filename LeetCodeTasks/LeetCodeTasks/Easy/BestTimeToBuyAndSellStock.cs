namespace LeetCodeTasks.Easy
{
    public class SolutionBestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int left = 0, right = 1;
            int currentProfit;
            while (right < prices.Length)
            {
                currentProfit = prices[right] - prices[left];
                if (currentProfit > 0)
                    maxProfit = Math.Max(maxProfit, currentProfit);

                else
                    left = right;
                right++;
            }
            return maxProfit;
        }
    }
}
