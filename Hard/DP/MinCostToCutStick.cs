public class MinCostToCutStick
{
    public int MinCost(int n, int[] cuts) {
        //Your code here
        Array.Sort(cuts);
        int m = cuts.Length;
        int[,] dp = new int[m + 2, m + 2];        
        for (int l = 2; l <= m + 1; l++) //we need two ends to cut the stick, hence start from 2.
        {
            for (int i = 0; l + i <= m + 1; i++) //j = 0, i.e Start of the stick.
            {
                var j = i + l; //length of stick from i to j = K.
                dp[i,j] = int.MaxValue;
                for(var k = i + 1; k < j; k++) //increment i to check if the single cost of cut from j -> i directly is less or the cost of (j + l) & (l + k) is lesser.
                {
                    dp[i,j] = Math.Min(dp[i, j], dp[i, k] + dp[k, j]);
                }

                var left = i == 0? 0 : cuts[i - 1];
                var right = j == m + 1 ? n : cuts[j - 1];
                dp[i,j] += right - left;
            }
        }
        return dp[0, m + 1];
    }
}