public class Solution {
    public string LongestPalindrome(string s) {

        if (string.IsNullOrEmpty(s)) return "";
        
        int Max = 0;
        int start = 0;
        int currentMAX = 0;

        for(int i = 0; i < s.Length; i++){

            int MID1 = A(s, i, i);
            int MID2 = A(s, i, i+1);         

            currentMAX = Math.Max(MID1, MID2);
            
            if(currentMAX > Max){

                Max = currentMAX;

                start = i - (Max -1)/2;
            }
        }

        return s.Substring(start, Max);


    }

    public int A(string s, int left, int right){

        while(left >= 0 && right < s.Length && s[left] == s[right]){
            left--;
            right++;
        }
        
        

        return right -left -1;;


    }
}