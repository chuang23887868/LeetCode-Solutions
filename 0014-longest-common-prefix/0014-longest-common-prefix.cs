public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        if(strs.Length == 0){
            
            return "";
        }
        

        for(int i = 0; i < strs[0].Length; i++){ // i代表當前字串的第i個字元

            int A = strs[0][i];

            for(int j = 0; j < strs.Length ; j++){ //j到表當前陣列內第j個字串

                if(strs[j].Length <= i || strs[j][i] != A){ //當前當前字串比第0個字串短時OR當前字元不相同時
                    
                    return strs[0].Substring(0, i);
                }
            }
        }

        return strs[0];
    }
}