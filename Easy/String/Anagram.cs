public class Anagram {
    
    public bool IsAnagram(string s, string t) {
        int[] freq = new int[26];
        foreach (char c in s){
            ++freq[c - 'a'];
        }
        foreach (char c in t){
            --freq[c - 'a'];
        }
        foreach (int i in freq){
            if (i != 0)
                return false;
        }
        return true;
        // bool isAnagram = false;
        // Dictionary<char, int> charDict = new Dictionary<char, int>();

        // if(s.Length != t.Length)
        //     return isAnagram;

        // for (int I = 0; I < s.Length; I++)
        // {
        //     if(charDict.ContainsKey(s[I])){
        //         charDict[s[I]] = charDict[s[I]] + 1;
        //     }
        //     else
        //         charDict[s[I]] = 1;

        //     if(charDict.ContainsKey(t[I])){
        //         charDict[t[I]] = charDict[t[I]] - 1;
        //     }
        //     else{
        //         charDict[t[I]] = -1;
        //     }
        // }

        // foreach(char key in charDict.Keys){
        //     if(charDict[key] != 0){
        //         isAnagram = true;
        //         break;
        //     }
        // }

        // return !isAnagram;
    }


    // public void SortArray(){
    //     int[] ints = new int[]{-1, 2, -7, 1, -5, 9, 4};

    //     int index = 3;

    //     for (int i = 1; i < ints.Length; i++)
    //     {
    //         var temp = ints[i -1];
    //         ints[i] = 
    //     }        
    // }
}