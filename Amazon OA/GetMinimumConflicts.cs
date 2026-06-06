using System;

public class GetMinimumConflict
{
    public static int GetMinimumConflicts(string primary, string secondary)
    {
        int m = primary.Length;
        int n = secondary.Length;

        // ─────────────────────────────────────────────
        // PRECOMPUTATION
        // prefP[i][c] = number of chars > c in primary[0..i-1]
        // prefS[j][c] = number of chars > c in secondary[0..j-1]
        // This lets us compute conflict cost in O(1) per DP state
        // ─────────────────────────────────────────────
        int[,] prefP = new int[m + 1, 26];
        int[,] prefS = new int[n + 1, 26];

        // Build prefix greater counts for primary
        for (int i = 0; i < m; i++)
        {
            for (int c = 0; c < 26; c++)
                prefP[i + 1, c] = prefP[i, c];

            // All chars < primary[i] now have one more char > them
            int pi = primary[i] - 'a';
            for (int c = 0; c < pi; c++)
                prefP[i + 1, c]++;
        }

        // Build prefix greater counts for secondary
        for (int j = 0; j < n; j++)
        {
            for (int c = 0; c < 26; c++)
                prefS[j + 1, c] = prefS[j, c];

            int si = secondary[j] - 'a';
            for (int c = 0; c < si; c++)
                prefS[j + 1, c]++;
        }

        // ─────────────────────────────────────────────
        // DP
        // dp[i][j] = min conflicts using first i chars
        //            of primary and first j of secondary
        // ─────────────────────────────────────────────
        int[,] dp = new int[m + 1, n + 1];

        // Initialize all to max
        for (int i = 0; i <= m; i++)
            for (int j = 0; j <= n; j++)
                dp[i, j] = int.MaxValue;

        dp[0, 0] = 0;

        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (dp[i, j] == int.MaxValue) continue;

                // ─────────────────────────────────────
                // Option A: Take primary[i]
                // Cost = chars already placed that are > primary[i]
                // ─────────────────────────────────────
                if (i < m)
                {
                    int c = primary[i] - 'a';

                    // Conflicts with already placed chars:
                    //   from primary[0..i-1] that are > primary[i]
                    //   from secondary[0..j-1] that are > primary[i]
                    int cost = prefP[i, c] + prefS[j, c];

                    dp[i + 1, j] = Math.Min(dp[i + 1, j], dp[i, j] + cost);
                }

                // ─────────────────────────────────────
                // Option B: Take secondary[j]
                // Cost = chars already placed that are > secondary[j]
                // ─────────────────────────────────────
                if (j < n)
                {
                    int c = secondary[j] - 'a';

                    int cost = prefP[i, c] + prefS[j, c];

                    dp[i, j + 1] = Math.Min(dp[i, j + 1], dp[i, j] + cost);
                }
            }
        }

        return dp[m, n];
    }

    // ─────────────────────────────────────────────
    // TEST CASES
    // ─────────────────────────────────────────────
    public static void MainA(string[] args)
    {
        RunTest("Given Example",      "zc",  "d",   2);
        RunTest("Sample Case 0",      "dae", "add", 1);
        RunTest("Sample Case 1",      "aaa", "abb", 0);
        RunTest("Already sorted",     "abc", "def", 0);
        RunTest("Reverse order",      "cba", "fed", 9);
        RunTest("Single chars",       "b",   "a",   1);
        RunTest("All same",           "aaa", "aaa", 0);
        RunTest("One empty-ish",      "a",   "z",   0);
    }

    static void RunTest(string name, string p, string s, int expected)
    {
        int result = GetMinimumConflicts(p, s);
        bool pass = result == expected;
        Console.WriteLine($"{(pass ? "Passed" : "Failed")} {name}");
        Console.WriteLine($"   Primary   : {p}");
        Console.WriteLine($"   Secondary : {s}");
        Console.WriteLine($"   Expected  : {expected}");
        Console.WriteLine($"   Got       : {result}");
        Console.WriteLine();
    }
}