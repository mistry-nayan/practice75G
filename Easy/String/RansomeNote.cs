public class RansomNote {
    public bool CanConstruct(string ransomNote, string magazine) {
        
        if(string.IsNullOrEmpty(ransomNote)|| string.IsNullOrEmpty(magazine)|| ransomNote.Length > magazine.Length)
        return false;
        int I = 0;
        int II = 0;
        int[] letterArray = new int [26];
        while(I < magazine.Length && II < ransomNote.Length){
            var magChar = magazine[I];
            var ransomeChar = ransomNote[II];
            letterArray[magChar - 'a'] += 1;
            letterArray[ransomeChar - 'a'] -= 1; 
            I++;
            II++;
        }

        if(I != magazine.Length - 1){
            while(I < magazine.Length){
            var magChar = magazine[I];
            letterArray[magChar - 'a'] += 1;
            I++;
            }
        }

        for(int III = 0; III < 26; III++){
            if(letterArray[III] < 0){
                return false;
            }
        }

        return true;

    }

     public bool CanConstruct2(string ransomNote, string magazine) {
        
        if(string.IsNullOrEmpty(ransomNote)|| string.IsNullOrEmpty(magazine)|| ransomNote.Length > magazine.Length)
        return false;

        int[] letterArray = new int [26];

        for(int i = 0; i < magazine.Length; i++){
            var magChar = magazine[i];
            letterArray[magChar - 'a'] += 1;
        }

        for(int i = 0; i < ransomNote.Length; i++){
            var ransomeChar = ransomNote[i];
            letterArray[ransomeChar - 'a'] -= 1; 
        }

        for(int III = 0; III < 26; III++){
            if(letterArray[III] < 0){
                return false;
            }
        }

        return true;

    }
}