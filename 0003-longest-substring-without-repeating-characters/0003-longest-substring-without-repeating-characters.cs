public class Solution {
    public int LengthOfLongestSubstring(string s) {

        if(s.Length == 0){
            return 0;
        }

        string res = s[0].ToString();

        int result = 1;

        
        for(int i = 1; i < s.Length; i++){

            bool isOK = true;
            
            for(int j = 0; j < res.Length; j++){

                if(res[j] == s[i]){

                    isOK = false;
                    res = res.Substring(j+1) + s[i].ToString();
                    break;
                }
            }

            if(isOK){
                res += s[i].ToString();
            }

            result = Math.Max(result , res.Length);


        }

        return result;
    }
}