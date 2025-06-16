using System.Text;

public class Contest421
{
    public int LengthAfterTransformations1(string s, int t) {
        if(t == 0) return s.Length;

        for (int i = 0; i < t; i++)
        {
            StringBuilder str = new StringBuilder();
            foreach (var item in s)
            {
                str.Append(charMap[item]);
            }
            s = str.ToString();
        }

        return s.Length;
    }

    public int LengthAfterTransformations(string s, int t) {
        const int MOD = 1000000007;
        long length = s.Length;
        long zCount = 0;

        // Count the number of 'z's in the original string
        foreach (char c in s)
        {
            if (c == 'z')
            {
                zCount++;
            }
        }

        // The maximum transformations before a character can reach 'z'
        long canTransformToZ = Math.Min(t, 25);

        // Each 'z' will contribute double its count in the next transformation
        // (1 << (t - 1)) is equivalent to 2^(t-1)
        length += zCount * (1 << (t - 1)) % MOD;

        if (t > 0)
        {
            // Other characters that can become 'z'
            var d = (length - zCount) * canTransformToZ % MOD;
            length += d;
        }

        return (int)(length % MOD);
    }

    public Dictionary<char, char[]> charMap = new Dictionary<char, char[]>{
        { 'a', new char[] { 'b' } },
    { 'b', new char[] { 'c' } },
    { 'c', new char[] { 'd' } },
    { 'd', new char[] { 'e' } },
    { 'e', new char[] { 'f' } },
    { 'f', new char[] { 'g' } },
    { 'g', new char[] { 'h' } },
    { 'h', new char[] { 'i' } },
    { 'i', new char[] { 'j' } },
    { 'j', new char[] { 'k' } },
    { 'k', new char[] { 'l' } },
    { 'l', new char[] { 'm' } },
    { 'm', new char[] { 'n' } },
    { 'n', new char[] { 'o' } },
    { 'o', new char[] { 'p' } },
    { 'p', new char[] { 'q' } },
    { 'q', new char[] { 'r' } },
    { 'r', new char[] { 's' } },
    { 's', new char[] { 't' } },
    { 't', new char[] { 'u' } },
    { 'u', new char[] { 'v' } },
    { 'v', new char[] { 'w' } },
    { 'w', new char[] { 'x' } },
    { 'x', new char[] { 'y' } },
    { 'y', new char[] { 'z' } },
    { 'z', new char[] { 'a', 'b' } }
    };

    public long MaxScore(int[] nums) {
        int n = nums.Length;
        
        if (n == 1) return (long)nums[0] * nums[0];

        long maxFactorScore = 0;

        int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);

        long LCM(int a, int b) => (long)a / GCD(a, b) * b;

        int overallGCD = nums[0];
        long overallLCM = nums[0];

        for (int i = 1; i < n; i++)
        {
            overallGCD = GCD(overallGCD, nums[i]);
            overallLCM = LCM((int)overallLCM, nums[i]);
        }

        maxFactorScore = overallGCD * overallLCM;

        for (int i = 0; i < n; i++)
        {
            int currentGCD = 0;
            long currentLCM = 1;

            for (int j = 0; j < n; j++)
            {
                if (j != i)  
                {
                    currentGCD = GCD(currentGCD, nums[j]);
                    currentLCM = LCM((int)currentLCM, nums[j]);
                }
            }

            long factorScoreAfterRemoval = currentGCD * currentLCM;

            maxFactorScore = Math.Max(maxFactorScore, factorScoreAfterRemoval);
        }

        return maxFactorScore;
    }

}