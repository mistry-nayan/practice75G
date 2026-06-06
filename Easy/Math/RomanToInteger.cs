public class RomanToInteger {
    public int RomanToInt(string s) {
        var charValue = new Dictionary<char,int>();
        charValue.Add('I',1);
        charValue.Add('V',5);
        charValue.Add('X',10);
        charValue.Add('L',50);
        charValue.Add('C',100);
        charValue.Add('D',500);
        charValue.Add('M',1000);
        int res = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if((s[i] == 'V' || s[i] == 'X') && i - 1 >= 0){
                if(s[i - 1] == 'I'){
                    res += charValue[s[i]] - 2;
                    continue;
                }
            }
            else if((s[i] == 'L' || s[i] == 'C') && i - 1 >= 0){
                if(s[i - 1] == 'X'){
                    res += charValue[s[i]] - 20;
                    continue;
                } 
            }
            else if((s[i] == 'D' || s[i] == 'M') && i - 1 >= 0){
                if(s[i-1] == 'C'){
                    res += charValue[s[i]] - 200;
                    continue;
                }
            }
            
            res += charValue[s[i]];
        }
        return res;
    }

        public int RomanToInt2(string s) {
        var cV = new Dictionary<char,int>();
        cV.Add('I',1);
        cV.Add('V',5);
        cV.Add('X',10);
        cV.Add('L',50);
        cV.Add('C',100);
        cV.Add('D',500);
        cV.Add('M',1000);

        int total = 0;
        int prevValue = 0;
        foreach (char i in s)
        {
            int value = cV[i];
            if(value > prevValue){
                total += value - (2 * prevValue);
            }
            else{
                total += value;
            }
            prevValue = value;
        }
        return total;
        }
}