/*

Intuition
    The total rise + fall (efficiency) depends only on the peaks and valleys — not the steps in between.
    Points on a straight slope are redundant → removing them doesn't change efficiency
    Points on a flat segment contribute 0 → they are redundant too
    Only direction changes (peaks/valleys) + the start/end are essential

Approach 
Observation - Efficiency depends only on direction changes, not every individual machine.

The FindMinimumMachines method computes the minimum number of machines required to maintain the same efficiency score 
(sum of absolute differences between consecutive capacities) by counting direction changes in the sequence.

- It starts with 1 run (for the first machine), then iterates from index 1 to n-1:
- Calculates the current direction (currDir) as the sign of the difference between consecutive capacities.
   - Skips if currDir is 0 (no change).
   - Increments runs only if currDir differs from the last direction (lastDir), indicating a turning point (peak/valley).
   - Updates lastDir to the new direction.

This approach identifies essential points (start + direction changes), 
ensuring the efficiency sum is preserved while minimizing machines. Time: O(n), Space: O(1). 

For the example [1,2,2,1,1], it returns 3.

Complexity
Time  : O(n) — single left to right pass
Space : O(1) — only count and lastDir tracked

*/

public class FindMinimumMachinesSize
{

    public void FindMinimumMachines(int[] capacity)
    {
        
        if (capacity == null || capacity.Length == 0)
        {
            Console.WriteLine("Ans: 0");
            return;
        }

        int n = capacity.Length;
        if (n == 1)
        {
            Console.WriteLine("Ans: " + 1);
            return;
        }

        int runs = 1;
        int lastDir = 0;
        
        for (int i = 1; i < n; i++)
        {
            int currDir = Math.Sign(capacity[i] - capacity[i - 1]);
            
            // int prevDir = Math.Sign(capacity[i - 1] - capacity[i - 2]);
            if (currDir == 0) continue; // Same capacity, continue the run

             // NEW: only count if direction changed (turning point)
            if (currDir != lastDir)
            {
                runs++;       // this is a peak or valley → keep it
                lastDir = currDir;
            }
            // Same direction → collinear → skip (your code missed this)
        }

        Console.WriteLine("Ans: " + runs);
    }
}