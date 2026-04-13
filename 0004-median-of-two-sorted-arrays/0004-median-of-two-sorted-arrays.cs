public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        
        int m = nums1.Length;
        int n = nums2.Length;

        int im = 0;//當前nums1的位置
        int inn = 0;//當前nums2的位置

        int [] res = new int [m + n];//存放2陣列的陣列

        int now = 0;

        while(im < m || inn < n){

            if(im == m){//nums1陣列已經沒有數字了

                res[now] = nums2[inn];
                inn++;
            }
            else if(inn == n){//nums2陣列已經沒有數字了

                res[now] = nums1[im];
                im++;
            }
            else{

                if(nums1[im] > nums2[inn]){//nums1當前的數字比較大

                    res[now] = nums2[inn];
                    inn++;
                }
                else{
                    res[now] = nums1[im];
                    im++;
                }
            }

            now++;
        }

        float MID;

        int MID2;

        int RL = res.Length;//新陣列的長度

        if(RL % 2 == 0){

            MID = res[RL / 2 - 1];
            MID2 = res[RL / 2];

            MID = (float)(MID + MID2) / 2;
        }
        else{

            MID = (float)res[(RL + 1) / 2 - 1];
        }

        return MID;

    }
}