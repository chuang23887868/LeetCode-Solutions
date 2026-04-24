public class Solution {
    public int SearchInsert(int[] nums, int target) {



        for(int i = 0; i < nums.Length; i++){

            if(nums[i] == target){

                return i;
            }
        }

        for(int j = nums.Length - 1; j >=0; j--){

            if(target > nums[j]){

                return j + 1;
            }
        }
        return 0;
        
    }
}