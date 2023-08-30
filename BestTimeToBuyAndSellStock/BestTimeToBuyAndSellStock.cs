namespace Leetcode.BestTimeToBuyAndSellStock;

public static class BestTimeToBuyAndSellStock
{
    public static int Run(int[] prices)
    {
        var l = 0;
        var r = 1;

        var result = 0;
        while (r < prices.Length)
        {
            if (prices[l] < prices[r])
            {
                var profit = prices[r] - prices[l];
                if (profit > result) result = profit;
            }
            else
            {
                l = r;
            }

            r++;
        }

        return result;
    }
}