public class Solution {
    public int MyAtoi(string s) {
        
        if(s.Length == 0){
            return 0;
        }

        int now = 0;
        int sign = 1;

        while(now < s.Length && s[now] == ' ' ){//判斷空白
            now++;
        }

        if(now < s.Length && (s[now] == '+' || s[now] == '-')){

            sign = (s[now] == '-') ? -1 : 1;
            now++;
        }

        string res = "";

        for(; now < s.Length; now++){

            if(s[now] >= '0' && s[now] <= '9'){
                res += s[now].ToString();
            }
            else{
                break;
            }
        }

        if(res == ""){
            return 0;
        }

        long testRes;

        try{
            testRes = long.Parse(res) * sign;
        }
        catch{
            return sign == 1 ? int.MaxValue : int.MinValue;
        }


        if(testRes > int.MaxValue || testRes < int.MinValue){

            return sign == 1 ? int.MaxValue : int.MinValue;
        }

        int result = (int)testRes;

        return result;
        
    }
}