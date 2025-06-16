public class Cognizant : InterviewQuestion
{
    public int GetLongestSubstringLength(string str1, string str2)
    {

        int maxLength = 0;

        // for(int i = 0; i < str1.Length; i++)
        // {
        //     for(int j = i + 1; j <= str1.Length; j++)
        //     {
        //         var subs = str1.Substring(i, j - i);
        //         if(str2.Contains(subs)){
        //             maxLength = Math.Max(maxLength, subs.Length);
        //         }
        //     }

        // }

        int m = str1.Length; int n = str2.Length;
        int[,] dp = new int[m + 1, n + 1];

        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if(str1[i - 1] == str2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                    maxLength = Math.Max(maxLength, dp[i, j]);
                }
            } 
        }

        return maxLength;
    }


}