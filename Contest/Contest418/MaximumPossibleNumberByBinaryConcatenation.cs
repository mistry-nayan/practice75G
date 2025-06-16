public class MaximumPossibleNumberByBinaryConcatenation
{
    public int MaxGoodNumber(int[] nums) {
                
        // Define all 6 possible permutations of 3 elements manually
        int[][] permutations = new int[][] {
            new int[] { nums[0], nums[1], nums[2] },
            new int[] { nums[0], nums[2], nums[1] },
            new int[] { nums[1], nums[0], nums[2] },
            new int[] { nums[1], nums[2], nums[0] },
            new int[] { nums[2], nums[0], nums[1] },
            new int[] { nums[2], nums[1], nums[0] }
        };
        int maxValue = 0;
        foreach (var perm in permutations) {
            // Concatenate the binary strings of the current permutation
            string concatenatedBinary = "";
            foreach (int num in perm) {
                concatenatedBinary += Convert.ToString(num, 2);
            }
            
            // Check if the concatenated binary string has no leading zeros
            if (concatenatedBinary.Length == 1 || concatenatedBinary[0] != '0') {
                int decimalValue = Convert.ToInt32(concatenatedBinary, 2);  // Convert binary string to decimal
                if (decimalValue > maxValue) {
                    maxValue = decimalValue;
                }
            }
        }
        
        return maxValue;
    }
    
}
/*
You are given an array of integers nums of size 3.

Return possible number whose binary representation can be formed by 
concatenating the binary representation of all elements in nums in some order.
Note that the binary representation of any number does not contain leading zeros

*/
