public class Solution {
    public int MaxArea(int[] height) {

        if(height.Length == 0){
            return 0;
        }
        int Max = 0;
        int heigh;

        int left = 0;
        int right = height.Length - 1;

        while(left < right){

            heigh = Math.Min(height[left], height[right]);

            Max = Math.Max(Max, heigh * (right - left));

            if(height[left] > height[right]){

                right--;
            }
            else{
                left++;
            }
        }

        return Max;
    }
}