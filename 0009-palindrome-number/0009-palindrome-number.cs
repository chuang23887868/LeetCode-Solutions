public class Solution {
    public bool IsPalindrome(int x) {
        
        if(x < 0){
            return false;
        }

        string XX = x.ToString();

        int left = 0;
        int right = XX.Length - 1;

        while(left <= right){

            if(XX[left] == XX[right]){

                left++;
                right--;
            }
            else{
                return false;
            }
        }

        return true;
    }
}