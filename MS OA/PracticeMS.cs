public class PracticeMS
{
    public int MinCostClimbingStairs(int[] cost) {
        int n = cost.Length;
        int first = 0;
        int second = 0;
        
        for(int i = 2; i <= n; i++)
        {
            int current = Math.Min(second + cost[i - 1], first + cost[i - 2]);
            first = second;
            second = current;
        }
        
        return second;
    }
}