public class Solution {
    public int RomanToInt(string s) {

        if(s.Length == 0){
            
            return 0;
        }
        
        int res = 0;

        for(int i = 0; i < s.Length; i++){

            if(s[i] == 'I'){

                res += 1;
            }

            if(s[i] == 'V'){

                res += 5;
            }

            if(s[i] == 'X'){

                res += 10;
            }

            if(s[i] == 'L'){

                res += 50;
            }

            if(s[i] == 'C'){

                res += 100;
            }

            if(s[i] == 'D'){

                res += 500;
            }

            if(s[i] == 'M'){

                res += 1000;
            }
        }

        for(int j = 0; j < s.Length - 1; j++){

            if(s[j] == 'I' && (s[j + 1] == 'V' || s[j + 1] == 'X')){

                res -= 2;
            }

            if(s[j] == 'X' && (s[j + 1] == 'L' || s[j + 1] == 'C')){

                res -= 20;
            }

            if(s[j] == 'C' && (s[j + 1] == 'D' || s[j + 1] == 'M')){

                res -= 200;
            }
        }

        return res;
    }
}