public class SubStringWithKFrequency
{
    public int NumberOfSubstrings(string s, int k) {
        int n = s.Length;
        int totalCount = 0;

        // Iterate over all possible starting points for the substring
        for (int i = 0; i < n; i++) {
            int[] freq = new int[26]; // Frequency map for each substring
            // Expand the sliding window starting from index i
            for (int j = i; j < n; j++) {
                freq[s[j] - 'a']++; // Update the frequency for character s[j]

                // Check if any character appears at least k times
                if (freq[s[j] - 'a'] >= k) {
                    totalCount += (n - j); // All substrings starting from i and ending from j to n are valid
                    break; // No need to expand further for this starting index
                }
            }
        }

        return totalCount;         
    }
}