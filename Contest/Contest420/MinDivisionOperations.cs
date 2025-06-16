public class MinDivisionOperations
{
    public int MinOperations1(int[] nums) 
    {
        int n = nums.Length;
        int[,] dp = new int[n, 21]; // 21 is the maximum number of divisors a number can have (log base 2 of 10^6)
        
        // Fill dp for the first element
        for (int i = 0; i < 21; i++) {
            dp[0, i] = i; // Zero or more divisions for nums[0]
        }

        // Loop through each element of the array
        for (int i = 1; i < n; i++) {
            // Get possible divisions for nums[i]
            List<int> divisors = GetDivisors1(nums[i]);

            // Track the minimum number of operations
            for (int j = 0; j < divisors.Count; j++) {
                dp[i, j] = int.MaxValue;
                for (int k = 0; k < divisors.Count; k++) {
                    if (divisors[j] >= divisors[k]) {
                        dp[i, j] = Math.Min(dp[i, j], dp[i - 1, k] + j);
                    }
                }
            }
        }

        // Find the minimum number of operations for the last element
        int result = int.MaxValue;
        for (int i = 0; i < 21; i++) {
            result = Math.Min(result, dp[n - 1, i]);
        }

        return result == int.MaxValue ? -1 : result;
    }

    // Get the list of all possible divisors for a number
    private List<int> GetDivisors1(int num) 
    {
        List<int> divisors = new List<int>();
        while (num > 1) {
            divisors.Add(num);
            num /= 2; // The greatest proper divisor is num / 2
        }
        divisors.Add(1); // Add 1 as the final divisor
        return divisors;
    }


    // Helper function to get all proper divisors of a number x
    private List<int> GetProperDivisors2(int x) {
        List<int> divisors = new List<int>();
        for (int i = 1; i * i <= x; i++) {
            if (x % i == 0) {
                // i is a divisor
                if (i != x) divisors.Add(i);
                // x / i is also a divisor, check to avoid duplicates and exclude x itself
                if (i != x / i && x / i != x) divisors.Add(x / i);
            }
        }        
        divisors.Sort(); // Sort the divisors to easily find the greatest one that satisfies the condition
        if(divisors.Count > 0 && divisors[0] == 1)
            divisors.Remove(1);
        return divisors;
    }

    public int MinOperations(int[] nums) {
        int n = nums.Length;
        int totalOperations = 0;

        // Iterate over the array from the second element
        for (int i = 1; i < n; i++) {
            // If the current element nums[i] is smaller than the previous one, nums[i - 1] needs to be reduced
            if (nums[i] < nums[i - 1]) {
                bool possible = false; // To track if it is possible to make nums[i - 1] <= nums[i]
                
                // Get all proper divisors of nums[i - 1]
                var divisors = GetProperDivisors2(nums[i - 1]);
                
                // Try reducing nums[i - 1] to a proper divisor that is less than or equal to nums[i]
                foreach (var divisor in divisors) {
                    if (divisor <= nums[i]) {
                        totalOperations++; // Perform the operation
                        nums[i - 1] = divisor; // Set nums[i - 1] to this divisor
                        possible = true; // It's possible to proceed
                        if (i - 1 > 0 && nums[i - 1] < nums[i - 2]) {
                            possible = false; // Violation of non-decreasing condition with earlier element
                            totalOperations--;
                        }
                        break;
                    }
                }

                // If no valid divisor was found, return -1 (not possible to make the array non-decreasing)
                if (!possible) return -1;
            }
        }

        return totalOperations;
    }

    // Helper function to get all proper divisors of a number x
    private List<int> GetProperDivisors(int x) {
        List<int> divisors = new List<int>();
        for (int i = 1; i * i <= x; i++) {
            if (x % i == 0) {
                // i is a divisor
                if (i != x) divisors.Add(i);
                if (i != x / i && x / i != x) divisors.Add(x / i);
            }
        }
        divisors.Sort(); 
        return divisors;
    }

    public int MinOperationss(int[] nums) {
        int n = nums.Length;
        int totalOperations = 0;

        for (int i = 1; i < n; i++) {
            if (nums[i] < nums[i - 1]) {
                bool possible = false; 
                
                var divisors = GetProperDivisors(nums[i - 1]);
                
                foreach (var divisor in divisors) {
                    if (divisor <= nums[i]) {
                        totalOperations++; 
                        nums[i - 1] = divisor; 
                        possible = true; 
                        break;
                    }
                }

                if (!possible) return -1;
            }
        }

        return totalOperations;
    }

}