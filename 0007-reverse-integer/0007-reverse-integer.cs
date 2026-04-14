public class Solution {
    public int Reverse(int x) {
        
        if(x == 0){
            return 0;
        }

        long newX = (long)x;

        bool isOK = true;

        if(newX < 0){
            isOK = false;
            newX *= -1;
        }

        string result = "";

        string XX = newX.ToString();

        int now = XX.Length - 1;

        while(now >= 0){
            
            result += XX[now];
            now--;
        }

        long resChk = long.Parse(result);

        if(!isOK){
            resChk *= -1;
        }

        if(resChk > int.MaxValue || resChk < int.MinValue){
            return 0;
        }

        int res = (int)resChk;

        

        return res;

        
    }
}