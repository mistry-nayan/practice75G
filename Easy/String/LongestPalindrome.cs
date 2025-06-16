using System.IO.Compression;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

public class LongPalindrome {
    public int LongestPalindrome(string s) {
        s = Regex.Replace(s,"[^a-zA-z]","");
        Console.WriteLine(s.Length); 
        if(s.Length == 1) return 1;
        int[] letterArray = new int[52];
        
        for (int I = 0; I < s.Length; I++)
        {
            var ind = s[I] - 'a';
            if(ind < 0){
                var lowerInd = Math.Abs(s[I] - 'A') + 26;
                letterArray[lowerInd] += 1;
            }
            else{
                letterArray[ind] += 1;
            }
        }

        int stringLength = 0;
        int oddSum = 0;
        int longestOdd = 0;
        foreach (var item in letterArray)
        {
            if(item % 2 == 1){
                if(longestOdd < item) {
                    if(longestOdd == 0) oddSum += longestOdd;
                    else oddSum += longestOdd - 1;
                    longestOdd = item;
                } 
                else{
                    oddSum += item - 1;
                }
            }
            else{
                stringLength += item;
            }            
        }
        var ts = stringLength + oddSum + longestOdd;
        return ts;
    }
}