public class Solution {
    public int StrStr(string haystack, string needle) {
        
        if(needle.Length == 0){
            return 0;
        }

        for(int now = 0; now <= haystack.Length - needle.Length; now++){

            int i = 0;

            while(i < needle.Length && haystack[now + i] == needle[i]){

                i++;

            }

            if(i == needle.Length ){

                return now;
            }
        }

        return -1;
    }
}