public class Solution {
    public int RemoveElement(int[] nums, int val) {

        int now = 0;

        for(int i = 0; i < nums.Length; i++){

            if(val != nums[i]){

                nums[now] = nums[i];
                now++;

            }

        }

        return now;
        
    }
}