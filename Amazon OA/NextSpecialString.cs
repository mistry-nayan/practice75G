/*
The GetNextSpecialString method computes the lexicographically smallest special string (no adjacent identical characters) 
greater than the input s, or returns "-1" if none exists.

It iterates through each position in s, 
attempting to increase the character to the smallest valid value (not matching neighbors), 
then fills the suffix with the smallest possible valid characters. 

For each valid candidate string, it verifies it's greater than s and special, 
retaining the smallest one. 

Time: O(n * 26 * n) worst-case, 
but efficient in practice due to early termination. 

For s = "abbd", it returns "abca".
*/


public class NextSpecialString
{
    public string GetNextSpecialString(string s)
    {
        if (string.IsNullOrEmpty(s)) return "a";

        char[] chars = s.ToCharArray();
        int n = chars.Length;

        string best = null;

        // Try to increase at each position from left to right to find the smallest greater special string
        for (int pos = 0; pos < n; pos++)
        {
            char original = chars[pos];
            for (char c = (char)(original + 1); c <= 'z'; c++)
            {
                bool valid = true;
                if (pos > 0 && c == chars[pos - 1]) valid = false;
                if (pos < n - 1 && c == chars[pos + 1]) valid = false;
                if (valid)
                {
                    char[] newChars = (char[])chars.Clone();
                    newChars[pos] = c;
                    bool canSetSuffix = true;
                    for (int j = pos + 1; j < n; j++)
                    {
                        char min = 'a';
                        while (min <= 'z')
                        {
                            bool v = true;
                            if (j > 0 && min == newChars[j - 1]) v = false;
                            if (j < n - 1 && min == newChars[j + 1]) v = false;
                            if (v) break;
                            min++;
                        }
                        if (min > 'z')
                        {
                            canSetSuffix = false;
                            break;
                        }
                        newChars[j] = min;
                    }
                    if (canSetSuffix)
                    {
                        string result = new string(newChars);
                        if (string.Compare(result, s) > 0 && IsSpecial(result))
                        {
                            if (best == null || string.Compare(result, best) < 0)
                            {
                                best = result;
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine("Ans: " + (best ?? "-1"));
        return best ?? "-1";
    }

    private bool IsSpecial(string str)
    {
        for (int i = 1; i < str.Length; i++)
        {
            if (str[i] == str[i - 1]) return false;
        }
        return true;
    }
}

public class NextSpecialString1
{
    //Optimized version with O(n) time complexity by directly backtracking from the rightmost position to find the next valid increment point,
    //then filling the suffix with the smallest valid characters. This avoids generating all candidates and checking them.
    public string GetNextSpecialString(string s)
{
    int n = s.Length;
    char[] arr = s.ToCharArray();

    // ─────────────────────────────────────────────
    // PHASE 1: Check if already special
    // ─────────────────────────────────────────────
    bool isSpecial = true;
    for (int i = 1; i < n; i++)
    {
        if (s[i] == s[i - 1])
        {
            isSpecial = false;
            break;
        }
    }

    // ─────────────────────────────────────────────
    // PHASE 2: Find increment position
    // If not special → start from first duplicate
    // If special     → start from last position (n-1)
    // ─────────────────────────────────────────────
    int idx = -1;

    if (!isSpecial)
    {
        // Find first duplicate position
        for (int i = 1; i < n; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                idx = i; // start backtracking from here
                break;
            }
        }
    }
    else
    {
        idx = n - 1; // already special → backtrack from end
    }

    // ─────────────────────────────────────────────
    // PHASE 3: Backtrack from idx to find rightmost
    // valid increment position
    // ─────────────────────────────────────────────
    while (idx >= 0)
    {
        char left = idx > 0 ? arr[idx - 1] : '\0';

        char found = '\0';
        for (char c = (char)(arr[idx] + 1); c <= 'z'; c++)
        {
            if (c != left)
            {
                found = c;
                break;
            }
        }

        if (found != '\0')
        {
            arr[idx] = found;
            break;
        }

        idx--; // backtrack
    }

    if (idx < 0) 
    {
        Console.WriteLine("-1");
        return "-1";
    }

        // ─────────────────────────────────────────────
        // PHASE 4: Fill suffix minimally ALWAYS
        // This guarantees lex smallest result
        // ─────────────────────────────────────────────
        for (int j = idx + 1; j < n; j++)
        {
            char left = arr[j - 1];
            arr[j] = (left != 'a') ? 'a' : 'b';
        }

        string ans = new string(arr);
        Console.WriteLine(ans);
        return ans;
    }
        
}