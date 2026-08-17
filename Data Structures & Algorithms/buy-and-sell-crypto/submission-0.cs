public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;
        int min = prices[0];

        for(int i=1;i<prices.Length;i++){
            
            min = Math.Min(min,prices[i]);

            int profit = prices[i] - min;

            max = Math.Max(profit, max);


        }

        return max;

    }
}
