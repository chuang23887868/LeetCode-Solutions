public class Solution {
    public int RemoveDuplicates(int[] nums) {

        int now = 0;//用來記錄當前不重複的陣列內的位置

        
        for(int i = 1; i < nums.Length; i++){

            if(nums[now] != nums[i]){

                now++;

                nums[now] = nums[i];
            }
        }
        return now + 1;
    }
}